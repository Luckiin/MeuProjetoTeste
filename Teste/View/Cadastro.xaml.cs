using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace Teste.View
{
    /// <summary>
    /// Interação lógica para Cadastro.xam
    /// </summary>
    public partial class Cadastro : Page
    {
        public Cadastro()
        {
            InitializeComponent();
        }

       /* private void BtnIncluir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            MySqlDataAdapter da;
            MySqlDataReader dr;

            string strSQL;

            try
            {
                conexao = new MySqlConnection("Server=localhost;" +
                    "Database=db_programa;" +
                    "Uid=Uservisual;" +
                    "Pwd=#visual#;");

                strSQL = "insert into tab_cliente(id, nome) VALUES(@id, @nome)";

                comando = new MySqlCommand(strSQL, conexao);
                //comando.Parameters.AddWithValue("@nome");
            }
            catch(Exception ex)
            {

            }
        }*/

    }
}
