using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = connection.getConnection();
        public Form1()
        {
            InitializeComponent();
        }

       
        //for datagridview
        public void calldatagridview()
        {
            string SQL = "select * from tb_crud ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        bool _insertProcess()
        {
            int retval = 0;
            try
            {
                string SQLS = string.Empty;
                SQLS += "INSERT tb_crud SET ";
                SQLS += "name='" + tbname.Text + "'";
                SQLS += ",blood_type='" + tbblood.Text + "'";
                if (tbman.Checked)
                {
                    SQLS += ",gender='" + "Man" + "'";
                }
                else if (tbwoman.Checked)
                {
                    SQLS += ",gender='" + "Woman" + "'";

                    
                }
                conn.Open();
                using (MySqlCommand com = new MySqlCommand(SQLS, conn))
                {
                    retval = com.ExecuteNonQuery();
                    dataGridView1.DataSource = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { conn.Close(); }
            calldatagridview();
            return retval > 0;
        }

        bool _UpdateProcess()
        {
            int retval = 0;
            try
            {
                string SQLS = string.Empty;
                SQLS += "Update tb_crud SET ";
                SQLS += "name='" + tbname.Text + "'";
                SQLS += ",blood_type='" + tbblood.Text + "'";
                if (tbman.Checked)
                {
                    SQLS += ",gender='" + "Man" + "'";
                }
                else if (tbwoman.Checked)
                {
                    SQLS += ",gender='" + "Woman" + "'";
                }
                SQLS += "WHERE id='" + tbid.Text + "'";

                conn.Open();
                using (MySqlCommand com = new MySqlCommand(SQLS, conn))
                {
                    retval = com.ExecuteNonQuery();
                    dataGridView1.DataSource = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { conn.Close(); }
            calldatagridview();
            return retval > 0;
        }

        bool _deleteprocess()
        {
            int retval = 0;
            try
            {

                //   string SQL = "insert into user (id, password, level_id, departement_id, gender, alamat, kodepos, notelp, fullname, hobby_id, is_active, username) values (@id, @password, @level_id, @departement_id, @gender, @alamat, @kodepos, @notelp, @fullname, @hobby_id, @is_active, @username)";
                string SQLS = string.Empty;
                SQLS += "DELETE FROM tb_crud ";
                SQLS += "WHERE id='" + tbid.Text + "'";

                conn.Open();
                using (MySqlCommand com = new MySqlCommand(SQLS, conn))
                {
                    retval = com.ExecuteNonQuery();
                    dataGridView1.DataSource = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { conn.Close(); }
            calldatagridview();
            return retval > 0;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            tbid.Enabled = false;
            //add value on combobox
            tbblood.Items.Add("A");
            tbblood.Items.Add("B");
            tbblood.Items.Add("AB");
            tbblood.Items.Add("O");
            btinsert.Enabled = false;

            calldatagridview();


        }

        private void btinsert_Click(object sender, EventArgs e)
        {
            _insertProcess();
            button1.Enabled = true;
            btinsert.Enabled = false;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            _UpdateProcess();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            _deleteprocess();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            tbid.Text = dr.Cells[0].Value.ToString();
            tbname.Text = dr.Cells[1].Value.ToString();
            if (dr.Cells[2].Value.ToString() == "Laki-Laki")
            {
                tbman.Checked = true;
            }
            else if (dr.Cells[2].Value.ToString() == "Perempuan")
            {
                tbwoman.Checked = true;
            }
            tbblood.Text = dr.Cells[3].Value.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbid.Text = "";
            tbname.Text = "";
            tbname.Focus();
            tbman.Checked = false;
            tbwoman.Checked = false;
            tbblood.Text = "";
            btinsert.Enabled = true;
            button1.Enabled = false;

            
        }
    }
}
