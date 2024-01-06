using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TranDaiHiep255.Models;
[Table("SinhVien")]
public class SinhVien
{
    [Key]
    [Display(Name =" Mã Sinh Viên ")]
    public int MaSinhVien { get; set; }
    [Display(Name =" Họ và Tên Sinh Viên ")]
    public string HoTenSV { get; set; }
    [Display(Name =" Mã Công Dân ")]
    public string PersonID { get; set; }
    [ForeignKey("PersonID")]
    public Person? Person{get;set;}
}