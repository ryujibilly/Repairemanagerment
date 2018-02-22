using RepaireEntity;
using System;
using System.Data.Linq;
using System.Linq;

namespace Repairemanagerment.DAL
{
    public class RepaireUserService
    {
        private RepaireDBDataContext RepaireDataContext = new RepaireDBDataContext();

        /// <summary>
        /// 根据登陆名查询用户信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public userinfo GetUserByName(string name)
        {
            try
            {
                return (from user in RepaireDataContext.userinfo
                        where user.UserNAME == name
                        select user).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 根据ID查询用户信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public userinfo GetUserById(int id)
        {
            try
            {
                return (from user in RepaireDataContext.userinfo 
                        where user.UserID == id
                        select user).Single();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        /// <summary>
        /// 查询全部操作员信息
        /// </summary>
        /// <returns></returns>
        public Table<userinfo> GetAll()
        {
            try
            {
                return RepaireDataContext.userinfo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(userinfo user)
        {
            try
            {
                RepaireDataContext.userinfo.InsertOnSubmit(user);
                RepaireDataContext.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        public void UpdateUser(userinfo newUser)
        {
            try
            {
                userinfo oldUser = (from u in RepaireDataContext.userinfo
                                     where u.UserID == newUser.UserID
                                     select u).Single();
                oldUser.UserNAME = newUser.UserNAME;
                RepaireDataContext.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user"></param>
        public void DelUser(int id)
        {
            try
            {
                RepaireDataContext.userinfo.DeleteOnSubmit((from u in RepaireDataContext.userinfo
                                                           where u.UserID == id
                                                           select u).Single());
                RepaireDataContext.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
