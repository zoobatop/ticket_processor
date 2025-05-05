namespace Models
{
    public class TipoUsuario
    {
        public int TipoId { get; set; }
        public string TipoNome { get; set; }
        
        public ICollection<Usuario> Usuarios { get; set; }
    }
}