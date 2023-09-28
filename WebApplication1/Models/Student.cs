using System.ComponentModel.DataAnnotations;

namespace BTH1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên

        [Required(ErrorMessage = "Tên là trường bắt buộc.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải có ít nhất 4 ký tự và tối đa 100 ký tự.")]
        public string? Name { get; set; } //Họ tên
        [Required(ErrorMessage = "Email là trường bắt buộc.")]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@gmail\.com$", ErrorMessage = "Địa chỉ email phải có đuôi gmail.com.")]
        public string? Email { get; set; } //Email
        [StringLength(100, MinimumLength = 8)]
        
        [Required(ErrorMessage = "Mật khẩu là trường bắt buộc.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$", ErrorMessage = "Mật khẩu phải từ 8 ký tự trở lên và phải chứa ít nhất một chữ thường, một chữ viết hoa, một số và một ký tự đặc biệt.")]
        public string? Password { get; set; }//Mật khẩu

        [Required]
        public Branch? Branch { get; set; }//Ngành học
        [Required]
        public Gender? Gender { get; set; }//Giới tính
        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy
        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }//Địa chỉ
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBorth { get; set; }//Ngày sinh

        [Required(ErrorMessage = "Điểm là trường bắt buộc.")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0.")]
        public float Score { get; set; }

    }
}
