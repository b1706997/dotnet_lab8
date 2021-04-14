using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CanBo
    {
        public Dictionary<string, string> info;
        public MonDangDay[] mon_day;
            
        public CanBo(string maCB)
        {
            // populate basic data
            Database db = new Database();
            db.query("Select * from canbo where ma_cb = '" + maCB + "'");
            this.info = new Dictionary<string, string>(db.result.FirstOrDefault());
            // get mon dang day list
            db.query("Select * from monhoccualop where ma_cb = '"+maCB+"'");
            if(db.count!=0)
            {
                this.mon_day = new MonDangDay[db.count];
                for(int i=0;i<mon_day.Length;i++)
                {
                    this.mon_day[i] = new MonDangDay(maCB, db.result[i]["MA_MON"], db.result[i]["MA_LOP"]);
                }
            }
        }
        public static object login(string maCB,string psw)
        {
            Database db = new Database();
            db.query("Select * from CanBo where ma_cb = '"+maCB+ "' and mk_cb = '" + psw + "'");
            if (db.count == 0)
                // If none result found => uname or psw not match
                return false;
            else
                return new CanBo(maCB);
        }

    }

   
}
