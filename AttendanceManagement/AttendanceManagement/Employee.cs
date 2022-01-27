using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement
{
    public class Employee
    {
        public DateTime day { get; set; }
        public string EmpNumber { get; set; }
        public string Name { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }
        public DateTime StartRest { get; set; }
        public DateTime EndRest { get; set; }
    }
}
