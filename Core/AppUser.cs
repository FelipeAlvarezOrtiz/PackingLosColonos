using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PackingLosColonos.Core
{
    public class AppUser : IdentityUser
    {
        [Required,MaxLength(130)]
        public required string Nombre { get; set; }
        public int Rut { get; set; }
        [MaxLength(1)]
        public required string Dv { get; set; }
        public bool Activo { get; set; }
    }
}
