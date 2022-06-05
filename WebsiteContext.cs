using HW_Simple_Crud_Cli_App_NadavArania.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Simple_Crud_Cli_App_NadavArania
{
    public class WebsiteContext : DbContext
    {
        public DbSet <Journalist> Journalists { get; set; }
        public DbSet<Field> Fields { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = LAPTOP-LCMU98BH; Database = WebsiteDB; Trusted_Connection = True;");
        }
    }
}
