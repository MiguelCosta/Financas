using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectiveCodes.Source
{
    public class citParte4Final
    {

        public citParte4Final(citModeloC modeloC, citFloadAndRoad result)
        {
            this.KycrspFundno = modeloC.KYCRSP_FUNDNO;

            this.MCALDT = modeloC.MCALDT;
            this.FMRET = modeloC.FMRET;
            this.RmRfd = modeloC.RmRfd;
            this.SMB = modeloC.SMB;
            this.HML = modeloC.HML;
            this.Mom = modeloC.Mom;
            this.Rfd = modeloC.Rfd;
            this._b_RmRfd = modeloC._b_RmRfd;
            this._b_SMB = modeloC._b_SMB;
            this._b_HML = modeloC._b_HML;
            this._b_Mom = modeloC._b_Mom;
            this._b_cons = modeloC._b_cons;
            this._p = modeloC._p;

            this.FrontLoad = result.FrontLoad ;
            this.Fflbegdt = result.Fflbegdt;
            this.Fflenddt = result.Fflenddt;

            this.RearLoad = result.RearLoad;
            this.Frlbegdt = result.Frlbegdt;
            this.Frlenddt = result.Frlenddt;

            this.FexpRatio = result.FexpRatio;
            this.FmgmtFee = result.FmgmtFee;
            this.FturnRatio = result.FturnRatio;
            this.Ffebegdt = result.Ffebegdt;
            this.Ffeenddt = result.Ffeenddt;

        }

        public int KycrspFundno { get; set; }

        public string FrontLoad { get; set; }
        public DateTime Fflbegdt { get; set; }
        public DateTime Fflenddt { get; set; }

        public string RearLoad { get; set; }
        public DateTime Frlbegdt { get; set; }
        public DateTime Frlenddt { get; set; }

        public string FexpRatio { get; set; }
        public string FmgmtFee { get; set; }
        public string FturnRatio { get; set; }
        public DateTime Ffebegdt { get; set; }
        public DateTime Ffeenddt { get; set; }

        public DateTime MCALDT { get; set; }
        public string FMRET { get; set; }
        public string RmRfd { get; set; }
        public string SMB { get; set; }
        public string HML { get; set; }
        public string Mom { get; set; }
        public string Rfd { get; set; }
        public string _b_RmRfd { get; set; }
        public string _b_SMB { get; set; }
        public string _b_HML { get; set; }
        public string _b_Mom { get; set; }
        public string _b_cons { get; set; }
        public string _p { get; set; }

        public ReadWriteCsv.CsvRow ToCsv()
        {
            ReadWriteCsv.CsvRow l = new ReadWriteCsv.CsvRow();
            l[0] = this.KycrspFundno.ToString();
            l[1] = this.Fflbegdt.ToString("dd/mm/yyyy");
            l[2] = this.Fflenddt.ToString("dd/mm/yyyy");

            return l;
        }

    }
}
