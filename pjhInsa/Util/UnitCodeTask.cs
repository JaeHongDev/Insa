using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjhInsa.Util
{
    public partial class UnitCodeTask : UserControl, IUc
    {
        public UnitCodeTask()
        {
            InitializeComponent();

        }

        public string TaskName => throw new NotImplementedException();

        UserControl uc {
            get => uc;  
            set => uc = value;
        }
        UserControl IUc.uc {
            get => uc;
            set => uc = value;
        }

        string IUc.TaskName => throw new NotImplementedException();

        public void insert()
        {
            MessageBox.Show($"reflection Test:{this.Name}");
        }

        void IUc.insert()
        {
            throw new NotImplementedException();
        }

    }
}
