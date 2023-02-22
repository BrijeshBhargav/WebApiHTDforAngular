using System.ComponentModel.DataAnnotations;

namespace WebApiHTDforAngular.Model
{
    public class Register
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "enter u r FirstName ")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "enter u r LastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "enter u r emailid")]
        [RegularExpression(@"^\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression(@"^((?=.[a-z])(?=.[A-Z])(?=.*\d)).+$", ErrorMessage = "password is not valid")]

        public string Password { get; set; }
        [Required(ErrorMessage = "gender is requried")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "enter u r data of birth")]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "enter u r Role")]
        public string Role { get; set; }
        [Required(ErrorMessage = "enter u r Status")]
        public Boolean Status { get; set; }

    }
}
 
