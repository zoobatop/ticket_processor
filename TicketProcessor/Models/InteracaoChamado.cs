using TicketProcessor.Models;

namespace TicketProcessor.Models
{
    public class InteracaoChamado
    {
        public int _Id { get; set; }
        public DateTime _Data { get; set; } = DateTime.Now;
        public string _Texto { get; set; }
        public int _ChamadoId { get; set; }
        public int _UsuarioId { get; set; }
        
        // Relacionamentos
        // public Chamado Chamado { get; set; }
        // public Usuario Usuario { get; set; }
    }
}