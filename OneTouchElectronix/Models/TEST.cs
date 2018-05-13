using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneTouchElectronix.Models
{
    public class TEST
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public ICollection<SubTests> SubTests { get; set; }
    }
}