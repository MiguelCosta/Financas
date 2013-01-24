using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadWriteCsv;

namespace ObjectiveCodes.Source
{
    public class citTotalLoadsRload
    {

        public citTotalLoadsRload(CsvRow row)
        {
            this.KycrspFundno = Convert.ToInt32(row[0]);
            this.RearLoad = Convert.ToDouble(row[1]);
            this.RearGroupNo = row[2];
            this.Frlbegdt = FuncoesAux.StringToDateTime(row[3]);
            this.Frlenddt = FuncoesAux.StringToDateTime(row[4]);
        }

        public int KycrspFundno { get; set; }
        public double RearLoad { get; set; }
        public string RearGroupNo { get; set; }
        public DateTime Frlbegdt { get; set; }
        public DateTime Frlenddt { get; set; }

    }
}
