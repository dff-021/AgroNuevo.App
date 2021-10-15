using System;
using System.Collections.Generic;
using AgroNuevo.App.Persistencia.AppRepositorios;
using Dominio.Entidades;


namespace Consola
{
    class Program
    {
        //private static IRepositorioDatosFinca _repoDatosFinca = new RepositorioDatosFinca(new Persistencia.AppContext());
        //private static IRepositorioAgroquimico _repoAgroquimico = new RepositorioAgroquimicos(new Persistencia.AppContext());
        //private static IRepositorioRegistro _repoRegistro = new RepositorioRegistro(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EF!");
            
            //AddDatosFinca();
            //AddAgroquimicos();          
            //AddRegistro();
            //BuscarRegistro(2);
            

        }
    /*
        private static void AddRegistro()
        {
            var registro = new Registro
            {
                id = "75085830",
                Nombres = "Jose Ormilson",
                Contraseña = "2465",
               
            };
            _repoRegistro.AddRegistro(registro);

        }
        
        private static void BuscarRegistro(int idRegistro)
        {
            var registro = _repoRegistro.GetRegistro(idRegistro);
            Console.WriteLine(registro.Nombres + " " + registro.Contraseña);
        }
        
        private static void AddAgroquimicos()
        {
            var agroquimicos = new Agroquimicos()
            {
                idInsumos = "2233",
                nombreProducto = "Arroz",
                cantidadEntrada = "30 Kilos",
                cantidadSalida = "20 kilos",
                cantidadBodega = "100 Kilos",
                precioCompra = "250000",
                fechaCompra = "12/10/2021",
                tipo = "Semillas",
                numeroAgroquimico = "CI02",
                ingredienteActivo = "Mancozeb"
            };
            _repoAgroquimico.AddAgroquimicos(Agroquimicos);
        } 

        
        private static void AddDatosFinca()
        {
            var datosfinca = new DatosFinca()
            {
                nombreFinca = "La Esmeralda",
                ubicacion = "Caldas",
                lotesDesignados = "2",
                cantidadProductoSembrado = "1"
            };
            _repoDatosFinca.AddDatosFinca(DatosFinca);
        }               
    */
    }
}

