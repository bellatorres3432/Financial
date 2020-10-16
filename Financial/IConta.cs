using System;
using System.Collections.Generic;
using System.Text;

namespace Financial.Models
{
    public interface IConta
    {
        decimal VisualizarSaldo();
        decimal GerarSaldo(decimal valor);
        
    }
}
