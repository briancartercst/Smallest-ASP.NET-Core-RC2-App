using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace FunWithNightlies
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
          app.Run(async ctx =>
          {
            ctx.Response.WriteAsync($"Hello World - Req: {ctx.Request.Path}");
          });
        }
    }
}    