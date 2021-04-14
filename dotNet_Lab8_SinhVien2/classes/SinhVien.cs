using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class SinhVien
    {
        public Dictionary<string, string> info;
        
        public SinhVien(string masv)
        {
            Database db = new Database();
            db.query("Select * from sinhvien where ma_sv = '" + masv + "'");
            if(db.count==1)
            {
                this.info = new Dictionary<string, string>(db.result.First());
            }
        }
        public int getDiem(string ma_mon)
        {
            Database db = new Database();
            db.query("select * from diem where MA_MON='" + ma_mon + "' and MA_SV='" + this.info["MA_SV"] + "'");
            if (db.count != 0)
                return Convert.ToInt32(db.result.First()["DIEM"]);
            else
                return -1;
        }
        public static void updateDiem(string ma_mon,int diem,int ma_sv)
        {

            Database db = new Database();
            // check if avail
            db.query("select * from diem where MA_MON='"+ma_mon+ "' and MA_SV='" + ma_sv + "'");
            if (db.count != 0)
                db.query("Update diem set DIEM='" + diem + "' where MA_MON='" + ma_mon + "' and MA_SV='" + ma_sv + "'");
            else
                db.query("Insert into Diem(MA_SV,MA_MON,DIEM) values ('"+ma_sv+ "','" + ma_mon + "','" + diem + "')");
        }
    }
}