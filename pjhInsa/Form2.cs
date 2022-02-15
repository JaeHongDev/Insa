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
using System.Reflection;

namespace pjhInsa
{
    public partial class Form2 : Form
    {
        private DlllProvider dlllProvider;
        private MenuRepository menuRepository;
        private string VisibleState = "M";
        public class CItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
        }
        public Form2()
        {
            this.InitializeComponent();

            this.dlllProvider = new DlllProvider();
            BindingList<CItem> typeList = new BindingList<CItem>();
            typeList.Add(new CItem { Text = "다중 화면 사용", Value = "M" });
            typeList.Add(new CItem { Text = "단일 화면 사용", Value = "S" });
            toolStripComboBox1.ComboBox.DataSource = typeList;
            toolStripComboBox1.ComboBox.DisplayMember = "Text";
            toolStripComboBox1.ComboBox.ValueMember = "Value";


            this.GroupCodeToolTip.Click += new System.EventHandler(this.ToolTip_Click);
            this.UnitCodeToolTip.Click += new System.EventHandler(this.ToolTip_Click);

            this.dllTestToolStripMenuItem.Click += new System.EventHandler(this.ToolTip_Click);


            this.setLayOutDesigner();
            this.menuRepository = new MenuRepository();

            this.menuRepository.Insert(new Menus() { Id = "GroupCode", Name = "CodeGroupTask", uc = new CodeGroupTask() });
            this.menuRepository.Insert(new Menus() { Id = "UnitCode", Name = "UnitCodeTask", uc = new UnitCodeTask() });
            this.menuRepository.Insert(new Menus() { Id = "DLLTest", Name = "pjhinsaDllTest", uc = new UnitCodeTask() });

        }

        private ToolStripMenuItem selectedToolStripMenuItem = null;

        private void MenuStripSyleChanged(object sender, EventArgs e)
        {
            if (selectedToolStripMenuItem is null)
            {
                selectedToolStripMenuItem = (ToolStripMenuItem)sender;
                selectedToolStripMenuItem.BackColor = Color.FromArgb(44, 44, 44);
                return;
            }
            selectedToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 255);

            selectedToolStripMenuItem = (ToolStripMenuItem)sender;
            selectedToolStripMenuItem.BackColor = Color.FromArgb(44, 44, 44);

        }

        private void setLayOutDesigner()
        {
            menuStrip1.BackColor = Color.FromArgb(243, 243, 243);
            menuStrip1.ForeColor = Color.FromArgb(123, 123, 123);

            sideMenu.BackColor = Color.FromArgb(44, 44, 44);
            sideMenu.ForeColor = Color.FromArgb(123, 123, 123);

            bottomPannel.BackColor = Color.FromArgb(0, 122, 204);
            bottomPannel.ForeColor = Color.FromArgb(235, 245, 251);

            pageViewr.BackColor = Color.FromArgb(255, 255, 255);
        }

        private List<CombinePresentTaskForm> storedCombinePresentTaskForms = new List<CombinePresentTaskForm>();

        private void ToolTip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolTip = (ToolStripMenuItem)sender;

            Menus task = this.menuRepository.FindById(toolTip.Tag.ToString());
            if (task is null)
            {
                MessageBox.Show("해당 메뉴가 존재하지 않습니다");
                return;
            }

            CombinePresentTaskForm findCombinePresentTaskForm =
                storedCombinePresentTaskForms.Find(form => form.TaskName == task.uc.Name);
            if (findCombinePresentTaskForm is null)
            {
                //Type t = Type.GetType($"pjhInsa.Util.{task.Name}");
                Console.WriteLine(task.uc.GetHashCode());
                CombinePresentTaskForm combinePresentTaskForm 
                    = new CombinePresentTaskForm((UserControl)this.dlllProvider.GetDllUserControls(task.Name));

                if (VisibleState.Equals("M"))
                {
                    combinePresentTaskForm.Show();
                }
                if (VisibleState.Equals("S"))
                {
                    combinePresentTaskForm.ShowDialog();
                }
                storedCombinePresentTaskForms.Add(combinePresentTaskForm);
                combinePresentTaskForm.FormClosed += new FormClosedEventHandler(FormClosed);
                void FormClosed(object sender1, FormClosedEventArgs e1) 
                {
                    storedCombinePresentTaskForms.Remove((CombinePresentTaskForm)sender1);
                }
                return;
            }
            findCombinePresentTaskForm.Focus();

        }



        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.VisibleState = ((CItem)toolStripComboBox1.ComboBox.SelectedItem).Value;
        }
    }
}
