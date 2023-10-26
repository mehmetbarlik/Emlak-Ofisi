using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record EstateDto
    {
        public int EstateId { get; init; }
        public string? EstateName { get; set; }
        public String? ProductName { get; init; } = String.Empty;
        public string? Address { get; set; }
        public int RoomNumber { get; set; }
        [Required(ErrorMessage = "Fiyat alanı zorunludur!")]
        public decimal Price { get; init; }
        public String Summary { get; init; } = String.Empty;
        public String? ImageUrl { get; set; }
        public int? CategoryId { get; init; }
        public bool Showcase { get; set; }
    }
}
