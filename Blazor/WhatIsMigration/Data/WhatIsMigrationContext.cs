using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WhatIsMigration.Models;

namespace WhatIsMigration.Data
{
    public class WhatIsMigrationContext : DbContext
    {
        public WhatIsMigrationContext (DbContextOptions<WhatIsMigrationContext> options)
            : base(options)
        {
        }

        public DbSet<WhatIsMigration.Models.Human> Human { get; set; } = default!;
    }
}
