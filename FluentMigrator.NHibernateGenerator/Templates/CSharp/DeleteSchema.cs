using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates.CSharp
{
    public class DeleteSchemaExpressionTemplate : ExpressionTemplate<Expressions.DeleteSchemaExpression>
    {
        public override void WriteTo(TextWriter tw)
        {
            tw.Write($@"
            Delete.Schema(""{Expression.SchemaName}"")");
        }
    }
}