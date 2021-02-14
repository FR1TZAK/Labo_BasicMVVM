using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{ID} {ItemName} {Status}";
        }
    }
}
