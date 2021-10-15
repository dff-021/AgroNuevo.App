using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;


namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    
        
    public class RepositorioDatosFinca : IRepositorioDatosFinca
    {
        private readonly AppContext _appContext; 

        public RepositorioDatosFinca(AppContext appContext) 
        {
            _appContext = appContext;
        }   

                

        DatosFinca IRepositorioDatosFinca.AddDatosFinca(DatosFinca datosfinca)
        {
            var datosfincaAdicionada = _appContext.DatosFinca.Add(datosfinca);
            _appContext.SaveChanges();
            return datosfincaAdicionada.Entity;
        }

        DatosFinca IRepositorioDatosFinca.UpdateDatosFinca(DatosFinca datosfinca)
        {
            var datosfincaEncontrada = _appContext.DatosFinca.FirstOrDefault(c => c.Id == datosfinca.Id);
            if (datosfincaEncontrada!= null)
            {
                datosfincaEncontrada.nombreFinca = datosfinca.nombreFinca;
                datosfincaEncontrada.ubicacion = datosfinca.ubicacion;
                datosfincaEncontrada.lotesDesignados = datosfinca.lotesDesignados;
                datosfincaEncontrada.cantidadProductoSembrado = datosfinca.cantidadProductoSembrado;             
                _appContext.SaveChanges();                                        
            }
            return datosfincaEncontrada;
                    
        }

        void IRepositorioDatosFinca.DeleteDatosFinca(int idDatosFinca )
        {
            var datosfincaEncontrada = _appContext.DatosFinca.FirstOrDefault(c => c.Id == idDatosFinca);
            if (datosfincaEncontrada == null)
            return;
            _appContext.DatosFinca.Remove(datosfincaEncontrada);
            _appContext.SaveChanges();   
        }

        DatosFinca IRepositorioDatosFinca.GetDatosFinca(int  idDatosFinca)
        {
            return _appContext.DatosFinca.FirstOrDefault(c => c.Id == idDatosFinca);   
        }

        IEnumerable<DatosFinca> IRepositorioDatosFinca.GetAllDatosFinca()
        {
            return _appContext.DatosFinca;
        }
    }       
    
}