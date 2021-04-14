using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Classes {
    class Database
    {
        //private static Database instance=null;
        private SqlConnection con;
        public List<Dictionary<string,string>> result = new List<Dictionary<string, string>>();
        public int count;
        private bool error = false;

        public Database()
        {
            try
            {
                con = new SqlConnection("server=" + Config.get("server") + "; database=" + Config.get("db") + ";uid=" + Config.get("uid") + ";pwd=" + Config.get("psw") + ";MultipleActiveResultSets=True");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void query(string query)
        {
            if (this.con.State != ConnectionState.Open)
                this.con.Open();
            this.count = 0;
            this.result = new List<Dictionary<string, string>>();
            SqlCommand cmd = new SqlCommand(query,this.con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while(reader.Read())
                {
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    // loop over columns
                    for(int j=0;j<reader.FieldCount;j++)
                    {
                        dic.Add(reader.GetName(j), Convert.ToString(reader.GetValue(j)));
                        //this.result.Add(reader.GetName(j), Convert.ToString(reader.GetValue(j)));
                        //this.result.Add(new Dictionary<string, string> { { reader.GetName(j), Convert.ToString(reader.GetValue(j)) } });
                    }
                    i++;
                    this.result.Add(dic);
                }
                reader.Close();
                this.con.Close();
                this.count = i; 
            }
      
            
        }
        /*public static Database getInstance()
        {
           if(instance == null)
            {
                instance = new Database();
            }

            return instance;
        }*/
        public bool closeConnect()
        {
            try
            {
                this.con.Close();
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
        /*public static bool CloseConnect()
        {
            try
            {
                this.con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }*/
        /*public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public static string makeString(string[] arr)
        {
            string onConvert = "";
            string converted = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 == arr.Length)
                {
                    onConvert = onConvert + "'" + arr[i] + "'";
                }
                else
                {
                    onConvert = onConvert + "'" + arr[i] + "'" + ",";
                }
            }
            converted = "(" + onConvert + ")";
            return converted;
        }
        public static String InsertData(String tableName, String value)
        {
            String insertString = "";
            insertString = "insert into " + tableName + " values " + value;
            strValue = insertString;
            return insertString;
        }*/
    }
}

