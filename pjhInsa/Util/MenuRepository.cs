using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjhInsa.Util
{
    public class Menus 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IUc userControl { get; set; }
        public UserControl uc { get; set; }

    }
    public interface IMenuRepository
    {
        void Insert(Menus menu);
        Menus FindById(string id);
    }
    public class MenuRepository : IMenuRepository
    {
        private List<Menus> menus = new List<Menus>();
        public Menus FindById(string id)
        {
            return menus.Find(menu => menu.Id == id);
        }

        public void Insert(Menus menu)
        {
            this.menus.Add(menu);
        }
    }
}
