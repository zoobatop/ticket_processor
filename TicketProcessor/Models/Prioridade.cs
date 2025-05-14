using TicketProcessor.Models;

namespace TicketProcessor.Models
{
    public class Prioridade
    {
        public int _Id { get; set; }
        public string _Nome { get; set; }
        
        // Relacionamentos
        // public ICollection<Chamado> Chamados { get; set; }
    }
}