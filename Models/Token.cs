using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpProject.Models
{
    public class Token
    {

    [Key]
    public string TokenId { get; set; }

    public string UserEmail { get; set; }
    public DateTime ExpirationDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

} 
}
