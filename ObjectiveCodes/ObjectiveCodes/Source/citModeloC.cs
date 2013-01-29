using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadWriteCsv;

namespace ObjectiveCodes.Source
{
    public class citModeloC
    {

        public citModeloC(CsvRow row)
        {
            this.KYCRSP_FUNDNO = Convert.ToInt32(row[0]);
            this.MCALDT = FuncoesAux.StringToDateTime(row[1]);
            //this.FMRET = row[2];
            //this.RmRfd = row[3];
            //this.SMB = row[4];
            //this.HML = row[5];
            //this.Mom = row[6];
            //this.Rfd = row[7];
            //this._b_RmRfd = row[8];
            //this._b_SMB = row[9];
            //this._b_HML = row[10];
            //this._b_Mom = row[11];
            //this._b_cons = row[12];
            //this._p = row[13];

        }

        public int KYCRSP_FUNDNO { get; set; }
        public DateTime MCALDT { get; set; }
        //public string FMRET { get; set; }
        //public string RmRfd { get; set; }
        //public string SMB { get; set; }
        //public string HML { get; set; }
        //public string Mom { get; set; }
        //public string Rfd { get; set; }
        //public string _b_RmRfd { get; set; }
        //public string _b_SMB { get; set; }
        //public string _b_HML { get; set; }
        //public string _b_Mom { get; set; }
        //public string _b_cons { get; set; }
        //public string _p { get; set; }

    }
}
