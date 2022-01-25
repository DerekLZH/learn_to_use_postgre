using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Mono.Security;

namespace learn_to_use_postgre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string result= learn_to_use_postgre.usePostgre.TestGetData();
            textBox1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            learn_to_use_postgre.usePostgre.TestInsertData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            learn_to_use_postgre.usePostgre.TestDeleteData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            learn_to_use_postgre.usePostgre.TestUpdateData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            learn_to_use_postgre.usePostgre.TestConnection();
        }

        
    }
}
