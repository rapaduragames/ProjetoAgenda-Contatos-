namespace ProjetoAgendaForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb1Nome = new Label();
            lb1Email = new Label();
            lb1Nascimento = new Label();
            lb1Tipo = new Label();
            lb1Telefone = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTipo = new TextBox();
            txtTelefone = new TextBox();
            dtpNascimento = new DateTimePicker();
            chkPrincipal = new CheckBox();
            btnAddTelefone = new Button();
            lstTelefones = new ListBox();
            btnAddContato = new Button();
            btnPesquisar = new Button();
            btnAlterar = new Button();
            btnRemover = new Button();
            btnListar = new Button();
            btnSair = new Button();
            dgvContatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // lb1Nome
            // 
            lb1Nome.AutoSize = true;
            lb1Nome.Location = new Point(79, 103);
            lb1Nome.Name = "lb1Nome";
            lb1Nome.Size = new Size(43, 15);
            lb1Nome.TabIndex = 0;
            lb1Nome.Text = "Nome:";
            // 
            // lb1Email
            // 
            lb1Email.AutoSize = true;
            lb1Email.Location = new Point(79, 143);
            lb1Email.Name = "lb1Email";
            lb1Email.Size = new Size(39, 15);
            lb1Email.TabIndex = 1;
            lb1Email.Text = "Email:";
            // 
            // lb1Nascimento
            // 
            lb1Nascimento.AutoSize = true;
            lb1Nascimento.Location = new Point(48, 187);
            lb1Nascimento.Name = "lb1Nascimento";
            lb1Nascimento.Size = new Size(74, 15);
            lb1Nascimento.TabIndex = 2;
            lb1Nascimento.Text = "Nascimento:";
            // 
            // lb1Tipo
            // 
            lb1Tipo.AutoSize = true;
            lb1Tipo.Location = new Point(26, 234);
            lb1Tipo.Name = "lb1Tipo";
            lb1Tipo.Size = new Size(96, 15);
            lb1Tipo.TabIndex = 3;
            lb1Tipo.Text = "Tipo de Telefone:";
            // 
            // lb1Telefone
            // 
            lb1Telefone.AutoSize = true;
            lb1Telefone.Location = new Point(64, 300);
            lb1Telefone.Name = "lb1Telefone";
            lb1Telefone.Size = new Size(54, 15);
            lb1Telefone.TabIndex = 4;
            lb1Telefone.Text = "Número:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 49);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 5;
            label6.Text = "contatos incriveis ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(150, 97);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(150, 231);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(200, 23);
            txtTipo.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(150, 292);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(200, 23);
            txtTelefone.TabIndex = 9;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(150, 181);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(200, 23);
            dtpNascimento.TabIndex = 11;
            // 
            // chkPrincipal
            // 
            chkPrincipal.AutoSize = true;
            chkPrincipal.Location = new Point(361, 294);
            chkPrincipal.Name = "chkPrincipal";
            chkPrincipal.Size = new Size(119, 19);
            chkPrincipal.TabIndex = 12;
            chkPrincipal.Text = "Telefone Principal";
            chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnAddTelefone
            // 
            btnAddTelefone.Location = new Point(147, 336);
            btnAddTelefone.Name = "btnAddTelefone";
            btnAddTelefone.Size = new Size(203, 23);
            btnAddTelefone.TabIndex = 13;
            btnAddTelefone.Text = "Adicionar Telefone";
            btnAddTelefone.UseVisualStyleBackColor = true;
            // 
            // lstTelefones
            // 
            lstTelefones.FormattingEnabled = true;
            lstTelefones.ItemHeight = 15;
            lstTelefones.Location = new Point(48, 395);
            lstTelefones.Name = "lstTelefones";
            lstTelefones.Size = new Size(527, 154);
            lstTelefones.TabIndex = 14;
            // 
            // btnAddContato
            // 
            btnAddContato.Location = new Point(688, 95);
            btnAddContato.Name = "btnAddContato";
            btnAddContato.Size = new Size(71, 63);
            btnAddContato.TabIndex = 15;
            btnAddContato.Text = "Adicionar Contato ";
            btnAddContato.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(688, 164);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(71, 60);
            btnPesquisar.TabIndex = 16;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(688, 230);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(71, 60);
            btnAlterar.TabIndex = 17;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(765, 103);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(71, 60);
            btnRemover.TabIndex = 18;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(765, 169);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(71, 60);
            btnListar.TabIndex = 19;
            btnListar.Text = "Listar Contatos ";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(765, 235);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(71, 60);
            btnSair.TabIndex = 20;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(632, 395);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.ReadOnly = true;
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.Size = new Size(240, 150);
            dgvContatos.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(dgvContatos);
            Controls.Add(btnSair);
            Controls.Add(btnListar);
            Controls.Add(btnRemover);
            Controls.Add(btnAlterar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAddContato);
            Controls.Add(lstTelefones);
            Controls.Add(btnAddTelefone);
            Controls.Add(chkPrincipal);
            Controls.Add(dtpNascimento);
            Controls.Add(txtTelefone);
            Controls.Add(txtTipo);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(lb1Telefone);
            Controls.Add(lb1Tipo);
            Controls.Add(lb1Nascimento);
            Controls.Add(lb1Email);
            Controls.Add(lb1Nome);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de Contatos";
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1Nome;
        private Label lb1Email;
        private Label lb1Nascimento;
        private Label lb1Tipo;
        private Label lb1Telefone;
        private Label label6;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTipo;
        private TextBox txtTelefone;
        private DateTimePicker dtpNascimento;
        private CheckBox chkPrincipal;
        private Button btnAddTelefone;
        private ListBox lstTelefones;
        private Button btnAddContato;
        private Button btnPesquisar;
        private Button btnAlterar;
        private Button btnRemover;
        private Button btnListar;
        private Button btnSair;
        private DataGridView dgvContatos;
    }
}
