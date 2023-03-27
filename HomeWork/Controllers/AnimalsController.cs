using HomeWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Controllers;

public class AnimalsController : Controller
{
    private readonly AnimalContext _db;

    public AnimalsController(AnimalContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult Index()
    {
        List<Animal> animals = _db.Animals.ToList();
        return View(animals);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Animal animal)
    {
        _db.Animals.Add(animal);
        _db.SaveChanges();
        
        return RedirectToAction("Index");
    }
}