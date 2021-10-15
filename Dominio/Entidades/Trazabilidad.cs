using System;

namespace Dominio.Entidades
{
    public class Trazabilidad
    {
        public int Id {get;set;}
        public string lugarProduccion {get;set;}
        public string fechaProduccion {get;set;}
        public string encargado {get;set;} 
    }
}