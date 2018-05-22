using System.ComponentModel.DataAnnotations;
using System.Web;

namespace DSL.Models
{
    public class CvFormModel
    {
        [Required(ErrorMessage = "Missing name")]
        public string FromName { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Enter Email correctly")]
        public string FromEmail { get; set; }
      /* [Required(ErrorMessage = "Please enter your message")]
        public string Message { get; set; }*/
        [Required(ErrorMessage = "Wrong type of file")]
        public HttpPostedFileBase Upload { get; set; }
    }
}