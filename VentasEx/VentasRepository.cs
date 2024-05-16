using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasEx
{
    public class VentasRepository : IVentasRepository
    {

        public string _filepath = "Ventas.txt";
        List<infVentas> v = new List<infVentas> ();

        public Task CalcularVentasAsync(double precio, int cnt)
        {
            throw new NotImplementedException();
        }

        public void CalcularVentas(double precio, int cnt)
        {
            double CalcularVentas = precio * cnt;

        }

        public async Task GuardarDatosProdAsync(List<infVentas> prod)
        {
            using(StreamWriter SW = new StreamWriter(_filepath))
            {
                foreach(infVentas prd in prod)
                {
                    CalcularVentas(prd.Precio, prd.cntd);
                    await SW.WriteLineAsync($"{prd.prdName} , {prd.cntd} , {prd.Precio} , {CalcularVentas}");
                }
            }

        }



        



        public async Task<List<infVentas>> GetAllAsync()
        {
            if (File.Exists(_filepath) != null)
            {
                using (StreamReader SR = new StreamReader(_filepath))
                {
                    string splits;
                    splits = await SR.ReadLineAsync();
                    while (splits != null)
                    {
                        string[] data = splits.Split(',');
                        v.Add(new infVentas(data[0], Convert.ToDouble(data[1]), Convert.ToInt32(data[2]), Convert.ToDouble(data[3])));


                    }

                }
            }
            return v;
        }
    }
}
