using DemoREPOSITORY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{

    public partial class Form1 : Form
    {
        IDataAccess dataAccess = new DataAccessImplement();
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        readonly SqlConnection conn = new SqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            XpayModel xpayModel = new XpayModel();
            xpayModel.Name = textBox2.Text;
            xpayModel.Description = textBox1.Text;
            xpayModel.amount = decimal.Parse(textBox4.Text);
            xpayModel.TermAndCondition = textBox5.Text;
            dataAccess.Create(xpayModel);
            MessageBox.Show("Saved...");
            textBox1.Clear();
            textBox2.Clear();
           
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XpayModel xpayModel = new XpayModel();
            xpayModel.id =int.Parse( textBox3.Text);
            xpayModel.Name = textBox2.Text;
            xpayModel.Description = textBox1.Text;
            xpayModel.amount = decimal.Parse(textBox4.Text);
            xpayModel.TermAndCondition = textBox5.Text;
            dataAccess.Update(xpayModel);
            MessageBox.Show("Updated...");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XpayModel xpayModel = new XpayModel();
            xpayModel.id = int.Parse(textBox3.Text);
            dataAccess.Delete(xpayModel);
            MessageBox.Show("Deleted...");
            textBox3.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         

        // list = dataAccess.Read();
        List<XpayModel> modelList = new List<XpayModel>();
            //SqlCommand cm = new SqlCommand("DisplayData", conn);
            //cm.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter da = new SqlDataAdapter(cm);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            string sql = "SELECT * FROM tbl_adhoc_product_master";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Authors_table";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
