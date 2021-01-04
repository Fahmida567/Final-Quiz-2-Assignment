using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookApplication.Models;
using BookApplication.Controllers;

namespace BookApplication.Views
{
    public partial class allbooks : Form
    {
        public string STextBox;
        bookController obj = new bookController();
        public allbooks()
        {
            InitializeComponent();
        }
        private void allbooks_Load(object sender, EventArgs e)
        {
           
            obj.Show();
            dataGridView1.DataSource = obj.dtTable;
            obj.Close();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            obj.performOperation();
            MessageBox.Show("Count: "+obj.change);
        }
        private void button_Click(object sender, EventArgs e)
        {
            books obj2 = new books();
            STextBox = SearchTextBox1.Text;
            obj2.textbox = STextBox;
            obj2.searchOpen();
            dataGridView1.DataSource = obj2.dtTable;
            obj2.earchClose();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            book_details ob = new book_details();
            DataGridViewRow row=this.dataGridView1.Rows[e.RowIndex];
            ob.name = row.Cells["Name"].Value.ToString();
            ob.id=row.Cells["ID"].Value.ToString();
            ob.author= row.Cells["Author"].Value.ToString();
            ob.edition= row.Cells["Edition"].Value.ToString();          
            ob.Show();
        }

       
    }
}
