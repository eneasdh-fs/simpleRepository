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

        /**
         * Inyección de las dependencias 
         * 
         * Constructor - anotaciones
         * 
         */

        // anotaciones
        [Dependency]
        protected StudentDependencies dependencies {set; get;}

        protected readonly RepositoryContract<student> repository;


        // a través del constructor
        public StudentController(RepositoryContract<student> repository )
        {
            this.repository = repository;
        }


        /**
         * Filtro de Alumnos
         */
        public ActionResult Index( String search )
        {
            return View( this.repository.search( search ) );
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
        * Registrar nuevo alumno
        */
        [HttpPost]
        [ValidateAntiForgeryToken] // token de seguridad
        public ActionResult create(student Student)
        {
            ViewBag.districts = this.dependencies.districts();
            
            if (!ModelState.IsValid ) {
                return View(Student);
            }

            if (! this.dependencies.isEmailUnique(Student.email)) {
                ModelState.AddModelError("email", this.getEmailErrorMessage());
                return View(Student);
            }


            this.repository.add( Student );
            return RedirectToRoute("students.index");
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
         * Modifica un Alumno
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult edit(int id, student Student)
        {
            ViewBag.districts = this.dependencies.districts();

            if (!ModelState.IsValid)
            {
                return View(Student);
            }

            if (!this.dependencies.isEmailUnique(Student.email, Student.id))
            {
                ModelState.AddModelError("email", this.getEmailErrorMessage());
                return View(Student);
            }

            this.repository.save(Student);

            return RedirectToRoute("students.index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken] // token de seguridad
        public ActionResult destroy(int id)
        {
            student Student = this.repository.findOrFail(id);

            if (this.repository.delete(Student))
            {
                TempData["message"] = String.Format("Alumno {0} fue Eliminado", Student.full_name);
            }

            return RedirectToRoute("students.index");
        }






        protected String getEmailErrorMessage()
        {
            return "El E-mail ya fue Utilizado";
        }

    }
}
