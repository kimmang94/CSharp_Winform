﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConn = null;
        private string connStr = "SERVER=127.0.0.1,9008;DATABASE=MYDB1;UID=sa;PASSWORD=1234";
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DB 연결
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
            MessageBox.Show("데이터 베이스 연결 성공");
        }

        /// <summary>
        /// DB 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            // 데이터 베이스와 연결 끊기
            // null 이아니라면 연결중
            if (sqlConn != null)
            {
                sqlConn.Close();
                MessageBox.Show("데이터 베이스 연결해제 성공");
            }
        }
    }
}
