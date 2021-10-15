using System;

namespace Dominio.Entidades
{
    public class LoteFinca
    {
        public string Id {get;set;}
        public int numeroLote {get;set;}
        public int cantidadPlantas{get;set;}
        public string tipoCultivo {get;set;}
        public string estadoCultivo {get;set;} 
    }
}