using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadWriteCsv;
using Microsoft.VisualBasic;

namespace ObjectiveCodes
{
    public partial class frmPrincipal : Form
    {
        private string _file = "";
        //private const int limitValues = 3000;


        #region "form"

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        #endregion

        #region "ObjectiveCodes

        private const int indice_warning = 5;
        private const int indice_remover = 6;

        private const int pesquisaLinhasDepois = 30;
        private const int pesquisaLinhasAntes = 10;

        private List<DataGridViewRow> _resultado = new List<DataGridViewRow>(65000);
        private List<DataGridViewRow> _resultadoWarning = new List<DataGridViewRow>(1000);
        private List<DataGridViewRow> _resultadoRemover = new List<DataGridViewRow>(1000);
        private List<DataGridViewRow> _resultadoFinal = new List<DataGridViewRow>(65000);

        #region "Menu"

        /// <summary>
        /// Evento para fechar a aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region "Botões"

        private void btnAbrirFicheiro_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                if (ret == DialogResult.OK)
                {
                    _file = filename;

                    if (!_file.Equals(""))
                    {
                        ReadTest();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            analisa();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar(true);
            lblProgresso.Visible = false;
            lblProgressoCount.Visible = false;
            pgbAnalise.Visible = false;
        }

        #endregion

        #region "Rotinas"

        void ReadTest()
        {
            //dgvDados.Columns.Clear();

            // Read sample data from CSV file
            using (CsvFileReader reader = new CsvFileReader(_file))
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
                int i = 0;
                while (reader.ReadRow(row) /*&& i < limitValues*/)
                {
                    DadosAddLine(row);  // adiciona uma linha à grelha
                    i++;
                }
            }
        }

        /// <summary>
        /// Adiciona uma linha à grelha a partir de uma linha do csv 
        /// </summary>
        /// <param name="row"></param>
        void DadosAddLine(CsvRow row)
        {
            int i = 0;
            int index = dgvDados.Rows.Add();
            foreach (String s in row)
            {
                dgvDados.Rows[index].Cells[i].Value = s;
                i++;
            }
        }

