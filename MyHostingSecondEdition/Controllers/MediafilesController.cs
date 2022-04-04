using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyHostingSecondEdition.Controllers
{
    public class MyHostingSecondEditionController : Controller
    {
        List<MediaFile> myGallery = new List<MediaFile>(){
            new MediaFile{
            Id = 1,
            Descr = "Something1",
            },
            new MediaFile{
            Id = 2,
            Descr = "Something2",
            },
            new MediaFile{
            Id = 3,
            Descr = "Something3",
            },
            new MediaFile{
            Id = 4,
            Descr = "Something4",
            }
        };

        [HttpGet("{id}")]
        public MediaFile Get(long id)
        {
            return myGallery.Find(m => m.Id == id);
        }

        [HttpGet]
        public IEnumerable<MediaFile> Get()
        {
            return myGallery.ToArray();
        }

        // GET: MyHostingSecondEditionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyHostingSecondEditionController/Create
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

        // GET: MyHostingSecondEditionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyHostingSecondEditionController/Edit/5
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

        // GET: MyHostingSecondEditionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyHostingSecondEditionController/Delete/5
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
