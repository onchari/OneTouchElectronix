using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OneTouchElectronix.Models
{
    public class MainCategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MainCategoryId { get; set; }

        [Required]
        [Display(Name ="Main Category Name")]
        public string MainCategoryName { get; set; }

        [Display(Name ="Main Category Description")]
        public string MainCategoryDescription { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}