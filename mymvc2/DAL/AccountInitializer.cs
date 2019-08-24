using mymvc2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mymvc2.DAL
{
    public class AccountInitializer : DropCreateDatabaseIfModelChanges<AccountContext>
    {

        protected override void Seed(AccountContext context)
        {
            var sysUsers = new List<SysUser>
              {
                  new SysUser{ UserName="1234", Email="tom@a.com",Password="1"},
                  new SysUser{ UserName="5678", Email="jerry@a.com",Password="2"}
              };
            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();
            var sysRoles = new List<SysRole>
             {
                 new SysRole{RoleName="admin", RoleDesc="sdfghjkl" },
                 new SysRole{ RoleName="admin1",RoleDesc="zxcvb"}
             };
            sysRoles.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();

        }
    }
}