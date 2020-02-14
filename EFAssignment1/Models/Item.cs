using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace EFAssignment1.Models
{
    [Table("Items")]
  public  class Item
    {
        [Key]
        [StringLength(5)]
        public int ItemID { get; set; }
        [Required]
        [StringLength(20)]
        public string ItemName { get; set; }

        public int? ItemPrice { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
