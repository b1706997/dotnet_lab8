using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Classes
{
    public class MonDangDay
    {
        public Lop lop;
        public Dictionary<string,string> info;
        public MonDangDay(string macb,string mamon,string malop)
        {
            Database db = new Database();
            db.query("select monhoccualop.MA_CB,monhoccualop.MA_MON,monhoccualop.MA_LOP,monhoc.TEN_MON from MONHOCCUALOP inner join MONHOC on MONHOCCUALOP.MA_MON = MONHOC.MA_MON where MA_CB = '" + macb+ "' and MONHOCCUALOP.MA_MON = '" + mamon + "' and MA_LOP='" + malop + "'");
            if(db.count!=0)
            {
                this.info = new Dictionary<string, string>(db.result.First());
                this.lop = new Lop(malop);
            }
        }
    }
}