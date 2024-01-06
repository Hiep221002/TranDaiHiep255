using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TranDaiHiep255.Models;
[Table("Person")]
public class Person
{
    [Key]
    [Display (Name = "Mã Công dân")]
    public string PersonID { get; set; }
    [Display (Name = "Mã căn cước công dân")]
    public int cccd { get; set;}
    [Display (Name = "Họ và Tên công dân")]

    public string HoTen { get; set; }
}