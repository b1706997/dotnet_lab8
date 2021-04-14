using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MonDangDay = Classes.MonDangDay;
namespace Views
{
    public partial class ds_lop : Form
    {
        private MonDangDay mondangday;
        public ds_lop(MonDangDay mondangday)
        {
            InitializeComponent();
            this.mondangday = mondangday;
            this.dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].Name = "MSSV";
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].Name = "Họ tên";
            dataGridView1.Columns[2].ReadOnly = true;

            dataGridView1.Columns[3].Name = "Điểm";
            // invivible column
            dataGridView1.Columns[4].Name = "ma_sv";
            dataGridView1.Columns[4].Visible = false;

            for (int i = 0; i < mondangday.lop.ds_sv.Length; i++)
            {
                string STT = Convert.ToString(i);
                string MSSV = this.mondangday.lop.ds_sv[i].info["MSSV"];
                string HO_TEN = mondangday.lop.ds_sv[i].info["TEN_SV"];
                string DIEM = Convert.ToString(mondangday.lop.ds_sv[i].getDiem(mondangday.info["MA_MON"]));
                string MA_SV = mondangday.lop.ds_sv[i].info["MA_SV"];
                //dataGridView1.Rows.Add(new string[] { Convert.ToString(i), mondangday.lop.ds_sv[i].info["MSSV"], mondangday.lop.ds_sv[i].info["TEN_SV"], Convert.ToString(mondangday.lop.ds_sv[i].getDiem(mondangday.info["MA_MON"])), mondangday.lop.ds_sv[i].info["MA_MON"] } );
                dataGridView1.Rows.Add(new string[] { STT, MSSV, HO_TEN, DIEM, MA_SV });
            }
            


        }
        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Classes.SinhVien.updateDiem(this.mondangday.info["MA_MON"],Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value), Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value));
        }


    }
}
