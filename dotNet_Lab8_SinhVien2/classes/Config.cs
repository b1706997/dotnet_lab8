using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    static class Config
    {
        private static Dictionary<string, string> configs = new Dictionary<string, string>() {
            {"server", "NHATSON-PC\\SQLEXPRESS"},
            {"db", "SinhVien"},
            {"uid", "mylogin"},
            {"psw", "mylogin"}
        };
        public static string get(string key)
        {
            return configs[key];
        }
    }
}
