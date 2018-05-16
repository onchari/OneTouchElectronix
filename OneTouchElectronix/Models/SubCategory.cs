
using System.ComponentModel.DataAnnotations;
namespace OneTouchElectronix.Models
{
    public class SubCategory 
    {
       [Key]
        public int SubCategoryId { get; set; }

        [Display(Name="Sub Category Name")]
        [Required]
        public string SubCategoryName { get;set; }

        [Display(Name ="Sub-Category Descrition")]
        public string SubCategoryDescription { get; set; }

     
        public int  MainCategoryId { get; set; }
        public MainCategory MainCategory { get; set; }
    }
}