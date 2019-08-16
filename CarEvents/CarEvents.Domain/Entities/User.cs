using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarEvents.Domain.Entities
{
    public class User
    {
        [Key]
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }

        public ICollection<ItemPurchase> ItemPurchase { get; set; }
    }
}
