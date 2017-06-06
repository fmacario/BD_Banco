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
    public partial class HistoricoCliente : Form
    {
        string nCliente; 
        string nCC;
        public HistoricoCliente(string cc, string nCliente)
        {
            this.nCC = cc;
            this.nCliente = nCliente;
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoricoCliente_Load(object sender, EventArgs e)
        {           
            ////////// CONTAS
            DataSet ptDataset = new DataSet();
            DBInit.init();
            SqlCommand cmd = new SqlCommand("PesquisaContas", DBInit.getmyConn());
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nCC", nCC);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ptDataset);
            dataGridView1.DataSource = ptDataset.Tables[0];
            DBInit.close();

            /////// CARTOES:
            DataSet ptDataset2 = new DataSet();
            DBInit.init();
            SqlCommand cmd2 = new SqlCommand("PesquisaCartoes", DBInit.getmyConn());

            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@nCC", nCC);

            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(ptDataset2);
            dataGridView2.DataSource = ptDataset2.Tables[0];
            DBInit.close();

            /////// HISTORICO:
            DataSet ptDataset3 = new DataSet();
            DBInit.init();
            SqlCommand cmd3 = new SqlCommand("PesquisaOperacoes", DBInit.getmyConn());

            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@nCC", nCC);

            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(ptDataset3);
            dataGridView3.DataSource = ptDataset3.Tables[0];
            DBInit.close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
