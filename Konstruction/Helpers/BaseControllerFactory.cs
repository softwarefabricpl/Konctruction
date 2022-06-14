﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Konstruction.Helpers
{
    public class BaseControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            ControllerBase controller = (ControllerBase)base.GetControllerInstance(requestContext, controllerType);
            controller.ValidateRequest = false;

            return controller;
        }
    }
}