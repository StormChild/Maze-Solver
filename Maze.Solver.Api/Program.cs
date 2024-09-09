using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json;

namespace Maze.Solver.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            var _maze = new Maze();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapPost("/maze", (HttpContext context, [FromBody] object payload) =>
            {
                var client_payload = JsonConvert.DeserializeObject<Payload>(payload.ToString());
                if (!_maze.parse(client_payload.maze))
                {
                    return HttpStatusCode.UnprocessableEntity;
                }
                return HttpStatusCode.OK;
            });

            app.MapGet("/history", (HttpContext context) => 
            {
                return _maze.history;
            });

            app.Run();
        }

        public class Payload
        {
            public string maze = "";
        }
    }
}