        /// <summary>
        /// Este método é o que vai pegar nos dados e vai colocar em memória
        /// várias listas com as linhas analisadas.
        /// </summary>
        private void analisa()
        {
            object[] buffer = new object[7];                // buffer usado para criar uma linha analisada
            DataGridViewRow rowNew = new DataGridViewRow(); // variável que vai ser usada para criar uma nova linha analiasada

            try
            {

                Cursor = Cursors.WaitCursor;
                limpar(false);                              // limpa todas as grelhas excepto a grelha dos dados

                int rowCount = dgvDados.Rows.Count;         // número total de linhas que vai ter de percorrer

                lblProgresso.Visible = true;                // código usado apenas para o interface mostra o progresso
                lblProgressoCount.Visible = true;
                pgbAnalise.Visible = true;
                pgbAnalise.Value = 0;
                pgbAnalise.Maximum = rowCount;
                lblProgresso.Text = "Passo 1 de 5";
                lblProgressoCount.Text = "0 de " + rowCount;


                List<DataGridViewRow> linhas = new List<DataGridViewRow>(); // variável que vai ter todas as linhas dos dados
                foreach (DataGridViewRow row in dgvDados.Rows)
                {
                    linhas.Add(row);
                }


                foreach (DataGridViewRow row in dgvDados.Rows)  // ciclo para percorrer todas as linhas e comparar com as restantes
                {
                    rowNew = new DataGridViewRow();

                    // lista que vai conter todos os fundos com ID igual ao da linha que está a ser analisada
                    // mas que tem um código diferente
                    var codigoDiferente = (from linha in linhas
                                           where linha.Index > row.Index - pesquisaLinhasAntes
                                                 && row.Cells[0].Value.Equals(linha.Cells[0].Value)
                                                 && row.Cells[4].Value != null
                                                 && !row.Cells[4].Value.Equals(linha.Cells[4].Value)
                                           select linha).ToList();

                    // lista que vai ter todos os fundos com ID igual ao da linha que está a ser analisada
                    // mas que não tem código
                    var campoVazio = (from linha2 in linhas
                                      where row.Cells[0].Value.Equals(linha2.Cells[0].Value)
                                            && (linha2.Cells[4].Value == null
                                            || linha2.Cells[4].Value.Equals(""))
                                      select linha2).ToList();

                    // preencher o buffer para depois criar uma linha
                    buffer[0] = (string)row.Cells[dgvDados_KYCRSPFUNDNO.Index].Value;
                    buffer[1] = (string)row.Cells[dgvDados_FSTYBEGDT.Index].Value;
                    buffer[2] = (string)row.Cells[dgvDados_FSTYENDDT.Index].Value;
                    buffer[3] = (string)row.Cells[dgvDados_LIPPERCLASS.Index].Value;
                    buffer[4] = (string)row.Cells[dgvDados_LIPPEROBJCD.Index].Value;

                    // se houver fundos com o mesmo ID mas com código diferente marca a linha como ser para remover
                    if (codigoDiferente.Count > 0) buffer[indice_remover] = true; else buffer[indice_remover] = false;
                    // se houver fundos com o mesmo ID mas que não tem código, marca a linha com warning
                    if (campoVazio.Count > 0) buffer[indice_warning] = true; else buffer[indice_warning] = false;

                    rowNew.CreateCells(dgvResultado, buffer);
                    _resultado.Add(rowNew);

                    if (codigoDiferente.Count > 0)
                    {
                        rowNew = new DataGridViewRow();
                        rowNew.CreateCells(dgvResultado, buffer);
                        _resultadoRemover.Add(rowNew);
                    }
                    if (campoVazio.Count > 0)
                    {
                        rowNew = new DataGridViewRow();
                        rowNew.CreateCells(dgvResultado, buffer);
                        _resultadoWarning.Add(rowNew);
                    }

                    if (!(codigoDiferente.Count > 0) && !(campoVazio.Count > 0))
                    {
                        rowNew = new DataGridViewRow();
                        rowNew.CreateCells(dgvResultado, buffer);
                        _resultadoFinal.Add(rowNew);
                    }

                    lblProgressoCount.Text = (row.Index + 1) + " de " + rowCount;
                    pgbAnalise.Value = row.Index + 1;

                    Application.DoEvents();
                }

                // preencher as grelhas
                preencherResultados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a analisar o ficheiro.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Método que vai pegar nas listas depois da análise e preencher o interface
        /// </summary>
        private void preencherResultados()
        {
            try
            {

                Application.DoEvents();
                int rowCount = _resultado.Count;
                pgbAnalise.Value = 0;
                pgbAnalise.Maximum = rowCount;
                lblProgresso.Text = "Passo 2 de 5";
                foreach (DataGridViewRow row in _resultado)
                {
                    dgvResultado.Rows.Add(row);
                    lblProgressoCount.Text = (row.Index + 1) + " de " + rowCount;
                    pgbAnalise.Value = row.Index + 1;
                    Application.DoEvents();

                }

                rowCount = _resultadoWarning.Count;
                pgbAnalise.Value = 0;
                pgbAnalise.Maximum = rowCount;
                lblProgresso.Text = "Passo 3 de 5";
                foreach (DataGridViewRow row in _resultadoWarning)
                {
                    dgvWarning.Rows.Add(row);
                    lblProgressoCount.Text = (row.Index + 1) + " de " + rowCount;
                    pgbAnalise.Value = row.Index + 1;
                    Application.DoEvents();

                }

                rowCount = _resultadoRemover.Count;
                pgbAnalise.Value = 0;
                pgbAnalise.Maximum = rowCount;
                lblProgresso.Text = "Passo 4 de 5";
                foreach (DataGridViewRow row in _resultadoRemover)
                {
                    dgvRemovido.Rows.Add(row);
                    lblProgressoCount.Text = (row.Index + 1) + " de " + rowCount;
                    pgbAnalise.Value = row.Index + 1;
                    Application.DoEvents();
                }

                rowCount = _resultadoFinal.Count;
                pgbAnalise.Value = 0;
                pgbAnalise.Maximum = rowCount;
                lblProgresso.Text = "Passo 5 de 5";
                foreach (DataGridViewRow row in _resultadoFinal)
                {
                    dgvResultadoFinal.Rows.Add(row);
                    lblProgressoCount.Text = (row.Index + 1) + " de " + rowCount;
                    pgbAnalise.Value = row.Index + 1;
                    Application.DoEvents();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher análise.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                pgbAnalise.Value = pgbAnalise.Maximum;

            }

        }

        private void limpar(bool grelhaDados)
        {
            try
            {
                if (grelhaDados) dgvDados.Rows.Clear();
                dgvResultado.Rows.Clear();
                _resultado.Clear();
                dgvWarning.Rows.Clear();
                _resultadoWarning.Clear();
                dgvRemovido.Rows.Clear();
                _resultadoRemover.Clear();
                dgvResultadoFinal.Rows.Clear();
                _resultadoFinal.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao limpar.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion

        #endregion



        private const int indice_warningFOD = 4;
        private const int indice_removerFOD = 5;

        private List<DataGridViewRow> _resultadoFOD = new List<DataGridViewRow>(65000);
        private List<DataGridViewRow> _resultadoWarningFOD = new List<DataGridViewRow>(1000);
        private List<DataGridViewRow> _resultadoRemoverFOD = new List<DataGridViewRow>(1000);
        private List<DataGridViewRow> _resultadoFinalFOD = new List<DataGridViewRow>(65000);

        private void btnAbrirFicheiroFOD_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
                DialogResult ret = o.ShowDialog();
                String filename = o.FileName;

                if (ret == DialogResult.OK)
                {
                    _file = filename;

                    if (!_file.Equals(""))
                    {
                        ReadTestFDO();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Open File.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        void ReadTestFDO()
        {
            //dgvDados.Columns.Clear();

            // Read sample data from CSV file
            using (CsvFileReader reader = new CsvFileReader(_file))
            {
                Application.DoEvents();
                CsvRow row = new CsvRow();
                if (reader.ReadRow(row))
                {
                }
                int i = 0;
                while (reader.ReadRow(row) /*&& i < limitValues*/)
                {
                    DadosAddLineFOD(row);  // adiciona uma linha à grelha
                    i++;
                }
            }
        }

        /// <summary>
        /// Adiciona uma linha à grelha a partir de uma linha do csv 
        /// </summary>
        /// <param name="row"></param>
        void DadosAddLineFOD(CsvRow row)
        {
            int i = 0;
            int index = dgvDadosFOD.Rows.Add();
            foreach (String s in row)
            {
                dgvDadosFOD.Rows[index].Cells[i].Value = s;
                i++;
            }
        }

        private void btnAnalisarFOD_Click(object sender, EventArgs e)
        {
            analisaFOD();
        }

        private void analisaFOD()
        {
            object[] buffer = new object[6];                // buffer usado para criar uma linha analisada
            DataGridViewRow rowNew = new DataGridViewRow(); // variável que vai ser usada para criar uma nova linha analiasada

            try
            {

                Cursor = Cursors.WaitCursor;
                limparFOD(false);                              // limpa todas as grelhas excepto a grelha dos dados

                int rowCount = dgvDadosFOD.Rows.Count;         // número total de linhas que vai ter de percorrer

                lblProgressoFOD.Visible = true;                // código usado apenas para o interface mostra o progresso
                lblProgressoCountFOD.Visible = true;
                pgbAnaliseFOD.Visible = true;
                pgbAnaliseFOD.Value = 0;
                pgbAnaliseFOD.Maximum = rowCount;
                lblProgressoFOD.Text = "Passo 1 de 4";
                lblProgressoCountFOD.Text = "0 de " + rowCount;


                List<DataGridViewRow> linhas = new List<DataGridViewRow>(); // variável que vai ter todas as linhas dos dados
                foreach (DataGridViewRow row in dgvDadosFOD.Rows)
                {
                    linhas.Add(row);
                }


                foreach (DataGridViewRow row in dgvDadosFOD.Rows)  // ciclo para percorrer todas as linhas e comparar com as restantes
                {
                    rowNew = new DataGridViewRow();

                    var dataDiferente = (from linha in linhas
                                         where !String.IsNullOrEmpty((string)row.Cells[3].Value)
                                            && row.Cells[1].Value.Equals(linha.Cells[1].Value)
                                            && !row.Cells[3].Value.Equals(linha.Cells[3].Value)
                                            && eDepois((string)row.Cells[3].Value, (string)linha.Cells[3].Value)
                                         select linha).ToList();

                    // preencher o buffer para depois criar uma linha
                    buffer[0] = (string)row.Cells[0].Value;
                    buffer[1] = (string)row.Cells[1].Value;
                    buffer[2] = (string)row.Cells[2].Value;
                    buffer[3] = (string)row.Cells[3].Value;
                    buffer[4] = false;
                    buffer[5] = false;

                    if (dataDiferente.Count > 0)
                    {
                        buffer[4] = true;
                        buffer[5] = true;
                        rowNew = new DataGridViewRow();
                        rowNew.CreateCells(dgvResultadoFOD, buffer);
                        _resultadoRemoverFOD.Add(rowNew);
                    }
                    else
                    {
                        rowNew = new DataGridViewRow();
                        rowNew.CreateCells(dgvResultadoFOD, buffer);
                        _resultadoFinalFOD.Add(rowNew);
                    }

                    rowNew = new DataGridViewRow();
                    rowNew.CreateCells(dgvResultadoFOD, buffer);
                    _resultadoFOD.Add(rowNew);

                    lblProgressoCountFOD.Text = (row.Index + 1) + " de " + rowCount;
                    pgbAnaliseFOD.Value = row.Index + 1;

                    Application.DoEvents();
                }

                // preencher as grelhas
                preencherResultadosFOD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a analisar o ficheiro.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool eDepois(string data1, string data2)
        {
            if (data1 == null || data2 == null) return false;

            int ano = Convert.ToInt32(data1.Substring(6, 4));
            int mes = Convert.ToInt32(data1.Substring(3, 2));
            int dia = Convert.ToInt32(data1.Substring(0, 2));
            DateTime dt1 = new DateTime(ano, mes, dia);

            ano = Convert.ToInt32(data2.Substring(6, 4));
            mes = Convert.ToInt32(data2.Substring(3, 2));
            dia = Convert.ToInt32(data2.Substring(0, 2));
            DateTime dt2 = new DateTime(ano, mes, dia);

            bool result = dt1 > dt2;

            return dt1 > dt2;
        }

        private void limparFOD(bool grelhaDados)
        {
            try
            {
                if (grelhaDados) dgvDadosFOD.Rows.Clear();
                dgvResultadoFOD.Rows.Clear();
                _resultadoFOD.Clear();

                dgvRemovidoFOD.Rows.Clear();
                _resultadoRemover.Clear();

                dgvResultadoFinalFOD.Rows.Clear();
                _resultadoFinalFOD.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao limpar.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        /// <summary>
        /// Método que vai pegar nas listas depois da análise e preencher o interface
        /// </summary>
        private void preencherResultadosFOD()
        {
            try
            {

                Application.DoEvents();
                int rowCount = _resultadoFOD.Count;
                pgbAnaliseFOD.Value = 0;
                pgbAnaliseFOD.Maximum = rowCount;
                lblProgressoFOD.Text = "Passo 2 de 4";
                foreach (DataGridViewRow row in _resultadoFOD)
                {
                    dgvResultadoFOD.Rows.Add(row);
                    lblProgressoCountFOD.Text = (row.Index + 1) + " de " + rowCount;
                    pgbAnaliseFOD.Value = row.Index + 1;
                    Application.DoEvents();

                }

                rowCount = _resultadoRemoverFOD.Count;
                pgbAnaliseFOD.Value = 0;
                pgbAnaliseFOD.Maximum = rowCount;
                lblProgressoFOD.Text = "Passo 3 de 4";
                foreach (DataGridViewRow row in _resultadoRemoverFOD)
                {
                    dgvRemovidoFOD.Rows.Add(row);
                    lblProgressoCountFOD.Text = (row.Index + 1) + " de " + rowCount;
                    pgbAnaliseFOD.Value = row.Index + 1;
                    Application.DoEvents();
                }

                rowCount = _resultadoFinalFOD.Count;
                pgbAnaliseFOD.Value = 0;
                pgbAnaliseFOD.Maximum = rowCount;
                lblProgressoFOD.Text = "Passo 4 de 4";
                foreach (DataGridViewRow row in _resultadoFinalFOD)
                {
                    dgvResultadoFinalFOD.Rows.Add(row);
                    lblProgressoCountFOD.Text = (row.Index + 1) + " de " + rowCount;
                    pgbAnaliseFOD.Value = row.Index + 1;
                    Application.DoEvents();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher análise.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                pgbAnaliseFOD.Value = pgbAnaliseFOD.Maximum;

            }

        }

        private void btnLimparFOD_Click(object sender, EventArgs e)
        {
            limparFOD(true);
        }

    }
}
