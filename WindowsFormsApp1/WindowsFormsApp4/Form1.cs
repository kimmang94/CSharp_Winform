using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // 버튼을 눌렀을때 코드
            MessageBox.Show("버튼 클릭");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼이 로드될때 실행되는 함수
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            // 1개의 열 추가
            DataColumn dc = new DataColumn();
            dc.ColumnName = "숫자타입";
            dc.DataType = typeof(Int32);

            // 2번째 열
            DataColumn dc2 = new DataColumn();
            dc2.ColumnName = "이름";
            dc2.DataType = typeof(string);

            // 데이터 테이블과 연결
            dt.Columns.Add(dc);
            dt.Columns.Add(dc2);

            // 데이터 테이블 행 추가
            dt.Rows.Add(1,"홍길동");

            // DataSet
            DataSet ds = new DataSet("MyDataSet");
            //데이터셋 <- 데이터테이블을 저장
            ds.Tables.Add(dt);
            ds.Tables.Add(dt2);


            // 데이터 그리드뷰 표시
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
