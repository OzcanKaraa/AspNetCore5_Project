using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP - NVPFKAI\\SQLEXPRESS;database=CoreProjeDB;integrated security=true");
        }

        public int MyProperty { get; set; }
    }
}

//Context class : 1- DB yapilandirma baglanti stringi  2-DB yansitilacak olan Tablolari tutan class
                  
                   
