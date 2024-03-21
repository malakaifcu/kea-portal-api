using LoanPortalAPIDev.Models;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LoanPortalAPIDev.Filters
{
    public class CustomDocumentFilter:IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            context.SchemaGenerator.GenerateSchema(typeof(Applications), context.SchemaRepository);
        }
    }
}
