using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjhinsaDllTest
{
    public partial class UserControl1: pjhInsa.Util.IUc
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string TaskName => "pjhinsaDllTest";

        public UserControl uc {
            get => uc;
            set => uc = value;
        }
        
        public void insert()
        {
            throw new NotImplementedException();
        }


    }
}
