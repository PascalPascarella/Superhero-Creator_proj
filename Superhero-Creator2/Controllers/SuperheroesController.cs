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
			return View();
		}

		// GET: SuperheroesController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: SuperheroesController/Create
		public ActionResult Create()
		{
			return View();
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
			return View();
		}

		// POST: SuperheroesController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Superhero superhero)
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

		// GET: SuperheroesController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: SuperheroesController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Superhero superhero)
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
