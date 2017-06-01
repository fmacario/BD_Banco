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
        string nCC;
        public HistoricoCliente(string s)
        {
            InitializeComponent();
            this.nCC = s;
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoricoCliente_Load(object sender, EventArgs e)
        {
            DataSet ptDataset = new DataSet();
            DBInit.init();
            

            SqlCommand cmd = new SqlCommand("PesquisaCartoes", DBInit.getmyConn());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nCliente", this.nCC);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ptDataset);
            dataGridView2.DataSource = ptDataset.Tables[0];
            DBInit.close();
        }
    }
}
