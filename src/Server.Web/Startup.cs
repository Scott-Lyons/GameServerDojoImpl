﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Server.Web.Startup))]

namespace Server.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
