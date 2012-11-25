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

namespace ObjectiveCodes
{
    public partial class frmPrincipal : Form
    {
        private string _file = "";
        //private const int limitValues = 3000;
        private const int indice_warning = 5;
        private const int indice_remover = 6;

        private const int pesquisaLinhasDepois = 30;
        private const int pesquisaLinhasAntes = 10;

        private List<DataGridViewRow> _resultado = new List<DataGridViewRow>(65000);
        private List<DataGridViewRow> _resultadoWarning = new List<DataGridViewRow>(1000);
        private List<DataGridViewRow> _resultadoRemover = new List<DataGridViewRow>(1000);
        private List<DataGridViewRow> _resultadoFinal = new List<DataGridViewRow>(65000);

        #region "form"

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        #endregion

        #region "Menu"

        /// <summary>
        /// Evento para abrir um ficheiro e carrega-lo no interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abrirFicheirocsvToolStripMenuItem_Click(object sender, EventArgs e)
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
            abrirFicheirocsvToolStripMenuItem_Click(sender, e);
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
                                           where linha.Index < row.Index + pesquisaLinhasDepois
                                                 && linha.Index > row.Index - pesquisaLinhasAntes
                                                 && row.Cells[0].Value.Equals(linha.Cells[0].Value)
                                                 && row.Cells[4].Value != null
                                                 && !row.Cells[4].Value.Equals(linha.Cells[4].Value)
                                           select linha).ToList();  

                    // lista que vai ter todos os fundos com ID igual ao da linha que está a ser analisada
                    // mas que não tem código
                    var campoVazio = (from linha2 in linhas
                                      where linha2.Index < row.Index + pesquisaLinhasDepois
                                            && linha2.Index > row.Index - pesquisaLinhasAntes
                                            && row.Cells[0].Value.Equals(linha2.Cells[0].Value)
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

                    lblProgressoCount.Text = (row.Index+1) + " de " + rowCount;
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

    }
}
