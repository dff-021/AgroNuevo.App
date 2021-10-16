using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public class RepositorioCostoProduccion : IRepositorioCostoProduccion
    {
        private readonly AppContext _appContext; 

        public RepositorioCostoProduccion(AppContext appContext) 
        {
            _appContext = appContext;
        }   

        CostoProduccion IRepositorioCostoProduccion.AddCostoProduccion(CostoProduccion CostoProduccion)
        {
            var CostoProduccionAdicionada = _appContext.CostoProduccion.Add(CostoProduccion);
            _appContext.SaveChanges();
            return CostoProduccionAdicionada.Entity;
        }

        CostoProduccion IRepositorioCostoProduccion.UpdateCostoProduccion(CostoProduccion CostoProduccion)
        {
            var CostoProduccionEncontrada = _appContext.CostoProduccion.FirstOrDefault(c => c.Id == CostoProduccion.Id);
            if (CostoProduccionEncontrada!= null)
            {
                CostoProduccionEncontrada.Inversion = CostoProduccion.Inversion;
                CostoProduccionEncontrada.Gasto = CostoProduccion.Gasto;
                CostoProduccionEncontrada.Ganancia = CostoProduccion.Ganancia;
                
                _appContext.SaveChanges();                                        
            }
            return CostoProduccionEncontrada;
                    
        }

        void IRepositorioCostoProduccion.DeleteCostoProduccion(int idCostoProduccion )
        {
            var CostoProduccionEncontrada = _appContext.CostoProduccion.FirstOrDefault(c => c.Id == idCostoProduccion);
            if (CostoProduccionEncontrada == null)
            return;
            _appContext.CostoProduccion.Remove(CostoProduccionEncontrada);
            _appContext.SaveChanges();   
        }

        CostoProduccion IRepositorioCostoProduccion.GetCostoProduccion(int idCostoProduccion)
        {
            return _appContext.CostoProduccion.FirstOrDefault(c => c.Id == idCostoProduccion);   
        }

        IEnumerable<CostoProduccion> IRepositorioCostoProduccion.GetAllCostoProduccion()
        {
            return _appContext.CostoProduccion;
        }
    }
}