
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace Infra
{
    public class GestaoContextFactory //: IDesignTimeDbContextFactory<GestaoContext>
    {
        //public IConfiguration Configuration { get; }

        //public GestaoContext CreateDbContext(string[] args)
        //{
        //    var connection = Configuration["ConexaoMySql:MySqlConnectionString"];
        //    //var optionsBuilder = new DbContextOptionsBuilder<GestaoContext>();
        //    //optionsBuilder.UseMySql(connection, mySqlOptions => mySqlOptions
        //    //        // replace with your Server Version and Type
        //    //        .ServerVersion(new Version(8, 0, 18), ServerType.MySql)
        //    //));

           

        //    return new GestaoContext(optionsBuilder.Options);
        //}
    }
}
