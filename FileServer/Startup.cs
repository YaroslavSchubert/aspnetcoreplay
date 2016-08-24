using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;


namespace aspnetcoreapp
{
    public class Startup
    {
		public void Configure(IApplicationBuilder app)
        {
			app.UseFileServer(new FileServerOptions()
    		{
        		FileProvider = new PhysicalFileProvider(
            	    Path.Combine(Directory.GetCurrentDirectory(), @"files")),
        		RequestPath = new PathString("/files")
    		});
        }
    }
}
