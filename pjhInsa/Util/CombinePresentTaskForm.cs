using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjhInsa.Util
{
    public interface IUc
    {
        void insert();
        string TaskName { get; }
        UserControl uc { get; set; }
    }
    public partial class CombinePresentTaskForm : Form
    {
        private IUc uc = null;
        public string TaskName { get; }

        public CombinePresentTaskForm(UserControl unitCodeTask)
        {
            InitializeComponent();
            this.TaskName = unitCodeTask.Name;
            unitCodeTask.Dock = DockStyle.Fill;
            this.viewer.Controls.Add(unitCodeTask);
            this.customButtonProvider1.setPresetTask(this);
        }

        public void insert()
        {
            uc.insert();
        }
    }
}
