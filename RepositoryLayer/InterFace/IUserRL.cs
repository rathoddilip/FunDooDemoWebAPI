using CommonLayer.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.InterFace
{
   public interface IUserRL
    {
            UserModel Create(UserModel user, string password);
            UserModel Authenticate(string username, string password);
            IEnumerable<UserModel> GetAll();
            UserModel GetById(int id);
            void Update(UserModel user, string password = null);
            void Delete(int id);
        
    }
}
