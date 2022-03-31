using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CSharpProject.Models
{
    public class Order
    {
        [Key]
        public int OrderId {get;set;}

        public int UserId {get;set;}

        public User OrderedBy {get;set;}

        public double TotalCost {get;set;}
        public List<Product> Products {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}