using System.ComponentModel.DataAnnotations;

namespace Restaurantly.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email là bắt buộc.")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
