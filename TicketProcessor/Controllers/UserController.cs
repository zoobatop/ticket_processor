using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketProcessor.Data;
using TicketProcessor.Models;
using TicketProcessor.Utils;

namespace User.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context; // Use seu contexto real (DatabaseContext)

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsers()
        {
            return await _context.Usuarios.ToListAsync(); // Ajuste para o nome correto do DbSet
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUser(int id)
        {
            var user = await _context.Usuarios.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUser(Usuario user)
        {
            try
            {
                // Valores padrões
                user._Senha = SecurityUtils.HashSHA256(user._Senha);
                user._Status = 'S'; // Ativo
                user._TipoId = 2;

                if (user._DataNasc.Kind == DateTimeKind.Unspecified)
                {
                    user._DataNasc = DateTime.SpecifyKind(user._DataNasc, DateTimeKind.Utc);
                }

                _context.Usuarios.Add(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction(
                    nameof(GetUser),
                    new { id = user._Id },
                    new
                    {
                        Message = "Usuário criado com sucesso",
                        User = user,
                        Links = new
                        {
                            Self = Url.Action(nameof(GetUser), new { id = user._Id }),
                            AllUsers = Url.Action("GetUsers") // Se você tiver esse endpoint
                        }
                    });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar o usuário: {ex}");
                return StatusCode(500, new
                {
                    Message = "Erro ao criar usuário",
                    Error = ex.Message,
                    Details = ex.InnerException?.Message
                });
            }
        }

        [HttpGet("ping")]
        public string Test()
        {
            return "pong!";
        }
    }
}