﻿namespace Boilerplate.Web.Mvc
{
    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Hosting;
    using Microsoft.Framework.DependencyInjection;

    /// <summary>
    /// <see cref="IApplicationBuilder"/> extension methods.
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Configures the <see cref="UrlHelperExtensions"/> and <see cref="OpenGraphMetadata"/> with the 
        /// <see cref="IHttpContextAccessor"/>, so that they have access to the current <see cref="HttpContext"/> and
        /// can get the current request path. Also configures the <see cref="AtomActionResult"/> with the 
        /// <see cref="IHostingEnvironment"/>.
        /// </summary>
        /// <param name="application">The application.</param>
        public static void UseAspNetMvcBoilerplate(this IApplicationBuilder application)
        {
            IHostingEnvironment hostingEnvironment = 
                application.ApplicationServices.GetRequiredService<IHostingEnvironment>();
            IHttpContextAccessor httpContextAccessor = 
                application.ApplicationServices.GetRequiredService<IHttpContextAccessor>();
            Context.Configure(hostingEnvironment, httpContextAccessor);
        }
    }
}
