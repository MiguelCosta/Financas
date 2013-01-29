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
    public partial class uscParte4 : UserControl
    {
        private string _fileModeloC = "";
        private List<Source.citModeloC> _SourceModeloC = new List<Source.citModeloC>();

        private List<Source.citParte4Final> _result = new List<Source.citParte4Final>();


        public uscParte4()
        {
            InitializeComponent();
        }

        private void btnAbrirModeloC_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                if (ret == DialogResult.OK)
                {
                    _fileModeloC = filename;

                    if (!_fileModeloC.Equals(""))
                    {
                        _SourceModeloC.Clear();
                        ReadModeloC();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadModeloC()
        {
            // Read sample data from CSV file
            using (CsvFileReader reader = new CsvFileReader(_fileModeloC))
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
                    _SourceModeloC.Add(new Source.citModeloC(row));
                }

                dgvModeloC.DataSource = _SourceModeloC;

            }
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            int index = -1;

            try {
                Cursor = Cursors.WaitCursor;

                _result.Clear();
                foreach(Source.citModeloC modeloC in _SourceModeloC) {
                    index = -1;

                    index = citResultado.Parte3.FindIndex(r => r.KycrspFundno == modeloC.KYCRSP_FUNDNO && VerificaEntreDatas(modeloC, r));

                    if(index > 0) {
                        _result.Add(new Source.citParte4Final(modeloC, citResultado.Parte3[index]));
                    } else {
                        _result.Add(new Source.citParte4Final(modeloC, null));
                    }
                }

                dgvParte4Final.DataSource = _result;

            } catch(Exception) {

                MessageBox.Show("Error merge result.");
            } finally {
                Cursor = Cursors.Default;
            }
        }

        private bool VerificaEntreDatas(Source.citModeloC modeloC, Source.citFloadAndRoad parte3)
        {
            if ((modeloC.MCALDT >= parte3.Fflbegdt && modeloC.MCALDT <= parte3.Fflenddt) ||
                (modeloC.MCALDT >= parte3.Frlbegdt && modeloC.MCALDT <= parte3.Frlenddt) ||
                (modeloC.MCALDT >= parte3.Ffebegdt && modeloC.MCALDT <= parte3.Ffeenddt))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnToCSV_Click(object sender, EventArgs e)
        {
            try
            {
                // Displays a SaveFileDialog so the user can save the Image
                // assigned to Button2.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "CSV|*.csv";
                saveFileDialog1.Title = "Guardar como csv...";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    Cursor = Cursors.WaitCursor;

                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    fs.Close();

                    CsvFileWriter file = new CsvFileWriter(saveFileDialog1.FileName);

                    CsvRow header = new CsvRow();

                    foreach (DataGridViewColumn col in dgvParte4Final.Columns)
                    {
                        header.Add(col.Name);
                    }

                    file.WriteRow(header);

                    foreach (Source.citParte4Final item in _result)
                    {
                        file.WriteRow(item.ToCsv());
                    }

                    file.Flush();
                    file.Close();

                    MessageBox.Show("Ficheiro guardado.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro\n" + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

    }
}
