using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record ResetPasswordDto
    {
        public String? UserName { get; init; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Parola zorunludur.")]
        public String? Password { get; init; }
        [DataType(DataType.Password)]

        [Required(ErrorMessage = "Parolayı tekrar girin.")]
        [Compare("Password", ErrorMessage = "Parolalar aynı olmak zorunda.")]
        public String? ConfirmPassword { get; init; }
    }
}
