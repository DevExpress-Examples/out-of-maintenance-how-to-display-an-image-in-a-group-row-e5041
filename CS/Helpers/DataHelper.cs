using System;
using System.Collections.Generic;
using System.Linq;

namespace dxExample {
    public class DataHelper {
        public static void InitData(System.Data.DataTable dataTable) {
            var flag = false;
            for (var i = 0; i < 4; i++) {
                dataTable.Rows.Add(i, string.Format("Subject {0}", i), flag ? 0 : 1);
                flag = !flag;
            }
        }
    }
}
