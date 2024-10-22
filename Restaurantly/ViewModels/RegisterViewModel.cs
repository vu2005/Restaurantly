using System.ComponentModel.DataAnnotations;

namespace Restaurantly.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Tên đầy đủ là bắt buộc.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Mật khẩu phải có ít nhất {2} ký tự.", MinimumLength = 6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu không khớp.")]
        [Required(ErrorMessage = "Xác nhận mật khẩu là bắt buộc.")]
        public string ConfirmPassword { get; set; }
    }
}
