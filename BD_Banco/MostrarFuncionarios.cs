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
    public partial class MostrarFuncionarios : Form
    {
        public MostrarFuncionarios()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
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

        private void mostrarEmpregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFuncionarios f = new MostrarFuncionarios();
            f.Show();
        }

        private void novoEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emprestimo f = new Emprestimo();
            f.Show();
        }

        private void criarOperaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacoes f = new Operacoes();
            f.Show();
        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarConta f = new CriarConta();
            f.Show();
        }
        private void MostrarFuncionarios_Load(object sender, EventArgs e)
        {
            ////////// todos
            DataSet ptDataset = new DataSet();
            DBInit.init();
            SqlCommand cmd = new SqlCommand("MostrarTodosFuncionarios", DBInit.getmyConn());

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ptDataset);
            dataGridView1.DataSource = ptDataset.Tables[0];
            DBInit.close();
            
            /////// bancarios:
            DataSet ptDataset2 = new DataSet();
            DBInit.init();
            SqlCommand cmd2 = new SqlCommand("MostrarTodosFuncionariosGestores", DBInit.getmyConn());

            cmd2.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(ptDataset2);
            dataGridView2.DataSource = ptDataset2.Tables[0];
            DBInit.close();
            
        }

        
    }
}
