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
    public partial class MostrarClientes : Form
    {
        public MostrarClientes()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void MostrarClientes_Load(object sender, EventArgs e)
        {
            DataSet ptDataset = new DataSet();
            DBInit.init();

            string sql = "MostrarTodosClientes";
            //SqlCommand com = new SqlCommand(sql, sc);

            SqlCommand cmd = new SqlCommand(sql, DBInit.getmyConn());


            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ptDataset);
            dataGridView1.DataSource = ptDataset.Tables[0];
            DBInit.close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // editar
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                //cc:
                EditarCliente f = new EditarCliente(row.Cells[0].Value.ToString());
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                //cc+cliente:
                HistoricoCliente f = new HistoricoCliente(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                f.Show();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                button1.Visible = Visible;
                button2.Visible = Visible;
            }
        }
    }
}
