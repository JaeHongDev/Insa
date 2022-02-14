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
    public interface IUc {
        void insert();
    }
    public partial class CombinePresentTaskForm : Form
    {
        private IUc uc = null;
        public CombinePresentTaskForm()
        {
            InitializeComponent();
            
            CodeGroupTask codeGroupTask = new CodeGroupTask();
            uc = codeGroupTask;



            codeGroupTask.Dock = DockStyle.Fill;
            this.viewer.Controls.Add(codeGroupTask);

            this.customButtonProvider1.setPresetTask(this);
        }

        public void insert()
        {
            uc.insert();
        }
    }
}
