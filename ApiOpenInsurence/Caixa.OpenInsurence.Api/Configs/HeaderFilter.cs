using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace Caixa.OpenInsurence.Api.Configs
{
    public class HeaderFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "Cache-Control",
                In = ParameterLocation.Header,
                Schema = new OpenApiSchema
                {
                    Type = "string",
                },
                Required = true
            });

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "Content-Security-Policy",
                In = ParameterLocation.Header,
                Schema = new OpenApiSchema
                {
                    Type = "string",
                },
                Required = true
            });

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "Content-Type",
                In = ParameterLocation.Header,
                Schema = new OpenApiSchema
                {
                    Type = "string",
                },
                Required = true
            });

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "Strict-Transport-Security",
                In = ParameterLocation.Header,
                Schema = new OpenApiSchema
                {
                    Type = "string",
                },
                Required = true
            });
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "X-Content-Type-Options",
                In = ParameterLocation.Header,
                Schema = new OpenApiSchema
                {
                    Type = "string",
                },
                Required = true
            });

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "X-Frame-Options",
                In = ParameterLocation.Header,
                Schema = new OpenApiSchema
                {
                    Type = "string",
                },
                Required = true
            }); 
        }
    }
}
