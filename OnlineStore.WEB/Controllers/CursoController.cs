using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Application.Interfaces;
using OnlineStore.Domain.Models;

namespace OnlineStore.WEB.Controllers
{
    public class CursoController : Controller
    {
        private readonly ICursosRepository _cursosRepository;

        public CursoController(ICursosRepository cursosRepository)
        {
            _cursosRepository = cursosRepository;
        }

        // GET: CursoController
        public async Task<ActionResult> Index()
        {
            List<Curso> cursos = (List<Curso>)await _cursosRepository.GetAllAsync();
            return View(cursos);
        }

        // GET: CursoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CursoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CursoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CursoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CursoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
