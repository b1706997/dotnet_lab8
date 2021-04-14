using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CanBo = Classes.CanBo;
namespace Views
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Object cb = CanBo.login(txt_uname.Text, txt_psw.Text);
            if (cb is CanBo)
            {
                this.Hide();
                Form mainPage = new main((CanBo) cb);
                mainPage.Show();
            }
            else
            {
                Console.WriteLine("No ");
            };
            //Console.Write(CanBo.login(Convert.ToInt32(txt_uname.Text),txt_psw.Text));
            /*Database.OpenConnect();
            //Database.query('query', Array, Array);
            string query = "select count(*) as result from canbo where ma_cb = @a and mk_cb = @b";
            SqlCommand command = new SqlCommand(query, Database.con);
            SqlParameter p1 = new SqlParameter("@a", SqlDbType.Int);
            SqlParameter p2 = new SqlParameter("@b", SqlDbType.NVarChar);
            command.Parameters.Add(p1);
            command.Parameters.Add(p2);
            int result=Convert.ToInt32(command.ExecuteScalar());*/

        }
    }
}
