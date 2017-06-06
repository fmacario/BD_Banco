namespace BD_Banco
{
    partial class CriarConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empregadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarEmpregadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEmpregadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarCartãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCartõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarOperaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarOperaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEmpréstimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Cartão Cidadão";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de conta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ordem",
            "Prazo"});
            this.comboBox1.Location = new System.Drawing.Point(182, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(521, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Juros";
            this.label3.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saldo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Criar Conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(182, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Administrador";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.empregadosToolStripMenuItem,
            this.contasToolStripMenuItem,
            this.cartõesToolStripMenuItem,
            this.operaçõesToolStripMenuItem,
            this.empréstimoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarClienteToolStripMenuItem,
            this.mostrarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // criarClienteToolStripMenuItem
            // 
            this.criarClienteToolStripMenuItem.Name = "criarClienteToolStripMenuItem";
            this.criarClienteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.criarClienteToolStripMenuItem.Text = "Criar Cliente";
            // 
            // mostrarClientesToolStripMenuItem
            // 
            this.mostrarClientesToolStripMenuItem.Name = "mostrarClientesToolStripMenuItem";
            this.mostrarClientesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.mostrarClientesToolStripMenuItem.Text = "Mostrar Clientes";
            // 
            // empregadosToolStripMenuItem
            // 
            this.empregadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarEmpregadoToolStripMenuItem,
            this.mostrarEmpregadosToolStripMenuItem});
            this.empregadosToolStripMenuItem.Name = "empregadosToolStripMenuItem";
            this.empregadosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.empregadosToolStripMenuItem.Text = "Empregados";
            // 
            // criarEmpregadoToolStripMenuItem
            // 
            this.criarEmpregadoToolStripMenuItem.Name = "criarEmpregadoToolStripMenuItem";
            this.criarEmpregadoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.criarEmpregadoToolStripMenuItem.Text = "Criar Empregado";
            // 
            // mostrarEmpregadosToolStripMenuItem
            // 
            this.mostrarEmpregadosToolStripMenuItem.Name = "mostrarEmpregadosToolStripMenuItem";
            this.mostrarEmpregadosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.mostrarEmpregadosToolStripMenuItem.Text = "Mostrar Empregados";
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarContaToolStripMenuItem,
            this.verContasToolStripMenuItem});
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.contasToolStripMenuItem.Text = "Contas";
            // 
            // criarContaToolStripMenuItem
            // 
            this.criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            this.criarContaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.criarContaToolStripMenuItem.Text = "Criar Conta";
            // 
            // verContasToolStripMenuItem
            // 
            this.verContasToolStripMenuItem.Name = "verContasToolStripMenuItem";
            this.verContasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.verContasToolStripMenuItem.Text = "Mostrar Contas";
            // 
            // cartõesToolStripMenuItem
            // 
            this.cartõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarCartãoToolStripMenuItem,
            this.mostrarCartõesToolStripMenuItem});
            this.cartõesToolStripMenuItem.Name = "cartõesToolStripMenuItem";
            this.cartõesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.cartõesToolStripMenuItem.Text = "Cartões";
            // 
            // criarCartãoToolStripMenuItem
            // 
            this.criarCartãoToolStripMenuItem.Name = "criarCartãoToolStripMenuItem";
            this.criarCartãoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.criarCartãoToolStripMenuItem.Text = "Criar Cartão";
            // 
            // mostrarCartõesToolStripMenuItem
            // 
            this.mostrarCartõesToolStripMenuItem.Name = "mostrarCartõesToolStripMenuItem";
            this.mostrarCartõesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mostrarCartõesToolStripMenuItem.Text = "Mostrar Cartões";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarOperaçãoToolStripMenuItem,
            this.mostrarOperaçõesToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // criarOperaçãoToolStripMenuItem
            // 
            this.criarOperaçãoToolStripMenuItem.Name = "criarOperaçãoToolStripMenuItem";
            this.criarOperaçãoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.criarOperaçãoToolStripMenuItem.Text = "Criar Operação";
            // 
            // mostrarOperaçõesToolStripMenuItem
            // 
            this.mostrarOperaçõesToolStripMenuItem.Name = "mostrarOperaçõesToolStripMenuItem";
            this.mostrarOperaçõesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.mostrarOperaçõesToolStripMenuItem.Text = "Mostrar Operações";
            // 
            // empréstimoToolStripMenuItem
            // 
            this.empréstimoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoEmpréstimoToolStripMenuItem,
            this.mostrarEmpréstimosToolStripMenuItem});
            this.empréstimoToolStripMenuItem.Name = "empréstimoToolStripMenuItem";
            this.empréstimoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.empréstimoToolStripMenuItem.Text = "Empréstimo";
            // 
            // novoEmpréstimoToolStripMenuItem
            // 
            this.novoEmpréstimoToolStripMenuItem.Name = "novoEmpréstimoToolStripMenuItem";
            this.novoEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.novoEmpréstimoToolStripMenuItem.Text = "Novo Empréstimo";
            // 
            // mostrarEmpréstimosToolStripMenuItem
            // 
            this.mostrarEmpréstimosToolStripMenuItem.Name = "mostrarEmpréstimosToolStripMenuItem";
            this.mostrarEmpréstimosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mostrarEmpréstimosToolStripMenuItem.Text = "Mostrar Empréstimos";
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 564);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.Load += new System.EventHandler(this.CriarConta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarEmpregadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEmpregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verContasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarCartãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCartõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarOperaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarOperaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoEmpréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEmpréstimosToolStripMenuItem;
    }
}