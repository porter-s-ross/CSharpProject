using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CSharpProject.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        public string Name {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}
        
        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PassConfirm {get;set;}

        // set up one to many

        // set up many to many

        public List<ShoppingCart> UserCart {get;set;}

    }
}