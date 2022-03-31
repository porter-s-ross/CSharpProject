using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CSharpProject.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}

        [Required]
        public string Artist {get;set;}

        [Required]
        public string Title {get;set;}

        [Required]
        public string Label {get;set;}

        [Required]
        public string CatalogNumber {get;set;}

        [Required]
        public string Format {get;set;}

        [Required]
        public string ImageUrl {get;set;}

        [Required]
        public string Description {get;set;}

        [Required]
        public string Genre {get;set;}

        [Required]
        public string Style {get;set;}

        [Required]
        public double Price {get;set;}

        [Required]

        public int Quantity {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        // public int AdminId {get;set;}
        // public Admin ListedBy {get;set;}

        public int CategoryId {get;set;}
        public Category MediaType {get;set;}

    }
}