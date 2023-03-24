using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EasyToDoApi.Data
{
    public class EasyToDoApiContext : DbContext
    {
        public EasyToDoApiContext (DbContextOptions<EasyToDoApiContext> options)
            : base(options)
        {
        }

        public DbSet<EasyToDoApi.Data.TodoItem> TodoItem { get; set; } = default!;
    }
}
