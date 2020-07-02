using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.RoomService.Data
{
    public class DbContext : IdentityDbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Sala> Salas { get; set; }
    }
}
