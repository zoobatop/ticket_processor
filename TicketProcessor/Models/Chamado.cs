namespace Models
{
    public class Chamado
    {
        public int _Id { get; set; }
        public DateTime _Data { get; set; }
        public string _Detalhe { get; set; }
        public string _Status { get; set; }
        public int _UsuarioId { get; set; }
        public int _CategoriaId { get; set; }
        public int _PrioridadeId { get; set; }
        
        // Relacionamentos
        public Usuario Usuario { get; set; }
        public CategoriaChamado Categoria { get; set; }
        public Prioridade Prioridade { get; set; }
        public ICollection<InteracaoChamado> Interacoes { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}