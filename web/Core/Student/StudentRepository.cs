using connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.Core.Base;
using Microsoft.Practices.Unity;
using System.Data.Entity.Validation;
using System.Data;
 

namespace web.Core.Student
{
    public class StudentRepository : BaseRepository, RepositoryContract<student>
    {

        public IEnumerable<student> all()
        {
            return this.context.students.Include("district").ToList();
        }


        public student find(int id)
        {
            return this.context.students.Find( id );
        }

        public bool add(student entity)
        {
            entity.setFullNameAttribute();

            context.students.Add(entity);

            return context.SaveChanges() > 0;
        }

        public bool delete(student entity)
        {
            throw new NotImplementedException();
        }

        public bool save(student entity)
        {
            entity.setFullNameAttribute();  
            context.Entry(entity).State = EntityState.Modified;

            return context.SaveChanges() > 0;
        }


        public student findOrFail(int id)
        {
            student Student = this.find(id);

            if (null == Student) {
                throw new NotFoundModelException();
            }

            return Student;
        }
    }
}