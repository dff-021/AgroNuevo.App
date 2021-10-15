using System;

namespace Dominio.Entidades
{
    public class Insumos
    {
        public int Id {get;set;}
        public string nombreProducto {get;set;}
        public int cantidadEntrada{get;set;}
        public int cantidadSalida {get;set;}
        public int cantidadBodega {get;set;}
        public int precioCompra {get;set;}
        public string fechaCompra {get;set;}
        public string tipo {get;set;}
    }
}