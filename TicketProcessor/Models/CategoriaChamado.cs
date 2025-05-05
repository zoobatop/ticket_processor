namespace Models
{
    public class CategoriaChamado
    {
        public int _Id { get; set; }
        public string _Nome { get; set; }
        
        // Relacionamentos
        public ICollection<Chamado> Chamados { get; set; }
    }
}