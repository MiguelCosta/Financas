using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadWriteCsv;

namespace ObjectiveCodes.Source
{
    public class citExpenseTurnoverFee
    {

        public citExpenseTurnoverFee(CsvRow row)
        {
            this.KycrspFundno = Convert.ToInt32(row[0]);
            this.FexpRatio = Convert.ToDouble(row[1]);
            if (!row[2].Equals("")){
                this.FmgmtFee = Convert.ToDouble(row[2]);
            }
            this.FturnRatio = Convert.ToDouble(row[3]);
            this.Ffebegdt = FuncoesAux.StringToDateTime(row[4]);
            this.Ffeenddt = FuncoesAux.StringToDateTime(row[5]);
        }

        public int KycrspFundno { get; set; }
        public double FexpRatio { get; set; }
        public double FmgmtFee { get; set; }
        public double FturnRatio { get; set; }
        public DateTime Ffebegdt { get; set; }
        public DateTime Ffeenddt { get; set; }

    }
}
