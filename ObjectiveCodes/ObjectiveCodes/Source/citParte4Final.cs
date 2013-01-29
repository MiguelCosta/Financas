using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectiveCodes.Source
{
    public class citParte4Final
    {

        public citParte4Final(citModeloC modeloC, citTotalLoadsFload fload, citTotalLoadsRload rload, citExpenseTurnoverFee expense) {
            this.KycrspFundno = modeloC.KYCRSP_FUNDNO;
            this.MCALDT = modeloC.MCALDT;

            if(fload != null) {
                this.FrontLoad = fload.FrontLoad.ToString();
                this.Fflbegdt = fload.Fflbegdt;
                this.Fflenddt = fload.Fflenddt;
            }

            if(rload != null) {
                this.RearLoad = rload.RearLoad.ToString();
                this.Frlbegdt = rload.Frlbegdt;
                this.Frlenddt = rload.Frlenddt;
            }

            if(expense != null) {
                this.FexpRatio = expense.FexpRatio.ToString();
                this.FmgmtFee = expense.FmgmtFee.ToString();
                this.FturnRatio = expense.FturnRatio.ToString();
                this.Ffebegdt = expense.Ffebegdt;
                this.Ffeenddt = expense.Ffeenddt;
            }
        }

        public citParte4Final(citModeloC modeloC, citFloadAndRoad result)
        {
            this.KycrspFundno = modeloC.KYCRSP_FUNDNO;

            this.MCALDT = modeloC.MCALDT;
            //this.FMRET = modeloC.FMRET;
            //this.RmRfd = modeloC.RmRfd;
            //this.SMB = modeloC.SMB;
            //this.HML = modeloC.HML;
            //this.Mom = modeloC.Mom;
            //this.Rfd = modeloC.Rfd;
            //this._b_RmRfd = modeloC._b_RmRfd;
            //this._b_SMB = modeloC._b_SMB;
            //this._b_HML = modeloC._b_HML;
            //this._b_Mom = modeloC._b_Mom;
            //this._b_cons = modeloC._b_cons;
            //this._p = modeloC._p;

            if (result != null)
            {
                this.FrontLoad = result.FrontLoad;
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

        public double TotalLoads {
            get {
                double f = 0;
                double r = 0;
                if(this.FrontLoad != null && this.FrontLoad.Length > 0) { f = Convert.ToDouble(this.FrontLoad); }
                if(this.RearLoad != null && this.RearLoad.Length > 0) { r = Convert.ToDouble(this.RearLoad); }
                return f + r;
            }
        }


        public ReadWriteCsv.CsvRow ToCsv()
        {
            ReadWriteCsv.CsvRow l = new ReadWriteCsv.CsvRow();
            l.Add(this.KycrspFundno.ToString());

            l.Add(this.FrontLoad == null ? "" : this.FrontLoad);
            if (this.Fflbegdt == null || this.Fflbegdt.Year < 1900) l.Add(""); else l.Add(this.Fflbegdt.ToString("dd/MM/yyyy"));
            if (this.Fflenddt == null || this.Fflenddt.Year < 1900) l.Add(""); else l.Add(this.Fflenddt.ToString("dd/MM/yyyy"));

            l.Add(this.RearLoad == null ? "" : this.RearLoad);
            if (this.Frlbegdt == null || this.Frlbegdt.Year < 1900) l.Add(""); else l.Add(this.Frlbegdt.ToString("dd/MM/yyyy"));
            if (this.Frlenddt == null || this.Frlenddt.Year < 1900) l.Add(""); else l.Add(this.Frlenddt.ToString("dd/MM/yyyy"));

            l.Add(this.FexpRatio == null ? "" : this.FexpRatio);
            l.Add(this.FmgmtFee == null ? "" : this.FmgmtFee);
            l.Add(this.FturnRatio == null ? "" : this.FturnRatio);
            if (this.Ffebegdt == null || this.Ffebegdt.Year < 1900) l.Add(""); else l.Add(this.Ffebegdt.ToString("dd/MM/yyyy"));
            if (this.Ffeenddt == null || this.Ffeenddt.Year < 1900) l.Add(""); else l.Add(this.Ffeenddt.ToString("dd/MM/yyyy"));

            if (this.MCALDT == null || this.MCALDT.Year < 1900) l.Add(""); else l.Add(this.MCALDT.ToString("dd/MM/yyyy"));
            //l.Add(this.FMRET == null ? "" : this.FMRET);
            //l.Add(this.RmRfd == null ? "" : this.RmRfd);
            //l.Add(this.SMB == null ? "" : this.SMB);
            //l.Add(this.HML == null ? "" : this.HML);
            //l.Add(this.Mom == null ? "" : this.Mom);
            //l.Add(this.Rfd == null ? "" : this.Rfd);
            //l.Add(this._b_RmRfd == null ? "" : this._b_RmRfd);
            //l.Add(this._b_SMB == null ? "" : this._b_SMB);
            //l.Add(this._b_HML == null ? "" : this._b_HML);
            //l.Add(this._b_Mom == null ? "" : this._b_Mom);
            //l.Add(this._b_cons == null ? "" : this._b_cons);
            //l.Add(this._p == null ? "" : this._p);

            l.Add(this.TotalLoads.ToString());

            return l;
        }

    }
}
