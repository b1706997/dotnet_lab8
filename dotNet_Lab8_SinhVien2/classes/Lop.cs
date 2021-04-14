using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Lop
    {
        public Dictionary<string, string> info;
        public SinhVien[] ds_sv; 
        
        public Lop(string malop)
        {
            Database db = new Database();
            db.query("select * from LOP where MA_LOP='"+malop+"'");
            if(db.count!=0)
            {
                // populate basic data
                Dictionary<string, string> result = db.result.First();
                this.info = result;
                // populate sv
                db.query("select MA_SV from SINHVIEN where MA_LOP='"+malop+"'");
                if(db.count!=0)
                {
                    // init the ds_sv array of $db.count elements
                    this.ds_sv = new SinhVien[db.count];
                    // populate the ds_sv array
                    int i = 0;
                    db.result.ForEach(delegate (Dictionary<string, string> sv)
                    {
                        ds_sv[i] = new SinhVien(sv["MA_SV"]);
                        i++;
                    });

                }
            }
        }
    }
}
