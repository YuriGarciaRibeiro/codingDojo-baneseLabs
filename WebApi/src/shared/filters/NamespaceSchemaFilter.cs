using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace WebApi.shared.filters;

using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

internal class SwaggerSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        var keys = new System.Collections.Generic.List<string>();
        var prefix = "id";
        foreach (var key in context.SchemaRepository.Schemas.Keys)
        {
            if (key.StartsWith(prefix))
            {
                
                keys.Add(key);
            }
        }

        foreach (var key in keys)
        {
            context.SchemaRepository.Schemas.Remove(key);
        }
    }
}