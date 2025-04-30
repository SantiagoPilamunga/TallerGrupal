using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PilamungaS_Taller.Repositorios;

namespace PilamungaS_Taller.Controllers
{
    public class ReporteController : Controller
    {
        private readonly EquipoRepository _repo;
        private readonly ReporteRepository _reporteRepo;

        public ReporteController(ReporteRepository reporteRepo, EquipoRepository repo)
        {
            _repo = repo;
            _reporteRepo = reporteRepo;
        }

        public async Task<IActionResult> Index()
        {
            var reporte = await _reporteRepo.GenerarReporteAsync();
            return View(reporte);
        }
        

        
        
    }
}
