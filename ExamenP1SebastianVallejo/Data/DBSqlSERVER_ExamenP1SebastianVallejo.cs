using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenP1SebastianVallejo.Models;

    public class DBSqlSERVER_ExamenP1SebastianVallejo : DbContext
    {
        public DBSqlSERVER_ExamenP1SebastianVallejo (DbContextOptions<DBSqlSERVER_ExamenP1SebastianVallejo> options)
            : base(options)
        {
        }

        public DbSet<ExamenP1SebastianVallejo.Models.Cliente> Cliente { get; set; } = default!;

public DbSet<ExamenP1SebastianVallejo.Models.Reserva> Reserva { get; set; } = default!;

public DbSet<ExamenP1SebastianVallejo.Models.PlanDeRecompensas> PlanDeRecompensas { get; set; } = default!;
    }
