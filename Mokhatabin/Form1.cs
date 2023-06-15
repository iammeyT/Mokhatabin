using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokhatabin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.MokhatabinTable1' table. You can move, or remove it, as needed.
            this.mokhatabinTable1TableAdapter.Fill(this.dataSet1.MokhatabinTable1);
        }
        private void addtool_Click(object sender, EventArgs e)
        {
            addform add = new addform();
            add.editsub.Visible = false;
            add.textBox8.Visible = false;
            add.ShowDialog();
        }
        private void removetool_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DialogResult dr = MessageBox.Show("حذف شود؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    mokhatabinTable1TableAdapter.DeleteQuery(id);
                    mokhatabinTable1TableAdapter.Fill(dataSet1.MokhatabinTable1);
                    mokhatabinTable1TableAdapter.Connection.Close();
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("مخاطبی وجود ندارد");
            }
            finally
            {

            }
        }

        private void edittool_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                addform edit = new addform();
                edit.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                edit.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                edit.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                edit.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                edit.textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                edit.textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                edit.textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                edit.textBox8.Text = id.ToString();
                edit.submitbtn.Visible = false;
                edit.editsub.Visible = true;
                edit.textBox8.Visible = false;
                edit.Text = "ویرایش مخاطب";
                edit.Icon = new Icon("Resources/edit.ico");
                edit.ShowDialog();
            }
            catch
            {
                MessageBox.Show("مخاطبی وجود ندارد");
            }
            finally
            {

            }
        }

        private void showtool_Click(object sender, EventArgs e)
        {
            try
            {
                showform sf = new showform();
                sf.namelbl.Text = (dataGridView1.CurrentRow.Cells[1].Value.ToString());
                sf.lastnamelbl.Text = (dataGridView1.CurrentRow.Cells[2].Value.ToString());
                sf.mobilelbl.Text = (dataGridView1.CurrentRow.Cells[3].Value.ToString());
                sf.tellbl.Text = (dataGridView1.CurrentRow.Cells[4].Value.ToString());
                sf.emaillbl.Text = (dataGridView1.CurrentRow.Cells[5].Value.ToString());
                sf.addreslbl.Text = (dataGridView1.CurrentRow.Cells[6].Value.ToString());
                sf.notelbl.Text = (dataGridView1.CurrentRow.Cells[7].Value.ToString());
                sf.ShowDialog();
            }
            catch
            {
                MessageBox.Show("مخاطبی وجود ندارد");
            }
        }

        private void refreshtool_Click(object sender, EventArgs e)
        {
            
            this.mokhatabinTable1TableAdapter.Fill(dataSet1.MokhatabinTable1);
            mokhatabinTable1TableAdapter.Connection.Close();
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            this.mokhatabinTable1TableAdapter.Fill(dataSet1.MokhatabinTable1);
            mokhatabinTable1TableAdapter.Connection.Close();
        }

        private void abouttool_Click(object sender, EventArgs e)
        {
            About ab=new About();
            ab.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mokhatabinTable1TableAdapter.search(dataSet1.MokhatabinTable1,textBox1.Text,textBox1.Text,textBox1.Text,textBox1.Text,textBox1.Text);
            if (textBox1.Text == "")
            {
                mokhatabinTable1TableAdapter.Connection.Close();
            }
        }
    }
}
