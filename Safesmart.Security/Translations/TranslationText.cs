using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safesmart.Security.Translations
{
    class TranslationText
    {
        private Dictionary<string, string> bgText = new Dictionary<string, string>() {
            { "exit", "ИЗХОД" },
            { "in", "ВХОД" },
            { "portalOut", "ПОРТАЛ ВЪТРЕШЕН" },
            { "portal", "ПОРТАЛ" },
            { "allDepartments", "ВСИЧКИ ОТДЕЛИ" },
            { "allOfficers", "ВСИЧКИ СЛУЖИТЕЛИ"},
            { "process", "Oбработени данни" },
            { "done", "Готово!" },
            { "emptyExcel", "Няма нищо за експорт към excel."},
            { "emptyOfficers", "Няма намерени служители." },
            { "noConnectionBase", "Няма връзка с базата: "},
            { "excelA", "ИМЕ ПРЕЗИМЕ ФАМИЛИЯ" },
            { "excelB", "ДАТА ЧАС" },
            { "excelC", "ПОРТАЛ" },
            { "excelD", "ВХОД/ИЗХОД" },
            { "excelE", "ОТДЕЛ" },
        };

        public string Get(string key)
        {
            if (!bgText.ContainsKey(key))
            {
                throw new Exception("Несъществува описаното име в Message.cs class!!!");
            }

            return bgText[key];
        }
    }
}
