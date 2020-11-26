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
        private string email;
        private string password;
        private string userProfile;

        public int IdUser { get => idUser; set => idUser = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        internal string UserProfile { get => userProfile; set => userProfile = value; }
    }
}
