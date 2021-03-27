using CommonLayer.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;
namespace BusinessLayer.InterFace
{
    public interface IUserBL
    {
        public List<UserModel> ReturnUserRecords();
        public string RegisterUser(UserModel user);
        public bool DeleteUserRegistration(int EmpId);
        public bool UpdateUserRegistration(UserModel user);
    }
}
