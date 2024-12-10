using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // MDI : Multi Document interface
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 알림창 띄우기
            MessageBox.Show("버튼2를 클릭하였습니다");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 선택 알림창 띄우기
            DialogResult drslt = MessageBox.Show("로그인 하시겠습니까?", "로그인", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            // 사용자가 확인을 누른경우
            if (drslt == DialogResult.OK)
            {
                MessageBox.Show(textBox1.Text);

                // ID 체크
                if (textBox1.Text.Equals("asdf"))
                {
                    MessageBox.Show("로그인 되었습니다");
                }
                else
                {
                    MessageBox.Show("로그인에 실패하였습니다");
                }
            }
        }
    }
}
