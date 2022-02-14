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
    public partial class CustomButtonProvider : UserControl
    {
        private CombinePresentTaskForm combinePresentTaskForm = null;
        public CustomButtonProvider()
        {
            InitializeComponent();
        }

        public void setPresetTask(CombinePresentTaskForm combinePresentTaskForm)
        {
            this.combinePresentTaskForm = combinePresentTaskForm;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            this.combinePresentTaskForm.insert();
        }
    }
}
