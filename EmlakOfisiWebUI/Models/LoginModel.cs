using System.ComponentModel.DataAnnotations;

namespace EmlakOfisiWebUI.Models
{
    public class LoginModel
    {
        private string? _returnUrl;

        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Şifre zorunludur.")]
        public string? Password { get; set; }

        public string ReturnUrl
        {
            get
            {
                if (_returnUrl is null)
                {
                    return "/";
                }
                else
                {
                    return _returnUrl;
                }
            }
            set
            {
                _returnUrl = value;
            }
        }
    }
}
