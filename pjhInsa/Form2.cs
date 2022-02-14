using pjhInsa.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjhInsa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            menuStrip1.BackColor = Color.FromArgb(243, 243, 243);
            menuStrip1.ForeColor = Color.FromArgb(123, 123, 123);

            sideMenu.BackColor = Color.FromArgb(44, 44, 44);
            sideMenu.ForeColor = Color.FromArgb(123, 123, 123);

            bottomPannel.BackColor = Color.FromArgb(0, 122, 204);
            bottomPannel.ForeColor = Color.FromArgb(235, 245, 251);

            pageViewr.BackColor = Color.FromArgb(255, 255, 255);

         

        }
    }
}
