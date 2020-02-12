using Safesmart.Security.Translations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLogin
{
    class AssController
    {
        TranslationText translationText = new TranslationText();

        public int SearchDepartment(string comboBoxDepartmenText)
        {
            Dictionary<int, string> department = Department();

            return department
                .Where(v => v.Value == comboBoxDepartmenText)
                .Select(k => k.Key)
                .FirstOrDefault();
        }

        public Dictionary<int, string> Department()
        {
            string query = "SELECT `DepartmentID`, `DepartmentName` " +
                "FROM `Department` ORDER BY `DepartmentID`";

            ConnectMDB myDataTable = new ConnectMDB(query);

            Dictionary<int, string> department = myDataTable
                .ConnectDB()
                .AsEnumerable()
                .ToDictionary(
                r => r.Field<int>("DepartmentID"),
                r => r.Field<string>("DepartmentName"));
            return department;
        }
        
        public int OrdinalOptional(string comboBoxInOutDoor)
        {
            if (comboBoxInOutDoor.Trim() == translationText.Get("exit"))
            {
                return 0;
            }

            if (comboBoxInOutDoor.Trim() == translationText.Get("in"))
            {
                return 1;
            }

            return -1;
        }

        public string SearchUserName(string searchUserName)
        {
            if (searchUserName != translationText.Get("allOfficers") && searchUserName.Count() > 0)
            {
                return searchUserName;
            }

            return String.Empty;
        }

        public EventRecord EventRecordRead(string startSearchData, string endSearchData,
            string startSearchTime, string endSearchTime, int ctrlIDOptional, int ordinalOptional)
        {
            string query = $"SELECT `AriseTime`, `CardLow`, `CtrlID`, `Ordinal` " +
                $"FROM `EventRecord` " +
                $"WHERE `CtrlID`={ctrlIDOptional} " +
                $"AND `Ordinal`={ordinalOptional} " +
                $"AND AriseTime Between #{startSearchData} 00:00:00# And #{endSearchData} 23:59:59# " +
                $"AND ((TimeValue(AriseTime) Between #{startSearchTime}# And #{endSearchTime}#)) " +
                $"ORDER BY `AriseTime`";

            ConnectMDB myDataTable = new ConnectMDB(query);

            EventRecord eventRecord = new EventRecord
            {
                CardLow = myDataTable.ConnectDB()
                    .AsEnumerable()
                    .Select(r => r.Field<int>("CardLow"))
                    .ToList(),
                AriseTime = myDataTable.ConnectDB()
                    .AsEnumerable()
                    .Select(r => r.Field<DateTime>("AriseTime"))
                    .ToList(),
                CtrlID = myDataTable.ConnectDB()
                    .AsEnumerable()
                    .Select(r => r.Field<int>("CtrlID"))
                    .ToList(),
                Ordinal = myDataTable.ConnectDB()
                    .AsEnumerable()
                    .Select(r => r.Field<byte>("Ordinal"))
                    .ToList()
            };

            return eventRecord;
        }

        public Dictionary<int, Employee> CardEmployeeDepart(string searchUserName, int searchDepartment)
        {
            string query = "SELECT c.CardLow AS cardLow, d.DepartmentName AS dName, e.EmployeeName AS eName " +
                "FROM ((`Employee` AS e " +
                "INNER JOIN  `Card` AS c ON e.EmployeeID = c.EmployeeID )" +
                "INNER JOIN `Department` AS d ON e.DepartmentID = d.DepartmentID )";

            if (searchDepartment > 0 && searchUserName.Length == 0)
            {
                query = "SELECT c.CardLow AS cardLow, d.DepartmentName AS dName, e.EmployeeName AS eName " +
                "FROM ((`Employee` AS e " +
                "INNER JOIN  `Card` AS c ON e.EmployeeID = c.EmployeeID )" +
                "INNER JOIN `Department` AS d ON e.DepartmentID = d.DepartmentID )" +
                $"WHERE e.DepartmentID={searchDepartment}";
            }

            if (searchDepartment == 0 && searchUserName.Length > 0)
            {
                query = "SELECT c.CardLow AS cardLow, d.DepartmentName AS dName, e.EmployeeName AS eName " +
                "FROM ((`Employee` AS e " +
                "INNER JOIN  `Card` AS c ON e.EmployeeID = c.EmployeeID )" +
                "INNER JOIN `Department` AS d ON e.DepartmentID = d.DepartmentID )" +
                $"WHERE e.EmployeeName='{searchUserName}'";
            }

            if (searchUserName.Length > 0 && searchDepartment > 0)
            {
                query = "SELECT c.CardLow AS cardLow, d.DepartmentName AS dName, e.EmployeeName AS eName " +
                "FROM ((`Employee` AS e " +
                "INNER JOIN  `Card` AS c ON e.EmployeeID = c.EmployeeID )" +
                "INNER JOIN `Department` AS d ON e.DepartmentID = d.DepartmentID )" +
                $"WHERE e.DepartmentID={searchDepartment} " +
                $"AND e.EmployeeName='{searchUserName}'";
            }

            ConnectMDB myDataTable = new ConnectMDB(query);
            Dictionary<int, Employee> cardLowNameDepart = new Dictionary<int, Employee>();

            foreach (var item in myDataTable.ConnectDB().AsEnumerable())
            {
                if (!cardLowNameDepart.ContainsKey(item.Field<int>("cardLow")))
                {
                    cardLowNameDepart[item.Field<int>("cardLow")] = new Employee();
                }

                Employee employee = new Employee
                {
                    EmployeeName = item.Field<string>("eName"),
                    DepartmentName = item.Field<string>("dName")
                };
                cardLowNameDepart[item.Field<int>("cardLow")] = employee;
            }

            return cardLowNameDepart;
        }
        
        public Dictionary<int, string> DoorOrdinal()
        {
            Dictionary<int, string> doorOrdinal = new Dictionary<int, string>
            {
                { 0, translationText.Get("exit")},
                { 1, translationText.Get("in") }
            };

            return doorOrdinal;
        }

        public Dictionary<int, string> DoorCtrlID()
        {
            Dictionary<int, string> doorCtrlID = new Dictionary<int, string>
            {
                { 4, translationText.Get("portalOut") },
                { 3, translationText.Get("portal") }
            };

            return doorCtrlID;
        }
    }
}
