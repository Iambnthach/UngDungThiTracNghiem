using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace UngDungThiTracNghiem
{
    internal class SqlServerFactory
    {
        public SqlConnection con { get; }
        public SqlServerFactory()
        {
            con = new SqlConnection(getStringConnection());
        }
        public string getStringConnection()
        {
            return "Data Source=IAMBNTHACH\\MSSQLSERVER01;Initial Catalog=UDTTN;Integrated Security=True";
        }
        public SqlCommand GetCommand(string query, Dictionary<string, object> paramList)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            foreach(var index in paramList)
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = index.Key;
                param.Value = index.Value;
                cmd.Parameters.Add(param);
            }
            return cmd;
        }
    }
}
