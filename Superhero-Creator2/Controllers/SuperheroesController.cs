﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superhero_Creator2.Models;

namespace Superhero_Creator2.Controllers
{
	public class SuperheroesController : Controller
	{
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
		public ActionResult Create(Superhero collection)
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

		// GET: SuperheroesController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: SuperheroesController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Superhero collection)
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
		public ActionResult Delete(int id, Superhero collection)
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
