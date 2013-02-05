using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectiveCodes.Source
{
    public class citDeterminantes
    {

        public citDeterminantes(citDeterminantes deter) {
            this.KYCRSP_FUNDNO = deter.KYCRSP_FUNDNO;

            this.MCALDT = deter.MCALDT;
            this.FMRET = deter.FMRET;
            this.FMTNA = deter.FMRET;
            this.RmRf = deter.RmRf;
            this.RmRfd = deter.RmRfd;
            this.SMB = deter.SMB;
            this.HML = deter.HML;
            this.Mom = deter.Mom;
            this.RF = deter.RF;
            this.Rfd = deter.Rfd;
            this.FLOW = deter.FLOW;

            this.FRONT_LOAD = deter.FRONT_LOAD;
            this.Fflbegdt = deter.Fflbegdt;
            this.Fflenddt = deter.Fflenddt;

            this.REAR_LOAD = deter.REAR_LOAD;
            this.Frlbegdt =deter.Frlbegdt;
            this.Frlenddt =deter.Frlenddt;

            this.FEXP_RATIO = deter.FEXP_RATIO;
            this.FMGMT_FEE = deter.FMGMT_FEE;
            this.FTURN_RATIO = deter.FTURN_RATIO;
            this.Ffebegdt = deter.Ffebegdt;
            this.Ffeenddt = deter.Ffeenddt;

            this.TotalLoads = deter.TotalLoads;
            this.r_rf = deter.r_rf;

        }

        public citDeterminantes(ReadWriteCsv.CsvRow row) {
            this.KYCRSP_FUNDNO = int.Parse(row[0]);

            this.MCALDT = FuncoesAux.StringToDateTime(row[1]);
            this.FMRET = row[2];
            this.FMTNA = row[3];
            this.RmRf = row[4];
            this.RmRfd = row[5];
            this.SMB = row[6];
            this.HML = row[7];
            this.Mom = row[8];
            this.RF = row[9];
            this.Rfd = row[10];
            this.FLOW = row[11];

            this.FRONT_LOAD = row[12];
            if(!String.IsNullOrEmpty(row[13])) this.Fflbegdt = FuncoesAux.StringToDateTime(row[13]);
            if(!String.IsNullOrEmpty(row[14])) this.Fflenddt = FuncoesAux.StringToDateTime(row[14]);

            this.REAR_LOAD = row[15];
            if(!String.IsNullOrEmpty(row[16])) this.Frlbegdt = FuncoesAux.StringToDateTime(row[16]);
            if(!String.IsNullOrEmpty(row[17])) this.Frlenddt = FuncoesAux.StringToDateTime(row[17]);

            this.FEXP_RATIO = row[18];
            this.FMGMT_FEE = row[19];
            this.FTURN_RATIO = row[20];
            if(!String.IsNullOrEmpty(row[21])) this.Ffebegdt = FuncoesAux.StringToDateTime(row[21]);
            if(!String.IsNullOrEmpty(row[22])) this.Ffeenddt = FuncoesAux.StringToDateTime(row[22]);

            if(!String.IsNullOrEmpty(row[23])) this.TotalLoads = double.Parse(row[23]);
            if(!String.IsNullOrEmpty(row[24])) this.r_rf = double.Parse(row[24]);
        }

        public int KYCRSP_FUNDNO { get; set; }

        public DateTime MCALDT { get; set; }
        public string FMRET { get; set; }
        public string FMTNA { get; set; }
        public string RmRf { get; set; }
        public string RmRfd { get; set; }
        public string SMB { get; set; }
        public string HML { get; set; }
        public string Mom { get; set; }
        public string RF { get; set; }
        public string Rfd{get;set;}
        public string FLOW{get;set;}

        public string FRONT_LOAD{get;set;}
        public DateTime Fflbegdt{get;set;}
        public DateTime Fflenddt{get;set;}

        public string REAR_LOAD{get;set;}
        public DateTime Frlbegdt{get;set;}
        public DateTime Frlenddt {get;set;}

        public string FEXP_RATIO {get;set;}
        public string FMGMT_FEE {get;set;}
        public string FTURN_RATIO {get;set;}
        public DateTime Ffebegdt {get;set;}
        public DateTime Ffeenddt{get;set;}

        public double TotalLoads{get;set;}
        public double r_rf{get;set;}

        public ReadWriteCsv.CsvRow ToCsv() {
            ReadWriteCsv.CsvRow l = new ReadWriteCsv.CsvRow();

            l.Add(this.KYCRSP_FUNDNO.ToString());

            if(this.MCALDT == null || this.MCALDT.Year < 1900) l.Add(""); else l.Add(this.MCALDT.ToString("dd/MM/yyyy"));
            l.Add(this.FMRET);
            l.Add(this.FMTNA);
            l.Add(this.RmRf);
            l.Add(this.RmRfd);
            l.Add(this.SMB);
            l.Add(this.HML);
            l.Add(this.Mom);
            l.Add(this.RF);
            l.Add(this.Rfd);
            l.Add(this.FLOW);

            l.Add(this.FRONT_LOAD);
            if(this.Fflbegdt == null || this.Fflbegdt.Year < 1900) l.Add(""); else l.Add(this.Fflbegdt.ToString("dd/MM/yyyy"));
            if(this.Fflenddt == null || this.Fflenddt.Year < 1900) l.Add(""); else l.Add(this.Fflenddt.ToString("dd/MM/yyyy"));

            l.Add(this.REAR_LOAD);
            if(this.Frlbegdt == null || this.Frlbegdt.Year < 1900) l.Add(""); else l.Add(this.Frlbegdt.ToString("dd/MM/yyyy"));
            if(this.Frlenddt == null || this.Frlenddt.Year < 1900) l.Add(""); else l.Add(this.Frlenddt.ToString("dd/MM/yyyy"));

            l.Add(this.FEXP_RATIO);
            l.Add(this.FMGMT_FEE);
            l.Add(this.FTURN_RATIO);
            if(this.Ffebegdt == null || this.Ffebegdt.Year < 1900) l.Add(""); else l.Add(this.Ffebegdt.ToString("dd/MM/yyyy"));
            if(this.Ffeenddt == null || this.Ffeenddt.Year < 1900) l.Add(""); else l.Add(this.Ffeenddt.ToString("dd/MM/yyyy"));
            
            l.Add(this.TotalLoads.ToString());
            l.Add(this.r_rf.ToString());

            return l;
        }

    }
}
