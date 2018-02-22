using RepaireEntity;
using Repairemanagerment.DAL;
using System.Data.Linq;

namespace Repairemanagerment.BLL
{
    public class repaireUserManager
    {
       private RepaireUserService repaireUserService = new RepaireUserService();
       /// <summary>
       /// 根据用户名和密码验证帐户合法性
       /// </summary>
       /// <param name="name"></param>
       /// <param name="pass"></param>
       /// <returns></returns>
       public bool IsLogin(string name, string pass)
       {
           userinfo user = repaireUserService.GetUserByName(name);
           if (user == null)
               return false;
           else if (pass == user.UserPASS)
               return true;
           else
               return false;
       }
       /// <summary>
       /// 根据ID查询用户 
       /// </summary>
       /// <param name="loginName"></param>
       /// <returns></returns>
       public userinfo GetUserById(int id)
       {
           return repaireUserService.GetUserById(id);
       }
       /// <summary>
       /// 查询全部操作员信息
       /// </summary>
       /// <returns></returns>
       public Table<userinfo> GetAll()
       {
           return repaireUserService.GetAll();
       }
              /// <summary>
       /// 添加用户
       /// </summary>
       /// <param name="user"></param>
       public bool AddUser(userinfo user)
       {
           if (repaireUserService.GetUserByName(user.UserNAME) != null)
               return false;
           else
           {
               repaireUserService.AddUser(user);
               return true;
           }
       }
              /// <summary>
       /// 修改用户
       /// </summary>
       /// <param name="user"></param>
       public void UpdateUser(userinfo user)
       {
               repaireUserService.UpdateUser(user);
       }
              /// <summary>
       /// 删除用户
       /// </summary>
       /// <param name="user"></param>
       public void DelUser(int id)
       {
           repaireUserService.DelUser(id);
       }
    }
}
