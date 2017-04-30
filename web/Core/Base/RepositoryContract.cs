using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.Core.Base
{

    //The Generic Interface Repository for Performing Read/Add/Delete operations
    public interface RepositoryContract<TEnt> where TEnt : class
    {

        //return all rows
        IEnumerable<TEnt> all();
        
        //find Resource
        TEnt find(int id);

        //find Resource
        TEnt findOrFail(int id);

        // add Resource
        Boolean add(TEnt entity);
        
        
        // drop model in database
        Boolean delete(TEnt entity);


        Boolean save(TEnt entity);

    }
}
