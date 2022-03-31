using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CSharpProject.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId {get;set;}

        public int UserId {get;set;}
        public User CartOwner {get;set;}

        public int ProductId {get;set;}
        
        public Product CartItem {get;set;}

        public int TotalCost {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}