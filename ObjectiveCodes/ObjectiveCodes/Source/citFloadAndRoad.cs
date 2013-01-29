using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectiveCodes.Source
{
    public class citFloadAndRoad
    {

        public citFloadAndRoad(citTotalLoadsFload fload, citTotalLoadsRload rload, citExpenseTurnoverFee expense)
        {
              if (fload != null)
            {
                this.KycrspFundno = fload.KycrspFundno;
                if (fload.FrontLoad != 0) this.FrontLoad = fload.FrontLoad.ToString(); else this.FrontLoad = "";
                this.Fflbegdt = fload.Fflbegdt;
                this.Fflenddt = fload.Fflenddt;
            }
            if (rload != null)
            {
                this.KycrspFundno = rload.KycrspFundno;
                if (rload.RearLoad != 0) this.RearLoad = rload.RearLoad.ToString(); else this.RearLoad = "";
                this.Frlbegdt = rload.Frlbegdt;
                this.Frlenddt = rload.Frlenddt;
            }
            if (expense != null)
            {
                this.KycrspFundno = expense.KycrspFundno;
                if (expense.FexpRatio != 0) this.FexpRatio = expense.FexpRatio.ToString(); else this.FexpRatio = "";
                if (expense.FmgmtFee != 0) this.FmgmtFee = expense.FmgmtFee.ToString(); else this.FmgmtFee = "";
                if (expense.FturnRatio != 0) this.FturnRatio = expense.FturnRatio.ToString(); else this.FturnRatio = "";
                this.Ffebegdt = expense.Ffebegdt;
                this.Ffeenddt = expense.Ffeenddt;
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

            return l;
        }

        public override bool Equals(Object obj)
        {
            // if parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            citFloadAndRoad o = obj as citFloadAndRoad;

            if ((object)o == null)
            {
                return false;
            }

            if(this.KycrspFundno == o.KycrspFundno &&
                ((this.FrontLoad != null && o.FrontLoad != null && this.FrontLoad.Equals(o.FrontLoad)) ||
                (this.FrontLoad == null && o.FrontLoad == null)) &&
                ((this.Fflbegdt != null && o.Fflbegdt != null && this.Fflbegdt.Equals(o.Fflbegdt)) ||
                (this.Fflbegdt == null && o.Fflbegdt == null)) &&
                ((this.Fflenddt != null && o.Fflenddt != null && this.Fflenddt.Equals(o.Fflenddt)) ||
                (this.Fflenddt == null && o.Fflenddt == null)) &&
                ((this.RearLoad != null && o.RearLoad != null && this.RearLoad.Equals(o.RearLoad)) ||
                (this.RearLoad == null && o.RearLoad == null)) &&
                ((this.Frlbegdt != null && o.Frlbegdt != null && this.Frlbegdt.Equals(o.Frlbegdt)) ||
                (this.Frlbegdt == null && o.Frlbegdt == null)) &&
                ((this.Frlenddt != null && o.Frlenddt != null && this.Frlenddt.Equals(o.Frlenddt)) ||
                (this.Frlenddt == null && o.Frlenddt == null)) &&
                ((this.FexpRatio != null && o.FexpRatio != null && this.FexpRatio.Equals(o.FexpRatio)) ||
                (this.FexpRatio == null && o.FexpRatio == null)) &&
                ((this.FmgmtFee != null && o.FmgmtFee != null && this.FmgmtFee.Equals(o.FmgmtFee)) ||
                (this.FmgmtFee == null && o.FmgmtFee == null)) &&
                ((this.FturnRatio != null && o.FturnRatio != null && this.FturnRatio.Equals(o.FturnRatio)) ||
                (this.FturnRatio == null && o.FturnRatio == null)) &&
                ((this.Ffebegdt != null && o.Ffebegdt != null && this.Ffebegdt.Equals(o.Ffebegdt)) ||
                (this.Ffebegdt == null && o.Ffebegdt == null)) &&
                ((this.Ffeenddt != null && o.Ffeenddt != null && this.Ffeenddt.Equals(o.Ffeenddt)) ||
                (this.Ffeenddt == null && o.Ffeenddt == null))
                ) {

                return true;
            } else {
                return false;
            }

            //return (this.kycrspfundno == o.kycrspfundno && this.frontload.equals(o.frontload)
            //    && this.fflbegdt.equals(o.fflbegdt) && this.fflenddt.equals(o.fflenddt)
            //    && this.rearload.equals(o.rearload) && this.frlbegdt.equals(o.frlbegdt)
            //    && this.frlenddt.equals(o.frlenddt) && this.fexpratio.equals(o.fexpratio)
            //    && this.fmgmtfee.equals(o.frlenddt) && this.fturnratio.equals(o.fturnratio)
            //    && this.ffebegdt.equals(o.ffebegdt) && this.ffeenddt.equals(o.ffeenddt));
        }

    }
}
