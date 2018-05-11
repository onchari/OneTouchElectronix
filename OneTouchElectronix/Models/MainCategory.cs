using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OneTouchElectronix.Models
{
    public class MainCategory
    {
        public int MainCategoryId { get; set; }

        [Display(Name ="Main Category Name")]
        public string MainCategoryName { get; set; }
    }
}