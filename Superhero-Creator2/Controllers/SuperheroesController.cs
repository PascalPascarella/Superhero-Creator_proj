using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superhero_Creator2.Data;
using Superhero_Creator2.Models;

namespace Superhero_Creator2.Controllers
{
	public class SuperheroesController : Controller
	{
		// Member Variable
		private ApplicationDbContext _db;		// Represents DB anywhere inside of class

		// Constructor
		public SuperheroesController(ApplicationDbContext db)		// Passes the project's INSTANCE into the controller
		{
			_db = db;		// Assigns input to _db member variable on line 14
		}

		// GET: SuperheroesController
		public ActionResult Index()
		{
			var superheroes = _db.Superheroes.ToList();		// Grabs all hero rec, assign to list and assign to var
			return View(superheroes);
		}

		// GET: SuperheroesController/Details/5
		public ActionResult Details(int id)
		{
			var superheroDetails = _db.Superheroes.Find(id);
			return View(superheroDetails);
		}

		// GET: SuperheroesController/Create
		public ActionResult Create()
		{
			Superhero superhero = new Superhero();
			return View(superhero);
		}

		// POST: SuperheroesController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Superhero superhero)
		{
			try
			{
				_db.Superheroes.Add(superhero);   // Takes captured superhero data, adds to table in our DB
				_db.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: SuperheroesController/Edit/5
		public ActionResult Edit(int id)
		{
			var superheroEdit = _db.Superheroes.Find(id);

			return View(superheroEdit);
		}

		// POST: SuperheroesController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Superhero superhero)
		{
			try
			{
				_db.Superheroes.Update(superhero);
				_db.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: SuperheroesController/Delete/5
		public ActionResult Delete(int id)
		{
			var superheroDelete = _db.Superheroes.Find(id);

			return View(superheroDelete);
		}

		// POST: SuperheroesController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Superhero superhero)
		{
			try
			{
				_db.Superheroes.Remove(superhero);
				_db.SaveChanges();

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
