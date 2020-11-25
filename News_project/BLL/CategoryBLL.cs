using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_project.BLL
{
    class CategoryBLL
    {
        private int idCategory;
        private string name;

        public int IdCategory { get => idCategory; set => idCategory = value; }
        public string Name { get => name; set => name = value; }
    }
}
