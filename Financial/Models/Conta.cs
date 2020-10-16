using System;
using Financial.Models.Enum;
using System.Collections.Generic;
using System.Text;
using Models;

public class Conta : IConta
    { 
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string PacoteServico { get; set; }
        
        public TipoConta TipoConta { get; set; }
       
        #region Métodos
        public decimal VisualizarSaldo()
        {
            throw new NotImplementedException();
        }
        public decimal GerarSaldo(decimal valor)
        {
           throw new NotImplementedException();
        }
        #endregion
    }

