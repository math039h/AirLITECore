using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirLiteApiCore.Model;
using Microsoft.EntityFrameworkCore;

namespace AirLiteApiCore.Broker
{
    public class StorageBroker : DbContext
    {
        public StorageBroker(DbContextOptions<StorageBroker> options)
            :base(options)
        {
            this.Database.Migrate();
        }

        public DbSet<Data> Datas { get; set; }

    }
}
