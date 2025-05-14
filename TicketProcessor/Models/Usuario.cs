using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketProcessor.Models
{
    [Table("usuarios")]
    public class Usuario
    {
        [Column("usu_id")]
        [Key]
        public int _Id { get; set; }
        
        [Column("usu_nome")]
        public string _Nome { get; set; }

        [Column("usu_senha")]
        public string _Senha { get; set; }
        
        [Column("usu_email")]
        public string _Email { get; set; }
        
        [Column("usu_cpf")]
        public string _Cpf { get; set; }

        [Column("usu_telefone")]
        public string _Telefone { get; set; }

        [Column("usu_endereco")]
        public string _Endereco { get; set; }

        [Column("usu_datanasc")]
        public DateTime _DataNasc { get; set; }

        [Column("usu_sexo")]
        public char _Sexo { get; set; }

        [Column("usu_status")]
        public char _Status { get; set; }

        [Column("tipo_id")]
        public int _TipoId { get; set; }
        
        // Relacionamentos
        // public TipoUsuario TipoUsuario { get; set; }
        // public ICollection<Chamado> Chamados { get; set; }
        // public ICollection<InteracaoChamado> Interacoes { get; set; }
        // public ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}