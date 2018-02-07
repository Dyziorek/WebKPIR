using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebKPIR.Model.Ksiega;

    public class KsiegaContext : DbContext
    {
        public KsiegaContext (DbContextOptions<KsiegaContext> options)
            : base(options)
        {
        }

        public DbSet<WebKPIR.Model.Ksiega.Dziennik> Dziennik { get; set; }
    }
