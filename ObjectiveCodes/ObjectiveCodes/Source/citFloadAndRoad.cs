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

        //public override bool Equals(System.Object obj)
        //{
        //    // If parameter is null return false.
        //    if (obj == null)
        //    {
        //        return false;
        //    }

        //    citFloadAndRoad o = obj as citFloadAndRoad;

        //    if ((System.Object)o == null)
        //    {
        //        return false;
        //    }

        //    return (this.KycrspFundno == o.KycrspFundno && this.FrontLoad.Equals(o.FrontLoad)
        //        && this.Fflbegdt.Equals(o.Fflbegdt) && this.Fflenddt.Equals(o.Fflenddt)
        //        && this.RearLoad.Equals(o.RearLoad) && this.Frlbegdt.Equals(o.Frlbegdt)
        //        && this.Frlenddt.Equals(o.Frlenddt) && this.FexpRatio.Equals(o.FexpRatio)
        //        && this.FmgmtFee.Equals(o.Frlenddt) && this.FturnRatio.Equals(o.FturnRatio)
        //        && this.Ffebegdt.Equals(o.Ffebegdt) && this.Ffeenddt.Equals(o.Ffeenddt));
        //}

    }
}
