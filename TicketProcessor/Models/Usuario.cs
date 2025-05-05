namespace Models
{
    public class Usuario
    {
        public int _Id { get; set; }
        public string _Nome { get; set; }
        public string _Senha { get; set; }
        public string _Email { get; set; }
        public string _Cpf { get; set; }
        public string _Telefone { get; set; }
        public string _Endereco { get; set; }
        public DateTime _DataNasc { get; set; }
        public char _Sexo { get; set; }
        public char _Status { get; set; }
        public int _TipoId { get; set; }
        
        // Relacionamentos
        public TipoUsuario TipoUsuario { get; set; }
        public ICollection<Chamado> Chamados { get; set; }
        public ICollection<InteracaoChamado> Interacoes { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}