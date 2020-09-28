
using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Configer.Customize
{
    enum DBTYPE
    {
        MSSQL, MSACCESS, MYSQL, ORACLE, EXCEL, CSV
    }
    struct connectDbType
    {
        public String ConnectionString { get; set; }
        public DBTYPE CondbType { get; set; }
    }
    class configer
    {

        public connectDbType ConfigSvr87 { get; set; }
     
        public configer()
        {
            this.ConfigSvr87 = new connectDbType { ConnectionString = "Data Source = 192.168.1.87\\; Initial Catalog = Traceability-TEST; Persist Security Info = True; User ID = sa; Password = SysteM2551", CondbType = DBTYPE.MSSQL };
        }

    }
}
