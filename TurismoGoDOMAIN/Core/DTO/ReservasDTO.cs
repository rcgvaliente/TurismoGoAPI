using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoGoDOMAIN.Core.DTO
{
    public class ReservasDTO
    {
        public class ReservasRequest {
            public int UsuarioId { get; set; }
            public int ActividadId { get; set; }
            public DateTime FechaReserva { get; set; }
            public string Estado { get; set; }

        }

        public class ReservasResponse
        {
            public int Id { get; set; }
            public int UsuarioId { get; set; }
            public int ActividadId { get; set; }
            public DateTime FechaReserva { get; set; }
            public string Estado { get; set; }

        }
    }
}
