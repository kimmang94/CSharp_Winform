using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 초기화 기능
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 화면이 보여지기전 실행할 기능 구현
            lbl1.Text = "글자입니다1.";
            lbl2.Text = "글자입니다2.";
        }
        
        // 버튼 1이 클릭되었을때 동작 실행
        private void button1_Click(object sender, EventArgs e)
        {
            lbl3.Text = "글자입니다3.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 알림 메시지를 띄울때 사용하는 함수
            MessageBox.Show("알림 메시지");
        }
    }
}
