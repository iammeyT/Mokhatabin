using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokhatabin
{
    public partial class addform : Form
    {
        public addform()
        {
            InitializeComponent();
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                errorProvider1.SetError(submitbtn, "نام و نام خانوادگی را پر کنید");
            }
            else
            {
                errorProvider1.Clear();
                mokhatabinTable1TableAdapter1.InsertQuery(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox7.Text,textBox5.Text,textBox6.Text);
                MessageBox.Show("مخاطب ذخیره شد");
                Close();
                mokhatabinTable1TableAdapter1.Connection.Close();
            }
        }
        private void editsub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                errorProvider1.SetError(editsub, "نام و نام خانوادگی را پر کنید");
            }
            else
            {
                mokhatabinTable1TableAdapter1.UpdateQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox7.Text, textBox5.Text, textBox6.Text, int.Parse(textBox8.Text.ToString()));
                MessageBox.Show("مخاطب ویرایش شد");
                Close();
                mokhatabinTable1TableAdapter1.Connection.Close();
            }
        }
    }
}
