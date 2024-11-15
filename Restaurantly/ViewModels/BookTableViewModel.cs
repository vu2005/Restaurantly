using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Restaurantly.ViewModels
{
    public class BookTableViewModel
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Tên là bắt buộc.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc.")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Ngày đặt là bắt buộc.")]
        public DateTime ReservationDate { get; set; }

        [Required(ErrorMessage = "Thời gian đặt là bắt buộc.")]
        public TimeSpan ReservationTime { get; set; }

        [Required(ErrorMessage = "Số lượng khách là bắt buộc.")]
        [Range(1, 100, ErrorMessage = "Số lượng khách phải từ 1 đến 100.")]
        public int NumberOfGuests { get; set; }

        public string Message { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn bàn.")]
        public int TableId { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn món ăn.")]
        public int ProductId { get; set; }

    }
}
