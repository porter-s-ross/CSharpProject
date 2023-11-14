using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CSharpProject.Models
{
    public class Admin
    {
        [Key]
        public int AdminId {get;set;}

        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}
        
        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
        // set up one to many
        public List<Product> Inventory {get;set;}
        // set up many to many
    }
}