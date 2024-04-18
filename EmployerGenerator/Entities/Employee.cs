using EmployerGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployerGenerator.Entities
{
    class Employee
    {
        private readonly EmployeeService _service;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public string StrongPoint { get; set; }
        
        public Employee(EmployeeService service)
        {
            _service = service;
        }

        public void ProcessData()
        {
            FirstName = _service.FirstNameGet();
            LastName = _service.LastNameGet();
            Job = _service.JobGet();
            Email = _service.EmailGet();
            Age = int.Parse(_service.AgeGet());
            Nationality = _service.NationalityGet();
            StrongPoint = _service.StrongPoint();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("+");
            sb.Append("__________________________________________________");
            sb.AppendLine("+");
            sb.AppendLine("| Name: " + FirstName + " " + LastName);
            sb.AppendLine("| Email: " + Email);
            sb.AppendLine("| Job: " + Job);
            sb.AppendLine("| Age: " + Age);
            sb.AppendLine("| Nationality: " + Nationality);
            sb.AppendLine("| Strong Point: " + StrongPoint);
            sb.Append("+");
            sb.Append("__________________________________________________");
            sb.Append("+");

            return sb.ToString();
            
        }
    }
}
