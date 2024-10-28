using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvalucionProgreso1.Models;

    public class Daniel_Diaz_Progreso_1 : DbContext
    {
        public Daniel_Diaz_Progreso_1 (DbContextOptions<Daniel_Diaz_Progreso_1> options)
            : base(options)
        {
        }

        public DbSet<EvalucionProgreso1.Models.Diaz> Diaz { get; set; } = default!;

public DbSet<EvalucionProgreso1.Models.Celular> Celular { get; set; } = default!;
    }
