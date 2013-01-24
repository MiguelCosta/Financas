using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectiveCodes.Source
{
    public static class FuncoesAux
    {

        static public DateTime StringToDateTime(string data)
        {
            try
            {
                int ano = Convert.ToInt32(data.Substring(6, 4));
                int mes = Convert.ToInt32(data.Substring(3, 2));
                int dia = Convert.ToInt32(data.Substring(0, 2));
                return new DateTime(ano, mes, dia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error convert date: " + data + "\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DateTime.Now;
            }

        }


    }
}
