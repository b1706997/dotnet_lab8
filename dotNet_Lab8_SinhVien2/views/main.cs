using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class main : Form
    {
        private string ma_cb;
        private string ma_mon;
        private string ma_lop;

        public main(Classes.CanBo canbo)
        {
            InitializeComponent();

            Console.WriteLine(canbo.info);
            // label
            this.show_name.Text = canbo.info["TEN_CB"];
            this.show_id.Text = canbo.info["MA_CB"];
            this.ma_cb = canbo.info["MA_CB"];
            this.show_mk.Text = canbo.info["MK_CB"];

            // datagridview columns
            this.dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Mã lớp";
            dataGridView1.Columns[1].Name = "Tên lớp";
            dataGridView1.Columns[2].Name = "Mã môn";
            dataGridView1.Columns[3].Name = "Môn";
            dataGridView1.Columns[4].Name = "Số lượng sinh viên";

            for(int i=0;i<canbo.mon_day.Length; i++)
            {
                dataGridView1.Rows.Add(new string[] {canbo.mon_day[i].lop.info["MA_LOP"] , canbo.mon_day[i].lop.info["TEN_LOP"],canbo.mon_day[i].info["MA_MON"] , canbo.mon_day[i].info["TEN_MON"],Convert.ToString(canbo.mon_day[i].lop.ds_sv.Length) });
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void contexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

            //Form
            Views.ds_lop ds_sv_form = new Views.ds_lop(new Classes.MonDangDay(this.ma_cb,this.ma_mon,this.ma_lop));
            ds_sv_form.Show();
        }
        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                this.ma_lop = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.ma_mon = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                contextMenuStrip1.Show(Cursor.Position);
            }
            //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Blue;
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
