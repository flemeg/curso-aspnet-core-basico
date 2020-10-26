using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MeuMvcVscode
{
    public class MeuMiddleware
    {
        public readonly RequestDelegate _next;

        public MeuMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("\n\r --- Antes --- \n\r");

            await _next(context);

            Console.WriteLine("\n\r --- Depois --- \n\r");
        }
    }
}
