using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurismoGoDOMAIN.Core.Entities;
using TurismoGoDOMAIN.Infraestructure.Data;
using static TurismoGoDOMAIN.Core.DTO.ActividadesDTO;

namespace TurismoGoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadesController : ControllerBase
    {
        private readonly TurismoGoBdContext _context;

        public ActividadesController(TurismoGoBdContext context)
        {
            _context = context;
        }

        // GET: api/Actividades
        [HttpGet]
        public ActionResult<IEnumerable<Actividades>> GetActividades()
        {
            return _context.Actividades.ToList();
        }

        // GET: api/Actividades/5
        [HttpGet("{id}")]
        public ActionResult<Actividades> GetActividad(int id)
        {
            var actividad = _context.Actividades.Find(id);

            if (actividad == null)
            {
                return NotFound();
            }

            return actividad;
        }

        // POST: api/Actividades
        [HttpPost]
        public ActionResult<Actividades> PostActividad(ActividadesRequest actividadesRequest)
        {
            var actividad = new Actividades{
                EmpresaId = actividadesRequest.EmpresaId,
                Titulo = actividadesRequest.Titulo,
                Descripcion = actividadesRequest.Descripcion,
                Itinerario = actividadesRequest.Itinerario,
                Destino = actividadesRequest.Destino,
                FechaInicio = actividadesRequest.FechaInicio,
                FechaFin = actividadesRequest.FechaFin,
                Precio = actividadesRequest.Precio,
                Capacidad = actividadesRequest.Capacidad,
                FechaPublicacion = actividadesRequest.FechaPublicacion
            };

            _context.Actividades.Add(actividad);
            _context.SaveChanges();

            return CreatedAtAction("GetActividad", new { id = actividad.Id }, actividad);
        }

        // PUT: api/Actividades/5
        [HttpPut("{id}")]
        public IActionResult PutActividad(int id, ActividadesRequest actividadesRequest)
        {
            var actividad = new Actividades
            {
                Id = id,
                EmpresaId = actividadesRequest.EmpresaId,
                Titulo = actividadesRequest.Titulo,
                Descripcion = actividadesRequest.Descripcion,
                Itinerario = actividadesRequest.Itinerario,
                Destino = actividadesRequest.Destino,
                FechaInicio = actividadesRequest.FechaInicio,
                FechaFin = actividadesRequest.FechaFin,
                Precio = actividadesRequest.Precio,
                Capacidad = actividadesRequest.Capacidad,
                FechaPublicacion = actividadesRequest.FechaPublicacion
            };

            _context.Entry(actividad).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Actividades/5
        [HttpDelete("{id}")]
        public IActionResult DeleteActividad(int id)
        {
            var actividad = _context.Actividades.Find(id);
            if (actividad == null)
            {
                return NotFound();
            }

            _context.Actividades.Remove(actividad);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
