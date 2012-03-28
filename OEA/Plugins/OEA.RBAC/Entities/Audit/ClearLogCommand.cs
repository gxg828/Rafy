﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OEA.Utils;

namespace OEA.Library.Audit
{
    [Serializable]
    public class ClearLogCommand : SimpleCsla.ServiceBase
    {
        protected override void DataPortal_Execute()
        {
            using (var db = DBHelper.CreateDb(ConnectionStringNames.OEA))
            {
                var sql = "DELETE FROM AUDITITEM";
                db.Exec("sys.sp_sqlexec", new object[] { sql });
            }
        }
    }
}