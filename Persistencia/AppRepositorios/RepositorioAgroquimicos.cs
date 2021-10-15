using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public class RepositorioAgroquimicos : IRepositorioAgroquimicos
    {
        private readonly AppContext _appContext; 

        public RepositorioAgroquimicos(AppContext appContext) 
        {
            _appContext = appContext;
        }   

                

        Agroquimicos IRepositorioAgroquimicos.AddAgroquimicos(Agroquimicos agroquimicos)
        {
            var agroquimicoAdicionado = _appContext.Agroquimicos.Add(agroquimicos);
            _appContext.SaveChanges();
            return agroquimicoAdicionado.Entity;
        }

        Agroquimicos IRepositorioAgroquimicos.UpdateAgroquimicos(Agroquimicos agroquimicos)
        {
            var agroquimicoAdicionado = _appContext.Agroquimicos.FirstOrDefault(c => c.Id == agroquimicos.Id);
            if (agroquimicoAdicionado!= null)
            {
                agroquimicoAdicionado.nombreProducto = agroquimicos.nombreProducto;
                agroquimicoAdicionado.cantidadEntrada = agroquimicos.cantidadEntrada;
                agroquimicoAdicionado.cantidadSalida = agroquimicos.cantidadSalida;
                agroquimicoAdicionado.cantidadBodega = agroquimicos.cantidadBodega;
                agroquimicoAdicionado.precioCompra = agroquimicos.precioCompra;
                agroquimicoAdicionado.fechaCompra = agroquimicos.fechaCompra;
                agroquimicoAdicionado.tipo = agroquimicos.tipo;

                _appContext.SaveChanges();                                        
            }
            return agroquimicoAdicionado;
                    
        }

        void IRepositorioAgroquimicos.DeleteAgroquimicos(int idInsumos )
        {
            var agroquimicoAdicionado = _appContext.Agroquimicos.FirstOrDefault(c => c.Id == idInsumos);
            if (agroquimicoAdicionado == null)
            return;
            _appContext.Agroquimicos.Remove(agroquimicoAdicionado);
            _appContext.SaveChanges();   
        }

        Agroquimicos IRepositorioAgroquimicos.GetAgroquimicos(int  idInsumos)
        {
            return _appContext.Agroquimicos.FirstOrDefault(c => c.Id == idInsumos);   
        }

        IEnumerable<Agroquimicos> IRepositorioAgroquimicos.GetAllAgroquimicos()
        {
            return _appContext.Agroquimicos;
        }
               
    }
}