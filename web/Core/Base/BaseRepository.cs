using connection;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Core.Base
{
    public abstract class BaseRepository
    {
        [Dependency]
        protected usableModels context { get; set; }

        public usableModels getContext()
        {
            return this.context;
        }

    }

}