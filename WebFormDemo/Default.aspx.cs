using DemoREPOSITORY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormDemo
{
    public partial class Default : System.Web.UI.Page
    {
       // static string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
       // SqlConnection conn = new SqlConnection(connectionString);
        IDataAccess dataAccess = new DataAccessImplement();
    
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData_Click(sender, e);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GetData_Click(object sender, EventArgs e)
        {
            List<XpayModel> listModel = new List<XpayModel>();
            listModel = dataAccess.Read();
            GridView1.DataSource = listModel;
            GridView1.DataBind();
        }

        protected void TextBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxTC_TextChanged(object sender, EventArgs e)
        {

        }

        protected void InsertData_Click(object sender, EventArgs e)
        {

            XpayModel xpayModel = new XpayModel
            {
                Name = TextBoxName.Text,
                Description = TextBoxDescription.Text,
                amount = decimal.Parse(TextBoxAmount.Text),
                TermAndCondition = TextBoxTC.Text
            };
            dataAccess.Create(xpayModel);
            GetData_Click(sender, e);
        }

        protected void TextBoxUpdateId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxUpdateName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxUpdateDescription_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxUpdateAmount_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxUpdateTC_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UpdateData_Click(object sender, EventArgs e)
        {
            XpayModel xpayModel = new XpayModel
            {
                id = int.Parse(TextBoxUpdateId.Text),
                Name = TextBoxUpdateName.Text,
                Description = TextBoxUpdateDescription.Text,
                amount = decimal.Parse(TextBoxUpdateAmount.Text),
                TermAndCondition = TextBoxUpdateTC.Text
            };
            dataAccess.Update(xpayModel);
            GetData_Click(sender, e);
        }

        protected void TextBoxDeleteId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DeleteData_Click(object sender, EventArgs e)
        {
            XpayModel xpayModel = new XpayModel
            {
                id = int.Parse(TextBoxDeleteId.Text)
            };
            dataAccess.Delete(xpayModel);
            GetData_Click(sender, e);
        }
    }
}