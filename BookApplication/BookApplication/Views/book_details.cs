using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplication.Views
{
    public partial class book_details : Form
    {
        public string name, id, edition, author;
        public book_details()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            this.Hide();

        }


        private void book_details_Load(object sender, EventArgs e)
        {
            NametextBox1.Text = name;
            IdtextBox2.Text = id;
            AuthortextBox3.Text = author;
            EditiontextBox4.Text = edition;
        }
    }
}
