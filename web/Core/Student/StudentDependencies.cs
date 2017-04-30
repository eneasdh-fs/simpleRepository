using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.Core.Base;
using Microsoft.Practices.Unity;
using connection;


namespace web.Core.Student
{
    public class StudentDependencies
    {
        [Dependency]
        protected usableModels context { get; set; }


        public IEnumerable<district> districts()
        {
            return context.districts.ToList();
        }

        public Boolean isEmailUnique(String email, int id = 0 )
        {

            var query = context.students.Where(x => x.email == email);

            if (id > 0) {
                return query.Where(x => x.id != id).FirstOrDefault() == null;
            }


            return query.FirstOrDefault() == null;
        }
    }
}