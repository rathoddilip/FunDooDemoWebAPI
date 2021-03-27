using BusinessLayer.InterFace;
using CommonLayer.ResponseModel;
using RepositoryLayer.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class UserBL : IUserBL
    {
        IUserRL userRL;
        /// <summary>
        /// paramerised Constructor 
        /// </summary>
        /// <param name="userRL"></param>
        public UserBL(IUserRL userRL)
        {
            this.userRL = userRL;
        }

        public bool DeleteUserRegistration(int EmpId)
        {
            throw new NotImplementedException();
        }

        public string RegisterUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> ReturnUserRecords()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserRegistration(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
