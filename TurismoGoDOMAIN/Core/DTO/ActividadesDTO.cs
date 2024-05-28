using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoGoDOMAIN.Core.DTO
{
    public class ActividadesDTO
    {
        public class ActividadesRequest()
        {
            public int EmpresaId { get; set; }

            public string Titulo { get; set; } = null!;

            public string Descripcion { get; set; } = null!;

            public string Itinerario { get; set; } = null!;

            public string Destino { get; set; } = null!;

            public DateTime FechaInicio { get; set; }

            public DateTime FechaFin { get; set; }

            public decimal Precio { get; set; }

            public int Capacidad { get; set; }

            public DateTime FechaPublicacion { get; set; }
        }
    }
}
