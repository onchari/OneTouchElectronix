using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OneTouchElectronix.Interfaces
{
    interface IControllers
    {
        ActionResult Index();
        ActionResult Create();
        ActionResult Delete();
        ActionResult Details();
        ActionResult Edit();
        ActionResult DeleteConfirmed();
    }
}
