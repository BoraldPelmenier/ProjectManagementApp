﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Middlewares
{
    public class RoutingMiddleware
    {
        RequestDelegate _next;

        public RoutingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();
            if (path == "/" || path == "/index")
                await context.Response.WriteAsync("Home Page");
            else if (path == "/Project")
                await context.Response.WriteAsync("Get Projects");
            else
                context.Response.StatusCode = 404;
        }
    }
}
