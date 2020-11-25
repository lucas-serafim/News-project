using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using News_project.Enums;

namespace News_project.BLL
{
    class UserBLL
    {
        private int idUser;
        private string name;
        private string password;
        private string email;
        private UserProfile userProfile;

        public int IdUser { get => idUser; set => idUser = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        internal UserProfile UserProfile { get => userProfile; set => userProfile = value; }
    }
}
