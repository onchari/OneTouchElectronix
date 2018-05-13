using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneTouchElectronix.Models
{
    public class SubTests 
    {
        public int SubTestId { get; set; }
        public string SubTestName { get; set; }

        public int ID { get; set; }
        public virtual TEST Test { get; set; }
    }
}