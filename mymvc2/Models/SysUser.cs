using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mymvc2.Models
{
    public class SysUser
    {
        public int ID { get; set; }
        
      
        //[StringLength(10, MinimumLength = 1, ErrorMessage = "名字在1和10个字之间")]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //public DateTime CreateDate { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString ="{0:yyyy-mm-dd}",ApplyFormatInEditMode =true)]
        public int Ages { get; set; }
        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
        //public int? SysDepartmentID { get; set; }
        //public virtual SysDepartment SysDepartment { get; set; }
    }
}