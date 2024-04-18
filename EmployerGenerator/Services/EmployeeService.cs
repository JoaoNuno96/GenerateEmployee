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

        public string FirstNameGet()
        {
            List<string> list = new List<string>();

            string sourceFN = Source + @"FirstName.txt";

            Random random = new Random();
            int index = random.Next(0,14);

            using (StreamReader sr = File.OpenText(sourceFN))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    list.Add(line);
                }
            }

            return list[index].ToString();

        }

        public string LastNameGet()
        {
            List<string> list = new List<string>();

            string sourceFN = Source + @"LastName.txt";

            Random random = new Random();
            int index = random.Next(0, 14);

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

        public string JobGet()
        {
            List<string> list = new List<string>();

            string sourceFN = Source + @"Job.txt";

            Random random = new Random();
            int index = random.Next(0, 14);

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

        public string EmailGet()
        {
            return (FirstNameGet() + LastNameGet()).ToLower() + "@teste.pt";
        }

        public string AgeGet()
        {
            List<string> list = new List<string>();

            string sourceFN = Source + @"Age.txt";

            Random random = new Random();
            int index = random.Next(0, 14);

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
        public string NationalityGet()
        {
            List<string> list = new List<string>();

            string sourceFN = Source + @"Nationality.txt";

            Random random = new Random();
            int index = random.Next(0, 14);

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

        public string StrongPoint()
        {
            List<string> list = new List<string>();

            string sourceFN = Source + @"StrongPoints.txt";

            Random random = new Random();
            int index = random.Next(0, 10);

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
