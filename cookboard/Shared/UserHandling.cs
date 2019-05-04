using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cookboard.Models;

namespace cookboard.Shared
{
    public class UserHandling
    {
        private readonly UserContext _context;
        public UserHandling(UserContext context)
        {
            _context = context;
        }

        public bool validateUser(Utilizador user)
        {
            user.password = MyHelper.HashPassword(user.password);
            var returnedUser = _context.user.Where(b => b.username == user.username && b.password == user.password).FirstOrDefault();

            if (returnedUser == null)
            {
                return false;
            }
            return true;
        }

        public bool registerUser(Utilizador user)
        {
            user.password = MyHelper.HashPassword(user.password);
            _context.user.Add(user);
            _context.SaveChanges();
            return true;
        }




    }
}
