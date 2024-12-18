using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        // 버튼 가져오기
       // private string Label1Text;

        // Getter Setter 제공
        //public string LabelText1 { get => Label1Text; set => Label1Text = value; }

        //public string GetLabel1Text1()
        //{
        //    return Label1Text;
        //}

        //public void SetLabel1Text1(string value)
        //{
        //    Label1Text = value;
        //}

        public string Label1Text 
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }
    }
}
