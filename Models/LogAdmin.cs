using System.ComponentModel.DataAnnotations;

public class LogAdmin
{
    [Required(ErrorMessage = "Email is required.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}