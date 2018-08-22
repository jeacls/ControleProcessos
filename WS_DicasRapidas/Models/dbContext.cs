using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Web;


namespace WS_DicasRapidas.Models
{
    public class objDbContext : DbContext
    {
        //public objDbContext() : base("objDbContext") { }
        public objDbContext() : base("objDbContextSQL") { }        
        //public objDbContext() : base("objDbContextESL") { }
        //public objDbContext() : base("objDbContextSQLESL") { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<TipoDica> TipoDicas { get; set; }
        public DbSet <Dica> Dicas { get; set; }

        //Usado para desabilitar a pluralização automatica das tabelas
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {            
            base.OnModelCreating(dbModelBuilder);
            
            //string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //path = Environment.CurrentDirectory;
            Database.SetInitializer<objDbContext>(null);            
            //var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyContext>(modelBuilder);
            //Database.SetInitializer<objDbContext>(IDatabaseInitializer<sqliteConnectionInitializer>);
            //Database.Connection.ConnectionString = @"Driver={SQLite3 ODBC Driver};DBQ=C:\Users\joliveira\Google Drive\Diversos\project\WS_DicasRapidas\BD\dtbDica.db";            
            //Database.Connection.ConnectionString = @"Data Source=C:\Users\joliveira\Google Drive\Diversos\project\WS_DicasRapidas\WS_DicasRapidas\Dados\dtbDica.db;";
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();            
        }
    }
}