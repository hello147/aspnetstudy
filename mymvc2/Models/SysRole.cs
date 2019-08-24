using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mymvc2.Models
{
    public class SysRole
    {
        public int ID { get; set; }
        public int SysUserID { get; set; }
        public string RoleName { get; set; }

        public string RoleDesc { get; set; }
        public ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}