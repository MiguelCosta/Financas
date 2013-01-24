using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadWriteCsv;

namespace ObjectiveCodes.Source
{
    public class citTotalLoadsFload
    {

        public citTotalLoadsFload(CsvRow row)
        {
            this.KycrspFundno = Convert.ToInt32(row[0]);
            this.FrontLoad = Convert.ToDouble(row[1]);
            this.FrontGroupNo = row[2];
            this.Fflbegdt = FuncoesAux.StringToDateTime(row[3]);
            this.Fflenddt = FuncoesAux.StringToDateTime(row[4]);
        }

        public int KycrspFundno { get; set; }
        public double FrontLoad { get; set; }
        public string FrontGroupNo { get; set; }
        public DateTime Fflbegdt { get; set; }
        public DateTime Fflenddt { get; set; }

    }

}
