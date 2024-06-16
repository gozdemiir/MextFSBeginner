using MextFSBeginner.Domain.Entities;
using MextFSBeginner.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFSBeginner.Domain.Services
{
    public class AccessControlLogManager
    {
        private string filePath;

        public List<AccessControlLog>LoadFormFile(string filePat = "C:\\Users\\Monster\\Desktop\\AccessControlLogs.txt")
        {
            string fileContent = File.ReadAllText(filePath);

            string[] lines = fileContent.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            var accessControlLogs = new List<AccessControlLog>();

            foreach (var line in lines)
            {
                string[] properties = line.Split("---", StringSplitOptions.RemoveEmptyEntries);

                var accessControlLog = new AccessControlLog()
                {
                    Id = Guid.NewGuid(),
                    UserId = Convert.ToInt32(properties[0]),
                    DeviceSerialNumber = properties[1],
                    AccessType = Enum.Parse<AccessType>(properties[2]),
                    Date = Convert.ToDateTime(properties[3])
                };

                accessControlLogs.Add(accessControlLog);
            }

            return accessControlLogs;
        }

        public object LoadFromFile()
        {
            throw new NotImplementedException();
        }

        public void WriteToFile(string filePath, List<AccessControlLog> accessControlLogs, string seperator)
        {
            List<string> lines = new List<string>();

            foreach (var accessControlLog in accessControlLogs)
            {
                lines.Add($"{seperator}{accessControlLog.UserId}{seperator}{accessControlLog.DeviceSerialNumber}{seperator}{accessControlLog.AccessType}{seperator}{accessControlLog.Date.ToString("yyyy-MM-ddTHH:mm:ssK")}");
            }

            var textContent = string.Join("\n", lines);

            File.WriteAllText(filePath, textContent);

            //string stringLines = "";

            //foreach (var accessControlLog in accessControlLogs)
            //{
            //  stringLines += $"{seperator}{accessControlLog.UserId}{seperator}{accessControlLog.DeviceSerialNumber}{seperator}{accessControlLog.AccessType}{seperator}{accessControlLog.Date.ToString("yyyy-MM-ddTHH:mm:ssK")}\n";
            //}

            //File.WriteAllText(filePath, stringLines);
        }

    }
}

