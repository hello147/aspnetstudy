using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mymvc2.DAL;
using mymvc2.Models;

namespace mymvc2.Repositories
{
    public class SysUserRepository : IsysUserRepository
    {
        protected AccountContext db = new AccountContext();
        //添加用户
        public void Add(SysUser sysUser)
        {
            db.SysUsers.Add(sysUser);
            db.SaveChanges();
        }
        //删除用户
        public bool Delete(int id)
        {
            var delSysUser = db.SysUsers.FirstOrDefault(u => u.ID == id);
            if (delSysUser != null)
            {
                db.SysUsers.Remove(delSysUser);
                db.SaveChanges();
                return true;
            }
            else {
                return false;
            }
        }
        //查询所有用户
        public IQueryable<SysUser> SelectAll()
        {
            return db.SysUsers;
        }

        public SysUser SelectByName(string userName)
        {
            return db.SysUsers.FirstOrDefault(u => u.UserName == userName);
        }
    
       
    }
}