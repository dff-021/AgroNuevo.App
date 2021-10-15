using Microsoft.EntityFrameworkCore;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia
{
    public class AppContext : DbContext
    {

        public DbSet<Agroquimicos> Agroquimicos {get; set;}
        public DbSet<Cosecha> Cosechas {get; set;}
        public DbSet<CostoProduccion> CostoProduccion {get; set;}
        public DbSet<Cultivos> Cultivos {get; set;}
        public DbSet<DatosFinca> DatosFinca {get; set;}
        public DbSet<FertilizantesEnmiendas> FertilizantesEnmiendas {get; set;}
        public DbSet<Insumos> Insumos {get; set;}
        public DbSet<ListaLogin> ListaLogin {get; set;}
        public DbSet<LoteFinca> LoteFinca {get; set;} 
        public DbSet<ManoDeObra> ManoDeObra {get; set;} 
        public DbSet<Materiales> Materiales {get; set;} 
        public DbSet<Registro> registros {get; set;} 
        public DbSet<Tecnico> Tecnicos {get; set;} 
        public DbSet<Trazabilidad> Trazabilidad {get; set;} 
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=BDAgro2")
            .EnableSensitiveDataLogging(true);        
        
        }

    }
}