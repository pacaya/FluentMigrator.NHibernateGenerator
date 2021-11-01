using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates.CSharp
{
    public class DeleteTableExpressionTemplate : ExpressionTemplate<Expressions.DeleteTableExpression>
    {
        public override void WriteTo(TextWriter tw)
        {
            tw.Write($@"
            Delete.Table(""{Expression.TableName}"")");

            if (!string.IsNullOrEmpty(Expression.SchemaName))
                tw.Write($@".InSchema(""{Expression.SchemaName}"")");
        }
    }
}