using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;


namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public class RepositorioTrazabilidad : IRepositorioTrazabilidad
    {
        private readonly AppContext _appContext; 

        public RepositorioTrazabilidad(AppContext appContext) 
        {
            _appContext = appContext;
        }   

        Trazabilidad IRepositorioTrazabilidad.AddTrazabilidad(Trazabilidad Trazabilidad)
        {
            var TrazabilidadAdicionada = _appContext.Trazabilidad.Add(Trazabilidad);
            _appContext.SaveChanges();
            return TrazabilidadAdicionada.Entity;
        }

        Trazabilidad IRepositorioTrazabilidad.UpdateTrazabilidad(Trazabilidad Trazabilidad)
        {
            var TrazabilidadEncontrada = _appContext.Trazabilidad.FirstOrDefault(c => c.Id == Trazabilidad.Id);
            if (TrazabilidadEncontrada!= null)
            {
                TrazabilidadEncontrada.lugarProduccion = Trazabilidad.lugarProduccion;
                TrazabilidadEncontrada.fechaProduccion = Trazabilidad.fechaProduccion;
                TrazabilidadEncontrada.encargado  = Trazabilidad.encargado;
                _appContext.SaveChanges();                                        
            }
            return TrazabilidadEncontrada;
                    
        }

        void IRepositorioTrazabilidad.DeleteTrazabilidad(int idTrazabilidad )
        {
            var TrazabilidadEncontrada = _appContext.Trazabilidad.FirstOrDefault(c => c.Id == idTrazabilidad);
            if (TrazabilidadEncontrada == null)
            return;
            _appContext.Trazabilidad.Remove(TrazabilidadEncontrada);
            _appContext.SaveChanges();   
        }

        Trazabilidad IRepositorioTrazabilidad.GetTrazabilidad(int idTrazabilidad)
        {
            return _appContext.Trazabilidad.FirstOrDefault(c => c.Id == idTrazabilidad);   
        }

        IEnumerable<Trazabilidad> IRepositorioTrazabilidad.GetAllTrazabilidad()
        {
            return _appContext.Trazabilidad;
        }
    }       
    
}