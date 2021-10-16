using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public class RepositorioLoteFinca : IRepositorioLoteFinca
    
    {
        private readonly AppContext _appContext; 

        public RepositorioLoteFinca(AppContext appContext) 
        {
            _appContext = appContext;
        }   

        LoteFinca IRepositorioLoteFinca.AddLoteFinca(LoteFinca LoteFinca)
        {
            var LoteFincaAdicionada = _appContext.LoteFinca.Add(LoteFinca);
            _appContext.SaveChanges();
            return LoteFincaAdicionada.Entity;
        }

        LoteFinca IRepositorioLoteFinca.UpdateLoteFinca(LoteFinca LoteFinca)
        {
            var loteFincaEncontrada = _appContext.LoteFinca.FirstOrDefault(c => c.Id == LoteFinca.Id);
            if (loteFincaEncontrada!= null)
            {
                loteFincaEncontrada.numeroLote = LoteFinca.numeroLote;
                loteFincaEncontrada.cantidadPlantas = LoteFinca.cantidadPlantas;
                loteFincaEncontrada.tipoCultivo = LoteFinca.tipoCultivo;
                loteFincaEncontrada.estadoCultivo = LoteFinca.estadoCultivo;             
                _appContext.SaveChanges();                                        
            }
            return loteFincaEncontrada;
                    
        }

        void IRepositorioLoteFinca.DeleteLoteFinca(int idLoteFinca)
        {
            var loteFincaEncontrada = _appContext.LoteFinca.FirstOrDefault(c => c.Id == idLoteFinca);
            if (loteFincaEncontrada == null)
            return;
            _appContext.LoteFinca.Remove(loteFincaEncontrada);
            _appContext.SaveChanges();   
        }

        LoteFinca IRepositorioLoteFinca.GetLoteFinca(int idLoteFinca)
        {
            return _appContext.LoteFinca.FirstOrDefault(c => c.Id == idLoteFinca);   
        }

        IEnumerable<LoteFinca> IRepositorioLoteFinca.GetAllLoteFinca()
        {
            return _appContext.LoteFinca;
        }
    }
}