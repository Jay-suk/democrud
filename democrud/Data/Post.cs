using System.ComponentModel.DataAnnotations;

namespace aspnetserver.Data
{
    internal sealed class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "First Name should contain alphabets only.")]
        [StringLength(20, ErrorMessage = "First Name cannot exceed 20 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Last Name should contain alphabets only.")]
        [StringLength(20, ErrorMessage = "Last Name cannot exceed 20 characters.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "MobileNo is required.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "MobileNo should contain digits only.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "MobileNo must be exactly 10 digits.")]
        public string MobileNo { get; set; } = string.Empty;

        //[Required(ErrorMessage ="Age is required.")]
        [Range(1, 100, ErrorMessage = "Age should be between 1 and 100.")]
        public int? Age { get; set; }
    }
}