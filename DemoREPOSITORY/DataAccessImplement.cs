using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoREPOSITORY
{
    public class DataAccessImplement: IDataAccess
    {
       //XpayModel xpayModel = new XpayModel();
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        readonly SqlConnection conn = new SqlConnection(connectionString);
        
        public void Create(XpayModel xpayModel)
        {
            SqlCommand cm = new SqlCommand("InsertData", conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@name", xpayModel.Name);
            cm.Parameters.AddWithValue("@description", xpayModel.Description);
            cm.Parameters.AddWithValue("@amount", xpayModel.amount);
            cm.Parameters.AddWithValue("@termAndCondition", xpayModel.TermAndCondition);
            conn.Open();
            cm.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(XpayModel xpayModel)
        {
            XpayModel XpayModel = new XpayModel();
            XpayModel.id = xpayModel.id;
            conn.Open();
            SqlCommand cm = new SqlCommand("DeleteData", conn);
            cm.Parameters.AddWithValue("@id", XpayModel.id);
            cm.CommandType = CommandType.StoredProcedure;
            cm.ExecuteNonQuery();
            conn.Close();
        }

        public List<XpayModel> Read()
        {
            List<XpayModel> modelList = new List<XpayModel>();
            SqlCommand cm = new SqlCommand("DisplayData", conn);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                modelList.Add
                (
                    new XpayModel
                    {
                        id = Convert.ToInt32(dr["id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Description = Convert.ToString(dr["Description"]),
                        amount = Convert.ToDecimal(dr["amount"]),
                        TermAndCondition = Convert.ToString(dr["TermAndCondition"])
                    }
                );
            }

            conn.Close();
            return modelList;
        }

        public void Update(XpayModel xpayModel)
        {
           
            conn.Open();
            SqlCommand cm = new SqlCommand("UpdateData", conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@id", xpayModel.id);
            cm.Parameters.AddWithValue("@name", xpayModel.Name);
            cm.Parameters.AddWithValue("@description", xpayModel.Description);
            cm.Parameters.AddWithValue("@amount", xpayModel.amount);
            cm.Parameters.AddWithValue("@termAndCondition", xpayModel.TermAndCondition);
            
            cm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
