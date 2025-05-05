namespace Models
{
    public class Avaliacao
    {
        public int _Id { get; set; }
        public int _Nota { get; set; }
        public string _Comentario { get; set; }
        public DateTime _Data { get; set; } = DateTime.Now;
        public int _ChamadoId { get; set; }
        public int _UsuarioId { get; set; }
        
        // Relacionamentos
        public Chamado Chamado { get; set; }
        public Usuario Usuario { get; set; }
    }
}