using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD_Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void criarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarCliente f = new AdicionarCliente();
            f.Show();
            //this.Hide();
        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarClientes f = new MostrarClientes();
            f.Show();
            //this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

    public class DBInit
    {
        private static SqlConnection connection;

        private static string getConnection()
        {
            return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Filipe\Desktop\UA\3ano\bd\Projeto\BD_Banco\BD_Banco\banco2.mdf; Integrated Security = True; Connect Timeout = 30";
        }
        public static SqlConnection getmyConn()
        {
            return connection;
        }
        public static void close()
        {
            connection.Close();
        }

        public static bool init()
        {
            try { connection = new SqlConnection(getConnection()); }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de ligação à base de dados");
                Console.Out.WriteLine(ex);
                return false;
            }

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de ligação à base de dados");
                Console.Out.WriteLine(ex);
                return false;
            }

            return true;
        }
    }
}
