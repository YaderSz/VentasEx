using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasEx
{
    public interface IVentasRepository
    {

        Task<List<infVentas>> GetAllAsync();
        Task GuardarDatosProdAsync(List<infVentas> prod);

        Task CalcularVentasAsync(double precio, int cnt);

    }
}
