using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsLogin
{
    class SearchDataTime
    {
        private string startSearchDataTime;
        private string endSearchDataTime;

        public SearchDataTime(string startSearchDataTime, string endSearchDataTime)
        {
            this.startSearchDataTime = startSearchDataTime;
            this.endSearchDataTime = endSearchDataTime;
        }

        public string StartData()
        {
            string output = String.Empty;

            MatchCollection regex = Regex.Matches(this.startSearchDataTime,
                "^(\\d{2})\\.(\\d{2})\\.(\\d{4})\\s(\\d{2})\\:(\\d{2})\\:(\\d{2})$");

            foreach (Match r in regex)
            {
                if (r.Groups[1].Value == "" || r.Groups[2].Value == "" || r.Groups[3].Value == "")
                {
                    break;
                }

                output = $"{r.Groups[2].Value}/{r.Groups[1].Value}/{r.Groups[3].Value}"
                        .Trim()
                        .ToString();
            }

            if (output == String.Empty)
            {
                return String.Empty;
            }

            return output;
        }

        public string EndData()
        {
            string output = String.Empty;

            MatchCollection regex = Regex.Matches(this.endSearchDataTime,
                "^(\\d{2})\\.(\\d{2})\\.(\\d{4})\\s(\\d{2})\\:(\\d{2})\\:(\\d{2})$");

            foreach (Match r in regex)
            {
                if (r.Groups[1].Value == "" || r.Groups[2].Value == "" || r.Groups[3].Value == "")
                {
                    break;
                }

                output = $"{r.Groups[2].Value}/{r.Groups[1].Value}/{r.Groups[3].Value}"
                        .Trim()
                        .ToString();
            }

            if (output == String.Empty)
            {
                return String.Empty;
            }

            return output;
        }

        public string StartTime()
        {
            Match regex = Regex.Match(this.startSearchDataTime, "(\\d{2})\\:(\\d{2})\\:(\\d{2})$");

            if (!regex.Success)
            {
                return String.Empty;
            }

            return regex.Value;
        }

        public string EndTime()
        {
            Match regex = Regex.Match(this.endSearchDataTime, "(\\d{2})\\:(\\d{2})\\:(\\d{2})$");

            if (!regex.Success)
            {
                return String.Empty;
            }

            return regex.Value;
        }
    }
}
