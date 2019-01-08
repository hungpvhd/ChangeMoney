using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChangeMoney.Data;

namespace ChangeMoney.Models
{
    public class ChangeMoneyContext : DbContext
    {
        public ChangeMoneyContext (DbContextOptions<ChangeMoneyContext> options)
            : base(options)
        {
        }

        public DbSet<ChangeMoney.Data.ChangeCurrencycs> ChangeCurrencycs { get; set; }
    }
}
