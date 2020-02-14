using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace EFAssignment1.Models
{
    [Table("Orders")]
    public class Order
    {

        [Key]
        [StringLength(10)]
        public int OrderID { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? Orderdate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? Deliverydate { get; set; }
        public int ItemID { get; set; }
        [ForeignKey("ItemID")]
        public Item Item { get; set; }

    }
}
