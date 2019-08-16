using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarEvents.Domain.Entities
{
    public class ItemPurchase
    {
        [Key]
        public string Id { get; set; }
        public string CarId { get; set; }
        [ForeignKey("Car")]
        public Car Car { get; set; }
        public DateTime DateOfBooking { get; set; }
    }
}
