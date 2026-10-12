
namespace ProjetoAgendaForms
{
    internal class Telefone
    {
        private string tipo;
        private string numero;
        private bool principal;

        public Telefone(string tipo, string numero, bool principal)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.principal = principal;
        }

        public string getTipo()
        {
            return tipo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string getNumero()
        {
            return numero;
        }

        public void setNumero(string numero)
        {
            this.numero = numero;
        }

        public bool getPrincipal()
        {
            return principal;
        }

        public void setPrincipal(bool principal)
        {
            this.principal = principal;
        }

        public override string ToString()
        {
            string marcador = principal ? " (Principal)" : "";
            return $"{tipo}: {numero}{marcador}";
        }
    }
}
