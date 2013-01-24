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


            try
            {

                foreach (Source.citModeloC modeloC in _SourceModeloC)
                {
                    index = -1;

                    index = citResultado.Parte3.FindIndex(r => VerificaEntreDatas(modeloC, r));

                    if (index > 0)
                    {
                        _result.Add(new Source.citParte4Final(modeloC, citResultado.Parte3[index]));
                    }
                }

                dgvParte4Final.DataSource = _result;

            }
            catch (Exception)
            {
                
                throw;
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
                CsvFileWriter file = new CsvFileWriter("C:\\teste.csv");

                CsvRow header = new CsvRow();
                header[0] = dgvModeloC.Columns[0].Name;
                header[1] = dgvModeloC.Columns[1].Name;
                header[2] = dgvModeloC.Columns[2].Name;
                header[3] = dgvModeloC.Columns[3].Name;
                header[4] = dgvModeloC.Columns[4].Name;
                header[5] = dgvModeloC.Columns[5].Name;
                header[6] = dgvModeloC.Columns[6].Name;
                header[7] = dgvModeloC.Columns[7].Name;
                header[8] = dgvModeloC.Columns[8].Name;
                header[9] = dgvModeloC.Columns[9].Name;
                header[10] = dgvModeloC.Columns[10].Name;
                header[11] = dgvModeloC.Columns[11].Name;
                header[12] = dgvModeloC.Columns[12].Name;
                header[13] = dgvModeloC.Columns[13].Name;
                header[14] = dgvModeloC.Columns[14].Name;
                header[15] = dgvModeloC.Columns[15].Name;
                header[16] = dgvModeloC.Columns[16].Name;
                header[17] = dgvModeloC.Columns[17].Name;
                header[18] = dgvModeloC.Columns[18].Name;
                header[19] = dgvModeloC.Columns[19].Name;
                header[20] = dgvModeloC.Columns[20].Name;
                header[21] = dgvModeloC.Columns[21].Name;
                header[22] = dgvModeloC.Columns[22].Name;
                header[23] = dgvModeloC.Columns[23].Name;
                header[24] = dgvModeloC.Columns[24].Name;
                header[25] = dgvModeloC.Columns[25].Name;

                file.WriteRow(header);

                foreach (Source.citParte4Final item in _result)
                {
                    file.WriteRow(item.ToCsv());
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro\n" + ex.Message);
            }
        }

    }
}
