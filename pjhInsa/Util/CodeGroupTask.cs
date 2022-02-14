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
    public partial class CodeGroupTask : UserControl,IUc
    {
        public CodeGroupTask()
        {
            InitializeComponent();

            List<CodeGroupVo> codeGroups = new List<CodeGroupVo>() {
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
                new CodeGroupVo(){Code="1234",Name="1234",Sequence="1234",Number="1234"},
            };
            dataGridView1.DataSource = codeGroups;
            dataGridView1.Columns["Code"].HeaderText = "코드값";
            dataGridView1.Columns["Name"].HeaderText = "이름";
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Sequence"].HeaderText = "코드 순열";
            dataGridView1.Columns["Number"].HeaderText = "코드 자리수";

        }

        public void insert()
        {
            MessageBox.Show("reflection Test");
        }
    }

    public class CodeGroupVo
    {
        private string code;
        private string name;
        private string sequence;
        private string number;

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Sequence { get => sequence; set => sequence = value; }
        public string Number { get => number; set => number = value; }
    }
}
