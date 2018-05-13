using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneTouchElectronix.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public int StandardId { get; set; }
        public Standard Standard { get; set; }
    }
}