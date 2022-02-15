using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pjhInsa
{
    public class DlllProvider
    {
        private string Url(string fileName) => $"{Environment.CurrentDirectory}/{fileName}.dll";

        public object GetDllUserControls(string fileName)
        {
           Assembly assembly = Assembly.LoadFile(Url(fileName));
           return assembly.CreateInstance("pjhinsaDllTest.UserControl1");
        }
    }
}
