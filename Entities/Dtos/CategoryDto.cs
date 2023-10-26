using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record CategoryDto
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        public String? CategoryName { get; set; } = String.Empty;
    }
}
