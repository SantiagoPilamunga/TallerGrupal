using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PilamungaS_Taller.Models;
using PilamungaS_Taller.Repositorios;

namespace PilamungaS_Taller.Controllers
{
    

    public class EquipoController : Controller
    {

        private readonly EquipoRepository _equipoRepo;

        public EquipoController(EquipoRepository equipoRepo)
        {
            _equipoRepo = equipoRepo;
        }
        
        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            
            var equipos = _equipoRepo.DevuelveListadoEquipos2();
            equipos=equipos.OrderByDescending(item => item.Puntos);
            //equipos = equipos.Where(item => item.Nombre == "Liga de quito");
            return View(equipos);
        }

        public ActionResult Create()
        {
            return View();
        }

        
        public ActionResult Edit(int Id)
        {
            Equipo equipo = _equipoRepo.DevuelveEquipoConJugadores(Id);
            return View(equipo);
        }

        [HttpPost]
        public ActionResult Edit(int Id,Equipo equipo)
        {

            _equipoRepo.ActualizarEquipo(Id, equipo);
            return RedirectToAction(nameof(List));

        }
    }
}
