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

namespace ObjectiveCodes
{
    public partial class uscParte3 : UserControl
    {
        private string _fileTotalLoadsFload = "";
        private List<Source.citTotalLoadsFload> _SourceTotalLoadsFload = new List<Source.citTotalLoadsFload>();

        private string _fileTotalLoadsRload = "";
        private List<Source.citTotalLoadsRload> _SourceTotalLoadsRload = new List<Source.citTotalLoadsRload>();

        private string _fileExpenseTurnoverFee = "";
        private List<Source.citExpenseTurnoverFee> _SourceExpensiveTurnoverFee = new List<Source.citExpenseTurnoverFee>();

        private List<Source.citFloadAndRoad> _result = new List<Source.citFloadAndRoad>();

        public uscParte3()
        {
            InitializeComponent();
        }

        #region "Total Loads Fload"

        private void btnAbrirTotalLoadsFload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                if (ret == DialogResult.OK)
                {
                    _fileTotalLoadsFload = filename;

                    if (!_fileTotalLoadsFload.Equals(""))
                    {
                        ReadTotalLoadsFload();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadTotalLoadsFload()
        {
            // Read sample data from CSV file
            using (CsvFileReader reader = new CsvFileReader(_fileTotalLoadsFload))
            {
                Application.DoEvents();
                CsvRow row = new CsvRow();
                if (reader.ReadRow(row))
                {
                    //foreach (String s in row)
                    //{
                    //    dgvDados.Columns.Add(s, s);
                    //}
                }

                while (reader.ReadRow(row) /*&& i < limitValues*/)
                {
                    _SourceTotalLoadsFload.Add(new Source.citTotalLoadsFload(row));
                }

                var query = _SourceTotalLoadsFload.GroupBy(x => x.KycrspFundno, (k, g) => g.Aggregate((a, x) => (x.FrontLoad > a.FrontLoad) ? x : a));
                _SourceTotalLoadsFload = query.ToList();

                dgvTotalLoadsFload.DataSource = _SourceTotalLoadsFload;

            }
        }

        #endregion

        #region "Total loads Rload"

        private void btnAbrirTotalLoadsRload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                if (ret == DialogResult.OK)
                {
                    _fileTotalLoadsRload = filename;

                    if (!_fileTotalLoadsRload.Equals(""))
                    {
                        ReadTotalLoadsRload();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadTotalLoadsRload()
        {
            // Read sample data from CSV file
            using (CsvFileReader reader = new CsvFileReader(_fileTotalLoadsRload))
            {
                Application.DoEvents();
                CsvRow row = new CsvRow();
                if (reader.ReadRow(row))
                {
                    //foreach (String s in row)
                    //{
                    //    dgvDados.Columns.Add(s, s);
                    //}
                }

                while (reader.ReadRow(row) /*&& i < limitValues*/)
                {
                    _SourceTotalLoadsRload.Add(new Source.citTotalLoadsRload(row));
                }

                var query = _SourceTotalLoadsRload.GroupBy(x => x.KycrspFundno, (k, g) => g.Aggregate((a, x) => (x.RearLoad > a.RearLoad) ? x : a));
                _SourceTotalLoadsRload = query.ToList();

                dgvTotalLoadsRload.DataSource = _SourceTotalLoadsRload;
            }
        }

        #endregion

        #region "Expense Turnover Fee"

        private void btnAbrirExpenseTurnoverFee_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                Cursor = Cursors.WaitCursor;

                if (ret == DialogResult.OK)
                {
                    _fileExpenseTurnoverFee = filename;

                    if (!_fileExpenseTurnoverFee.Equals(""))
                    {
                        ReadExpensiveTurnoverFee();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Cursor = Cursors.Default; }

        }

        private void ReadExpensiveTurnoverFee()
        {
            // Read sample data from CSV file
            using (CsvFileReader reader = new CsvFileReader(_fileExpenseTurnoverFee))
            {
                Application.DoEvents();
                CsvRow row = new CsvRow();
                if (reader.ReadRow(row))
                {
                    //foreach (String s in row)
                    //{
                    //    dgvDados.Columns.Add(s, s);
                    //}
                }

                while (reader.ReadRow(row) /*&& i < limitValues*/)
                {
                    _SourceExpensiveTurnoverFee.Add(new Source.citExpenseTurnoverFee(row));
                    Console.WriteLine(row[0]);
                }

                dgvExpenseTurnoverFee.DataSource = _SourceExpensiveTurnoverFee;
            }
        }

        #endregion

        private void btnJuntarFicheirosFloadRload_Click(object sender, EventArgs e)
        {
            int index1 = -1;
            int index2 = -1;

            Source.citTotalLoadsFload auxFload = null;
            Source.citTotalLoadsRload auxRload = null;
            Source.citExpenseTurnoverFee auxExpense = null;

            try
            {

                foreach (Source.citTotalLoadsFload fload in _SourceTotalLoadsFload)
                {
                    index1 = -1;
                    index2 = -1;
                    auxFload = fload;
                    auxRload = null;
                    auxExpense = null;

                    // procura no rload um fundo igual
                    index1 = _SourceTotalLoadsRload.FindIndex(r => r.KycrspFundno == fload.KycrspFundno && r.Frlbegdt == fload.Fflbegdt && r.Frlenddt == fload.Fflenddt);
                    index2 = _SourceExpensiveTurnoverFee.FindIndex(r => r.KycrspFundno == fload.KycrspFundno && r.Ffebegdt >= fload.Fflbegdt && r.Ffeenddt <= fload.Fflenddt);

                    if (index1 > 0) auxRload = _SourceTotalLoadsRload[index1];
                    if (index2 > 0) auxExpense = _SourceExpensiveTurnoverFee[index2];

                    _result.Add(new Source.citFloadAndRoad(auxFload, auxRload, auxExpense));

                }

                foreach (Source.citTotalLoadsRload rload in _SourceTotalLoadsRload)
                {
                    index1 = -1;
                    index2 = -1;
                    auxFload = null;
                    auxRload = rload;
                    auxExpense = null;

                    // procura no rload um fundo igual
                    index1 = _SourceTotalLoadsFload.FindIndex(f => (f.KycrspFundno == rload.KycrspFundno && f.Fflbegdt == rload.Frlbegdt && f.Fflenddt == rload.Frlenddt));
                    index2 = _SourceExpensiveTurnoverFee.FindIndex(r => r.KycrspFundno == rload.KycrspFundno && r.Ffebegdt >= rload.Frlbegdt && r.Ffeenddt <= rload.Frlenddt);

                    if (index1 > 0) auxFload = _SourceTotalLoadsFload[index1];
                    if (index2 > 0) auxExpense = _SourceExpensiveTurnoverFee[index2];

                    _result.Add(new Source.citFloadAndRoad(auxFload, auxRload, auxExpense));
                }

                foreach (Source.citExpenseTurnoverFee expense in _SourceExpensiveTurnoverFee)
                {
                    index1 = -1;
                    index2 = -1;
                    auxFload = null;
                    auxRload = null;
                    auxExpense = expense;

                    // procura no rload um fundo igual
                    index1 = _SourceTotalLoadsFload.FindIndex(f => (f.KycrspFundno == expense.KycrspFundno && f.Fflbegdt <= expense.Ffebegdt && f.Fflenddt >= expense.Ffeenddt));
                    index2 = _SourceTotalLoadsRload.FindIndex(r => r.KycrspFundno == expense.KycrspFundno && r.Frlbegdt <= expense.Ffebegdt && r.Frlenddt >= expense.Ffeenddt);

                    if (index1 > 0) auxFload = _SourceTotalLoadsFload[index1];
                    if (index2 > 0) auxExpense = _SourceExpensiveTurnoverFee[index2];

                    _result.Add(new Source.citFloadAndRoad(auxFload, auxRload, auxExpense));
                }

                //ordena os resultados e elimina linhas repetidas

                //_result = (from r in _result select r).Distinct().ToList();
                //_result = _result.GroupBy(x => x.KycrspFundno, (k, g) => g.Aggregate((a, x) =>x.Equals(a) ? x : a)).ToList();
                _result = (from x in _result orderby x.KycrspFundno, x.Fflbegdt, x.Frlbegdt, x.Ffebegdt select x).ToList();
                
                dgvFicheirosFloadRload.DataSource = _result;

                citResultado.Parte3 = _result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error merge files.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
