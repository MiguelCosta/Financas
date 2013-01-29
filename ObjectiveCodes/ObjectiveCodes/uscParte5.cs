using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadWriteCsv;

namespace ObjectiveCodes {
    public partial class uscParte5 :UserControl {
        private string _fileTotalLoadsFload = "";
        private List<Source.citTotalLoadsFload> _SourceTotalLoadsFload = new List<Source.citTotalLoadsFload>();

        private string _fileTotalLoadsRload = "";
        private List<Source.citTotalLoadsRload> _SourceTotalLoadsRload = new List<Source.citTotalLoadsRload>();

        private string _fileExpenseTurnoverFee = "";
        private List<Source.citExpenseTurnoverFee> _SourceExpensiveTurnoverFee = new List<Source.citExpenseTurnoverFee>();

        private string _fileModeloC = "";
        private List<Source.citModeloC> _SourceModeloC = new List<Source.citModeloC>();

        private List<Source.citParte4Final> _result = new List<Source.citParte4Final>();

        public uscParte5() {
            InitializeComponent();
        }

        #region "Total Loads Fload"

        private void btnAbrirTotalLoadsFload_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                if(ret == DialogResult.OK) {
                    _fileTotalLoadsFload = filename;

                    if(!_fileTotalLoadsFload.Equals("")) {
                        _SourceTotalLoadsFload.Clear();
                        ReadTotalLoadsFload();
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadTotalLoadsFload() {
            // Read sample data from CSV file
            using(CsvFileReader reader = new CsvFileReader(_fileTotalLoadsFload)) {
                Application.DoEvents();
                CsvRow row = new CsvRow();
                if(reader.ReadRow(row)) {
                    //foreach (String s in row)
                    //{
                    //    dgvDados.Columns.Add(s, s);
                    //}
                }

                while(reader.ReadRow(row) /*&& i < limitValues*/) {
                    _SourceTotalLoadsFload.Add(new Source.citTotalLoadsFload(row));
                }

                var query = _SourceTotalLoadsFload.GroupBy(x => x.KycrspFundno, (k, g) => g.Aggregate((a, x) => (x.FrontLoad > a.FrontLoad) ? x : a));
                _SourceTotalLoadsFload = query.ToList();

                dgvTotalLoadsFload.DataSource = _SourceTotalLoadsFload;

            }
        }

        #endregion

        #region "Total loads Rload"

        private void btnAbrirTotalLoadsRload_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                if(ret == DialogResult.OK) {
                    _fileTotalLoadsRload = filename;

                    if(!_fileTotalLoadsRload.Equals("")) {
                        _SourceTotalLoadsRload.Clear();
                        ReadTotalLoadsRload();
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadTotalLoadsRload() {
            // Read sample data from CSV file
            using(CsvFileReader reader = new CsvFileReader(_fileTotalLoadsRload)) {
                Application.DoEvents();
                CsvRow row = new CsvRow();
                if(reader.ReadRow(row)) {
                    //foreach (String s in row)
                    //{
                    //    dgvDados.Columns.Add(s, s);
                    //}
                }

                while(reader.ReadRow(row) /*&& i < limitValues*/) {
                    _SourceTotalLoadsRload.Add(new Source.citTotalLoadsRload(row));
                }

                var query = _SourceTotalLoadsRload.GroupBy(x => x.KycrspFundno, (k, g) => g.Aggregate((a, x) => (x.RearLoad > a.RearLoad) ? x : a));
                _SourceTotalLoadsRload = query.ToList();

                dgvTotalLoadsRload.DataSource = _SourceTotalLoadsRload;
            }
        }

        #endregion

        #region "Expense Turnover Fee"

        private void btnAbrirExpenseTurnoverFee_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                Cursor = Cursors.WaitCursor;

                if(ret == DialogResult.OK) {
                    _fileExpenseTurnoverFee = filename;

                    if(!_fileExpenseTurnoverFee.Equals("")) {
                        _SourceExpensiveTurnoverFee.Clear();
                        ReadExpensiveTurnoverFee();
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally { Cursor = Cursors.Default; }

        }

        private void ReadExpensiveTurnoverFee() {
            // Read sample data from CSV file
            using(CsvFileReader reader = new CsvFileReader(_fileExpenseTurnoverFee)) {
                Application.DoEvents();
                CsvRow row = new CsvRow();
                if(reader.ReadRow(row)) {
                    //foreach (String s in row)
                    //{
                    //    dgvDados.Columns.Add(s, s);
                    //}
                }

                while(reader.ReadRow(row) /*&& i < limitValues*/) {
                    _SourceExpensiveTurnoverFee.Add(new Source.citExpenseTurnoverFee(row));
                    Console.WriteLine(row[0]);
                }

                dgvExpenseTurnoverFee.DataSource = _SourceExpensiveTurnoverFee;
            }
        }

        #endregion

        #region "Modelo C"

        private void btnAbrirModeloC_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                if(ret == DialogResult.OK) {
                    _fileModeloC = filename;

                    if(!_fileModeloC.Equals("")) {
                        _SourceModeloC.Clear();
                        ReadModeloC();
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadModeloC() {
            // Read sample data from CSV file
            using(CsvFileReader reader = new CsvFileReader(_fileModeloC)) {
                Application.DoEvents();
                CsvRow row = new CsvRow();
                if(reader.ReadRow(row)) {
                    //foreach (String s in row)
                    //{
                    //    dgvDados.Columns.Add(s, s);
                    //}
                }

                while(reader.ReadRow(row) /*&& i < limitValues*/) {
                    _SourceModeloC.Add(new Source.citModeloC(row));
                }

                dgvModeloC.DataSource = _SourceModeloC;

            }
        }

        #endregion

        private void btnJuntarFicheirosFloadRload_Click(object sender, EventArgs e) {
            int index1 = -1;
            int index2 = -1;
            int index3 = -1;

            Source.citTotalLoadsFload auxFload = null;
            Source.citTotalLoadsRload auxRload = null;
            Source.citExpenseTurnoverFee auxExpense = null;
            //Source.citModeloC auxModeloC = null;

            Source.citParte4Final auxResult = null;

            try {
                Cursor = Cursors.WaitCursor;

                _result.Clear();

                foreach(Source.citModeloC modC in _SourceModeloC) {
                    index1 = -1;
                    index2 = -2;
                    index3 = -3;
                    auxFload = null;
                    auxRload = null;
                    auxExpense = null;

                    index1 = _SourceTotalLoadsFload.FindIndex(f => f.KycrspFundno == modC.KYCRSP_FUNDNO && f.Fflbegdt <= modC.MCALDT && f.Fflenddt >= modC.MCALDT);
                    index2 = _SourceTotalLoadsRload.FindIndex(r => r.KycrspFundno == modC.KYCRSP_FUNDNO && r.Frlbegdt <= modC.MCALDT && r.Frlenddt >= modC.MCALDT);
                    index3 = _SourceExpensiveTurnoverFee.FindIndex(ex => ex.KycrspFundno == modC.KYCRSP_FUNDNO && ex.Ffebegdt <= modC.MCALDT && ex.Ffeenddt >= modC.MCALDT);

                    if(index1 >= 0) { auxFload = _SourceTotalLoadsFload[index1]; }
                    if(index2 >= 0) { auxRload = _SourceTotalLoadsRload[index2]; }
                    if(index3 >= 0) { auxExpense = _SourceExpensiveTurnoverFee[index3]; }

                    auxResult = new Source.citParte4Final(modC, auxFload, auxRload, auxExpense);

                    _result.Add(auxResult);
                }

                //ordena os resultados e elimina linhas repetidas

                //_result = (from r in _result select r).Distinct().ToList();
                //_result = _result.GroupBy(x => x.KycrspFundno, (k, g) => g.Aggregate((a, x) =>x.Equals(a) ? x : a)).ToList();
                _result = (from x in _result orderby x.KycrspFundno, x.MCALDT select x).ToList();

                //_result.RemoveAll(r => r.FrontLoad == null || r.FrontLoad.Length > 0 || r.RearLoad == null || r.RearLoad.Length > 0 || r.Ffeenddt == null || r.Ffeenddt.ToString().Length > 2);

                dgvFicheirosFinal.DataSource = _result;

            } catch(Exception ex) {
                MessageBox.Show("Error merge files.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Cursor = Cursors.Default;
            }
        }

        private void btnToCSV_Click(object sender, EventArgs e) {
            try {
                // Displays a SaveFileDialog so the user can save the Image
                // assigned to Button2.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "CSV|*.csv";
                saveFileDialog1.Title = "Guardar como csv...";
                saveFileDialog1.ShowDialog();

                if(saveFileDialog1.FileName != "") {
                    Cursor = Cursors.WaitCursor;

                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    fs.Close();

                    CsvFileWriter file = new CsvFileWriter(saveFileDialog1.FileName);

                    CsvRow header = new CsvRow();

                    foreach(DataGridViewColumn col in dgvFicheirosFinal.Columns) {
                        header.Add(col.Name);
                    }

                    file.WriteRow(header);

                    foreach(Source.citParte4Final item in _result) {
                        file.WriteRow(item.ToCsv());
                    }

                    file.Flush();
                    file.Close();

                    MessageBox.Show("Ficheiro guardado.");
                }


            } catch(Exception ex) {
                MessageBox.Show("Erro\n" + ex.Message);
            } finally {
                Cursor = Cursors.Default;
            }
        }

        

    }
}
