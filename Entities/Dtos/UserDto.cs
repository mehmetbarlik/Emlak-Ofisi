using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record UserDto
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        public int UserId { get; set; }
        public String? UserName { get; init; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Mail Adresi zorunludur.")]
        public String? Email { get; init; }
        [DataType(DataType.PhoneNumber)]
        public String? PhoneNumber { get; init; }
        public HashSet<String> Roles { get; set; } = new HashSet<string>();
    }
}
