using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace Konstruction.Filters
{
    public class ExcludeFilterAttribute : FilterAttribute
    {
        public ExcludeFilterAttribute(Type filterType)
        {
            FilterTypes = new Type[] { filterType };
        }

        public ExcludeFilterAttribute(Type[] filterTypes)
        {
            FilterTypes = filterTypes;
        }

        public Type[] FilterTypes { get; }
    }
}