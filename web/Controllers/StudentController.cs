using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Core.Base;
using connection;
using web.Core.Student;
using Microsoft.Practices.Unity;

namespace web.Controllers
{
    public class StudentController : Controller
    {

        [Dependency]
        protected StudentDependencies dependencies {set; get;}


        protected readonly RepositoryContract<student> repository;


        public StudentController(RepositoryContract<student> repository )
        {
            this.repository = repository;
        }


        /**
         * show all students         
         */
        public ActionResult Index()
        {
            return View( this.repository.all() );
        }


        /**
         * Display create form 
         */
        public ActionResult create( )
        {
            ViewBag.districts = this.dependencies.districts();

            return View();
        }


        /**
         * Display edit form 
         */
        public ActionResult edit(int id)
        {
            ViewBag.districts = this.dependencies.districts();
            return View(this.repository.findOrFail(id));
        }



        /**
        * create new resource in database
        */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult create(student Student)
        {
            ViewBag.districts = this.dependencies.districts();

            if (!ModelState.IsValid ) {
                return View(Student);
            }

            this.repository.add( Student );
            return RedirectToRoute("students.index");
        }



        /**
          * update resource in database
          */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult edit(int id, student Student)
        {
            ViewBag.districts = this.dependencies.districts();
            
            if (!ModelState.IsValid) {
                return View(Student);
            }

           // student current = this.repository.findOrFail(id);

            this.repository.save(Student);

            return RedirectToRoute("students.index");
        }



    }
}
