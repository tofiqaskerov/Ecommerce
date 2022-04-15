using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Area { get; set; }
        public int RoomNumber { get; set; }
        public bool Kupca { get; set; }
        public string Description { get; set; }
        public int Hit { get; set; }
        public string Category { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
