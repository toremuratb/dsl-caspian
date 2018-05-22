using System.ComponentModel.DataAnnotations;

namespace DSL.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Enter Company name correctly")]
        public string FromCname { get; set; }
        [Required(ErrorMessage = "Enter phone number")]
        public string FromPhone { get; set; }
        [Required(ErrorMessage = "Enter name correctly")]
        public string FromName { get; set; }
        [Required(ErrorMessage = "Enter email correctly")]
        [EmailAddress(ErrorMessage = "Enter email correctly")]
        public string FromEmail { get; set; }
        [Required(ErrorMessage = "ContactMessageVal")]
        public string Message { get; set; }
    }
}