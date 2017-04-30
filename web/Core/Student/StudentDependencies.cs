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
    }
}