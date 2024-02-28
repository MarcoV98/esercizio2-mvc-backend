using esercizio2_mvc_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace esercizio2_mvc_backend.Controllers

public class ScarpeController : Controller
{
    private readonly ApplicationDbContext _context;

    public ScarpeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var scarpeInVendita = _context.Scarpe.Where(s => s.InVendita).ToList();
        return View(scarpeInVendita);
    }

    public ActionResult Dettagli(int id)
    {
        var scarpa = _context.Scarpe.Find(id);
        return View(scarpa);
    }

    [HttpPost]
    public ActionResult RimuoviDallaVetrina(int id)
    {
        var scarpa = _context.Scarpe.Find(id);
        if (scarpa != null)
        {
            scarpa.InVendita = false;
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}
