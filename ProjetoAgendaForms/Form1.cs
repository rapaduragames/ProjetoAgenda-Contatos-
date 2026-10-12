using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoAgendaForms
{
    public partial class Form1 : Form
    {
        private Contatos agenda = new Contatos();
        private List<Telefone> telefonesTemporarios = new List<Telefone>();
        private Contato contatoSelecionado = null;

        public Form1()
        {
            InitializeComponent();

            dtpNascimento.Format = DateTimePickerFormat.Custom;
            dtpNascimento.CustomFormat = "dd/MM/yyyy";

            dgvContatos.ReadOnly = true;
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.MultiSelect = false;
            dgvContatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContatos.AllowUserToAddRows = false;

            if (dgvContatos.Columns.Count == 0)
            {
                dgvContatos.Columns.Add("Nome", "Nome");
                dgvContatos.Columns.Add("Email", "E-mail");
                dgvContatos.Columns.Add("Nascimento", "Nascimento");
                dgvContatos.Columns.Add("Idade", "Idade");
                dgvContatos.Columns.Add("TelefonePrincipal", "Telefone principal");
            }

            btnAddContato.Click += btnAdicionar_Click;
            btnPesquisar.Click += btnPesquisar_Click;
            btnAlterar.Click += btnAlterar_Click;
            btnRemover.Click += btnRemover_Click;
            btnListar.Click += btnListar_Click;
            btnSair.Click += btnSair_Click;
            btnAddTelefone.Click += btnAdicionarTelefone_Click;
            dgvContatos.SelectionChanged += dgvContatos_SelectionChanged;

            AtualizarLista();
        }

        private void btnAdicionarTelefone_Click(object sender, EventArgs e)
        {
            string tipo = txtTipo.Text.Trim();
            string numero = txtTelefone.Text.Trim();

            if (tipo == "" || numero == "")
            {
                MessageBox.Show("Preencha o tipo e o número do telefone.");
                return;
            }

            bool principal = chkPrincipal.Checked;

            if (principal)
            {
                foreach (Telefone telefone in telefonesTemporarios)
                    telefone.setPrincipal(false);
            }

            Telefone novoTelefone = new Telefone(tipo, numero, principal);
            telefonesTemporarios.Add(novoTelefone);

            AtualizarTelefones();

            txtTipo.Clear();
            txtTelefone.Clear();
            chkPrincipal.Checked = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (nome == "" || email == "")
            {
                MessageBox.Show("Preencha o nome e o e-mail.");
                return;
            }

            DateTime nascimento = dtpNascimento.Value.Date;

            if (nascimento > DateTime.Today)
            {
                MessageBox.Show("A data de nascimento não pode ser futura.");
                return;
            }

            Contato busca = new Contato(email, "", new Data(1, 1, 2000));

            if (agenda.pesquisar(busca) != null)
            {
                MessageBox.Show("Já existe um contato com esse e-mail.");
                return;
            }

            Contato contato = new Contato(
                email,
                nome,
                new Data(nascimento.Day, nascimento.Month, nascimento.Year)
            );

            foreach (Telefone telefone in telefonesTemporarios)
            {
                contato.adicionarTelefone(
                    new Telefone(
                        telefone.getTipo(),
                        telefone.getNumero(),
                        telefone.getPrincipal()
                    )
                );
            }

            if (agenda.adicionar(contato))
            {
                MessageBox.Show("Contato cadastrado com sucesso!");
                LimparCampos();
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o contato.");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (email == "")
            {
                MessageBox.Show("Digite o e-mail para pesquisar.");
                return;
            }

            Contato busca = new Contato(email, "", new Data(1, 1, 2000));
            Contato encontrado = agenda.pesquisar(busca);

            if (encontrado == null)
            {
                contatoSelecionado = null;
                MessageBox.Show("Contato não encontrado.");
                return;
            }

            contatoSelecionado = encontrado;

            PreencherCampos(encontrado);
            SelecionarContatoNaLista(encontrado);

            MessageBox.Show(encontrado.ToString(), "Contato encontrado");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato na lista ou pesquise pelo e-mail.");
                return;
            }

            string nome = txtNome.Text.Trim();

            if (nome == "")
            {
                MessageBox.Show("O nome não pode ficar vazio.");
                return;
            }

            DateTime nascimento = dtpNascimento.Value.Date;

            if (nascimento > DateTime.Today)
            {
                MessageBox.Show("A data de nascimento não pode ser futura.");
                return;
            }

            contatoSelecionado.setNome(nome);

            contatoSelecionado.setDtNasc(
                new Data(nascimento.Day, nascimento.Month, nascimento.Year)
            );

            if (agenda.alterar(contatoSelecionado))
            {
                MessageBox.Show("Contato alterado com sucesso!");
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Não foi possível alterar o contato.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato para remover.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente remover " + contatoSelecionado.getNome() + "?",
                "Confirmar remoção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                if (agenda.remover(contatoSelecionado))
                {
                    MessageBox.Show("Contato removido com sucesso!");
                    LimparCampos();
                    AtualizarLista();
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            contatoSelecionado = null;
            LimparCampos();
            AtualizarLista();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvContatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContatos.SelectedRows.Count == 0)
                return;

            DataGridViewRow linha = dgvContatos.SelectedRows[0];

            if (linha.Tag is Contato contato)
            {
                contatoSelecionado = contato;
                PreencherCampos(contato);
            }
        }

        private void AtualizarLista()
        {
            dgvContatos.Rows.Clear();

            foreach (Contato contato in agenda.getAgenda())
            {
                int indice = dgvContatos.Rows.Add(
                    contato.getNome(),
                    contato.getEmail(),
                    contato.getDtNasc().ToString(),
                    contato.getIdade(),
                    contato.getTelefonePrincipal()
                );

                dgvContatos.Rows[indice].Tag = contato;
            }
        }

        private void PreencherCampos(Contato contato)
        {
            txtNome.Text = contato.getNome();
            txtEmail.Text = contato.getEmail();

            dtpNascimento.Value = new DateTime(
                contato.getDtNasc().getAno(),
                contato.getDtNasc().getMes(),
                contato.getDtNasc().getDia()
            );

            telefonesTemporarios.Clear();

            foreach (Telefone telefone in ObterTelefones(contato))
                telefonesTemporarios.Add(
                    new Telefone(
                        telefone.getTipo(),
                        telefone.getNumero(),
                        telefone.getPrincipal()
                    )
                );

            AtualizarTelefones();
        }

        private IEnumerable<Telefone> ObterTelefones(Contato contato)
        {
            // A lista de telefones é mantida dentro de Contato.
            // Para exibi-la aqui, use o método getTelefones()
            // que será adicionado à classe Contato.
            return contato.getTelefones();
        }

        private void SelecionarContatoNaLista(Contato contato)
        {
            foreach (DataGridViewRow linha in dgvContatos.Rows)
            {
                if (ReferenceEquals(linha.Tag, contato))
                {
                    linha.Selected = true;

                    if (linha.Cells.Count > 0)
                        dgvContatos.CurrentCell = linha.Cells[0];

                    return;
                }
            }
        }

        private void AtualizarTelefones()
        {
            lstTelefones.Items.Clear();

            foreach (Telefone telefone in telefonesTemporarios)
                lstTelefones.Items.Add(telefone.ToString());
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTipo.Clear();
            txtTelefone.Clear();

            dtpNascimento.Value = DateTime.Today;
            chkPrincipal.Checked = false;

            telefonesTemporarios.Clear();
            AtualizarTelefones();

            contatoSelecionado = null;
            dgvContatos.ClearSelection();
        }
    }
}