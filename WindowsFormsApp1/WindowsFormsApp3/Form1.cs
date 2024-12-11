using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("끝내기 클릭");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 버튼 클릭시 이미지 생성
            pictureBox1.Image = Properties.Resources.image202305031306004;

            // 라디오 버튼 클릭 확인
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("라디오 버튼1 체크");
                checkBox1.Checked = true;
                checkBox1.Enabled = false;
            }
        }
    }
}
