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
    public partial class uscDeterminantes
        :UserControl {
        private string _fileDeterminantes = "";
        private List<Source.citDeterminantes> _SourceDeterminantes = new List<Source.citDeterminantes>();

        private List<Source.citDeterminantes> _result = new List<Source.citDeterminantes>();

        public uscDeterminantes() {
            InitializeComponent();
        }

        private void btnAbrirModeloC_Click(object sender, EventArgs e) {
            try {

                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                if(ret == DialogResult.OK) {
                    _fileDeterminantes = filename;

                    Cursor = Cursors.WaitCursor;

                    if(!_fileDeterminantes.Equals("")) {
                        _SourceDeterminantes.Clear();
                        ReadDeterminantes();
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Cursor = Cursors.Default;
            }
        }

        private void ReadDeterminantes() {
            // Read sample data from CSV file
            using(CsvFileReader reader = new CsvFileReader(_fileDeterminantes)) {
                Application.DoEvents();
                CsvRow row = new CsvRow();
                if(reader.ReadRow(row)) {
                    //foreach (String s in row)
                    //{
                    //    dgvDados.Columns.Add(s, s);
                    //}
                }

                while(reader.ReadRow(row) /*&& i < limitValues*/) {
                    _SourceDeterminantes.Add(new Source.citDeterminantes(row));
                }

                dgvDeterminantes.DataSource = _SourceDeterminantes;

            }
        }

        private void btnJuntar_Click(object sender, EventArgs e) {
            HashSet<int> fundos_com_99 = new HashSet<int>(); //para depois alterar a coluna FEXP_RATIO pela FMGMT_FEE

            List<Source.citDeterminantes> resultTmp = new List<Source.citDeterminantes>();

            bool manter = true;
            Source.citDeterminantes determinante;
            Source.citDeterminantes determinante2;
            int count = _SourceDeterminantes.Count;

            try {
                Cursor = Cursors.WaitCursor;

                _result.Clear();
                resultTmp.Clear();
                int total = count;

                for(int i = 0; i < _SourceDeterminantes.Count ; i++) {
                    
                    manter = false;
                    
                    determinante = _SourceDeterminantes[i];

                    // se não tiver Front_Load e Reader load é para remover, ou seja, não adiciona ao result
                    // basta no fundo um dos registos ter para não se apagar

                    for(int j = i-50 ; j < i+50 ; j++) {
                        if(j >= 0 && j < count) {
                            determinante2 = _SourceDeterminantes[j];
                            if(determinante.KYCRSP_FUNDNO == determinante2.KYCRSP_FUNDNO &&
                                (!String.IsNullOrEmpty(determinante2.FRONT_LOAD) ||
                                !String.IsNullOrEmpty(determinante2.REAR_LOAD))) {
                                
                                manter = true;
                                break;
                            }
                        }
                    }

                    //manter = _SourceDeterminantes.Any(d => d.KYCRSP_FUNDNO == determinante.KYCRSP_FUNDNO && (!String.IsNullOrEmpty(d.FRONT_LOAD) || !String.IsNullOrEmpty(d.REAR_LOAD)));
                    
                    if(manter) {
                        
                        resultTmp.Add(determinante);
                        
                        if(determinante.FEXP_RATIO.Contains("-99")) fundos_com_99.Add(determinante.KYCRSP_FUNDNO);
                    }
                    total--;

                    if(total % 512 == 0) {
                        btnAnalisar.Text = total.ToString();
                        Application.DoEvents();
                    }
                }

                btnAnalisar.Text = "Analisar";

                foreach(Source.citDeterminantes det in resultTmp) {
                    if(fundos_com_99.Contains(det.KYCRSP_FUNDNO)) det.FEXP_RATIO = det.FMGMT_FEE;

                    _result.Add(det);
                }
                
                dgvParte6.DataSource = _result;

            } catch(Exception) {

                MessageBox.Show("Error merge result.");
            } finally {
                Cursor = Cursors.Default;
            }
        }

        private bool VerificaEntreDatas(Source.citModeloC modeloC, Source.citFloadAndRoad parte3) {
            if((modeloC.MCALDT >= parte3.Fflbegdt && modeloC.MCALDT <= parte3.Fflenddt) ||
                (modeloC.MCALDT >= parte3.Frlbegdt && modeloC.MCALDT <= parte3.Frlenddt) ||
                (modeloC.MCALDT >= parte3.Ffebegdt && modeloC.MCALDT <= parte3.Ffeenddt)) {
                return true;
            } else {
                return false;
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

                    foreach(DataGridViewColumn col in dgvParte6.Columns) {
                        header.Add(col.Name);
                    }

                    file.WriteRow(header);

                    foreach(Source.citDeterminantes item in _result) {
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
