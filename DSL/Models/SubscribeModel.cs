using System.ComponentModel.DataAnnotations;
using System.Web;

namespace DSL.Models
{
    public class SubcscribeModel
    {
        [Required(ErrorMessage = "Enter your Email")]
        [EmailAddress(ErrorMessage = "Wrong Email")]
        public string FromEmail { get; set; }
    }
}