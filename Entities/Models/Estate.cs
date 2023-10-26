using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Estate
    {
        public int EstateId { get; set; }
        public String? EstateName { get; set; } = String.Empty;
        //public IdentityUser User { get; set; }
        //public int UserId { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
        public int RoomNumber { get; set; }
        public String Summary { get; set; } = String.Empty;
        public String? ImageUrl { get; set; }
        public int? CategoryId { get; set; } //Foreign Key
        public Category? Category { get; set; } //Navigation Property
        public bool Showcase { get; set; }
    }
}
