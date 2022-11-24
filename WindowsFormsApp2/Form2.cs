using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form2 : Form
    {
        string id = "jspark";
        string pw = "1234";
        int count = 0;

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox_id,"영문 및 숫자로 입력해주세요!");
            toolTip1.SetToolTip(textBox_pw, "영문 및 숫자로 입력해주세요!");
            this.ActiveControl = textBox_id;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            if (string.Equals(id, (textBox_id.Text), StringComparison.CurrentCulture) &&
                    string.Equals(pw,(textBox_pw.Text),StringComparison.CurrentCulture))
            {
                count++;
                Close();
            }
            else
            {   
                    MessageBox.Show("아이디 또는 비밀번호가 틀렸습니다.");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(count==0)
                Application.Exit();
        }

        private void TextBox_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Button1_Click(sender, e);
        }

        private void TextBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Button1_Click(sender, e);
        }
    }
}
