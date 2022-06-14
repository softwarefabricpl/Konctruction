using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Reflection;
using System.Collections.Generic;

namespace Konstruction.Filters
{
    public class ExcludeFilterProvider : IFilterProvider
    {
        private FilterProviderCollection filterProviders;

        public ExcludeFilterProvider(IFilterProvider[] filters)
        {
            filterProviders = new FilterProviderCollection(filters);
        }

        public IEnumerable<Filter> GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            Filter[] filters = filterProviders.GetFilters(controllerContext, actionDescriptor).ToArray();

            IEnumerable<ExcludeFilterAttribute> excludeFilters = (from f in filters where f.Instance is ExcludeFilterAttribute select f.Instance as ExcludeFilterAttribute);

            List<Type> filterTypesToRemove = new List<Type>();
            foreach (ExcludeFilterAttribute excludeFilter in excludeFilters)
            {
                filterTypesToRemove.AddRange(excludeFilter.FilterTypes);
            }

            IEnumerable<Filter> res = (from filter in filters where !filterTypesToRemove.Contains(filter.Instance.GetType()) select filter);
            return res;
        }
    }
}