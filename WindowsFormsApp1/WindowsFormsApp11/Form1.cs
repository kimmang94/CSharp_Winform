using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConn = null;
        #region [DB 접속 정보]
        private string connStr = "SERVER=" + ConfigurationManager.AppSettings["IP"] +
            "," + ConfigurationManager.AppSettings["PORT"] + ";" +
            "DATABASE=" + ConfigurationManager.AppSettings["DBNAME"] + ";" +
            "UID=" + ConfigurationManager.AppSettings["USERID"] + ";" +
            "PASSWORD=" + ConfigurationManager.AppSettings["USERPASSWORD"];
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// DB 연결 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn = new SqlConnection(connStr);
                sqlConn.Open();
                MessageBox.Show("데이터 베이스 연결 성공");
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 내용" + ex.ToString());
            }
        }
        /// <summary>
        /// DB 해제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConn != null)
                {
                    sqlConn.Close();
                    MessageBox.Show("데이터 베이스 연결해제 성공");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 내용" + ex.ToString());
            }
        }
        /// <summary>
        /// 전체 조회 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                //conn.Open() 코드를 안적어도 필요할 경우 연결 후 연결을 끊는다
                //SqlDataAdapter 클래스를 이용하여 데이터 가져오기
                string sql = "SELECT * FROM BOOKS(NOLOCK)";
                SqlDataAdapter adpt = new SqlDataAdapter(sql, conn);
                adpt.Fill(ds, "BOOKS");

                //SqlDataReader 클래스를 이용하여 데이터 가져오기
                //SqlCommand sqlCommand = new SqlCommand();
                //sqlCommand.CommandText = "SELECT * FROM BOOKS";
                //sqlCommand.Connection = conn;

                //DataTable dataTable = new DataTable();
                //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //dataTable.Load(sqlDataReader);
                //dataGridView1.DataSource = dataTable;
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Book NO, Name 할당
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["BOOKNO"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["BOOKNO"].Value.ToString();
        }

        /// <summary>
        /// 삭제 기능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string bookNo = textBox1.Text;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandText = "DELETE FROM BOOKS WHERE BOOKNO = " + "'" + bookNo + "'";
                sqlCommand.ExecuteNonQuery();
   
            }
        }

        /// <summary>
        /// 책 이름 변경 기능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn5_Click(object sender, EventArgs e)
        {
            string bookNo = textBox4.Text;
            string bookName = textBox3.Text;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandText = "UPDATE BOOKS SET NAME = " + "'" + bookName + "'" + "WHERE BOOKNO = " + bookNo;
                sqlCommand.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 책 추가 기능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string bookNo = textBox6.Text;
                string bookName = textBox5.Text;
                string bookCode = textBox7.Text;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "INSERT INTO BOOKS(BOOKNO,NAME,CODE) VALUES ( " + bookNo + ", '" + bookName + "','" + bookCode + "')"; 
                sqlCommand.Connection = conn;
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
