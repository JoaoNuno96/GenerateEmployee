using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace EmployerGenerator.Services
{
    class EmployeeService
    {
        public string Source { get; set; } = (AppContext.BaseDirectory.Substring(0, 68) + @"\Repository\").ToString();
        public EmployeeService() { }

        public string GetDetails(string detail)
        {
            List<string> list = new List<string>();

            string sourceFN = Source + @$"{detail}.txt";

            Random random = new Random();
            int index = random.Next(0, 11);

            using (StreamReader sr = File.OpenText(sourceFN))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    list.Add(line);
                }
            }

            return list[index].ToString();
        }
        
    }
}
