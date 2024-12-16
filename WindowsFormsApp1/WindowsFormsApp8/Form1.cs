using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 5;
            int b = 7;
            int c = 0;

            // 에러발생 함수 
            myFunction1();
            
            // 덧셈 함수
            c = myFunction2(a,b);

            MessageBox.Show("덧셈 결과 : {0}", c.ToString());
        }

        /// <summary>
        /// 오류를 던져주는 함수 
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void myFunction1()
        {
            // 오류 생성
            throw new Exception();
        }

        private int myFunction2(int num1, int num2)
        {
            // 디버그를 위한 코드 늘리기
            int num3 = 0;
            int num4 = 0;

            num3 = num1;
            num4 = num2;

            return num3 + num4;
        }
    }
}
