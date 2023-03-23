using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates.CSharp
{
    public class CreateSchemaExpressionTemplate : ExpressionTemplate<Expressions.CreateSchemaExpression>
    {
        public override void WriteTo(TextWriter tw)
        {
            tw.Write($@"
            Create.Schema(""{Expression.SchemaName}"")");
        }
    }
}
