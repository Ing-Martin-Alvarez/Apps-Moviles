using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using S5_U2_AC_02.Models;

namespace S5_U2_AC_02.Data
{
    public class S5_U2_AC_02Context : DbContext
    {
        public S5_U2_AC_02Context (DbContextOptions<S5_U2_AC_02Context> options)
            : base(options)
        {
        }

        public DbSet<S5_U2_AC_02.Models.modelo> modelo { get; set; } = default!;
    }
}
