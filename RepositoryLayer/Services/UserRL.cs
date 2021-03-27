using CommonLayer.ResponseModel;
using RepositoryLayer.Context;
using RepositoryLayer.ExceptionHelper;
using RepositoryLayer.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Services
{
    public class UserRL:IUserRL
    {
        private UserContext _context;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public UserRL(UserContext context)
        {
            _context = context;
        }
        public UserModel Create(UserModel user, string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new AppException("Password is required");

            if (_context.Users.Any(x => x.UserName == user.UserName))
                throw new AppException("Username \"" + user.UserName + "\" is already taken");
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }
        public UserModel Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserModel user, string password = null)
        {
            throw new NotImplementedException();
        }
    }
}
