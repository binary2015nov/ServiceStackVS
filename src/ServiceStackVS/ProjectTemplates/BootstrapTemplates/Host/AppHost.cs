﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Funq;
using ServiceStack;
using $saferootprojectname$.ServiceInterface;

namespace $safeprojectname$
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("$safeprojectname$", typeof(MyServices).Assembly) {}

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            //Plugins.Add(new PostmanFeature());
            //Plugins.Add(new CorsFeature());
            
            Plugins.Add(new TemplatePagesFeature());
        }
    }
}