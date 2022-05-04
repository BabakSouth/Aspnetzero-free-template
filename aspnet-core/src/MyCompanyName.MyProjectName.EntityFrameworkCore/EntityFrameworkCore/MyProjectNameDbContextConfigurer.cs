using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyCompanyName.MyProjectName.EntityFrameworkCore
{
    public static class MyProjectNameDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyProjectNameDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyProjectNameDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}


