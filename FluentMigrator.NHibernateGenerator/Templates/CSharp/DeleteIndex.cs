using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates.CSharp
{
    public class DeleteIndexExpressionTemplate : ExpressionTemplate<Expressions.DeleteIndexExpression>
    {
        public override void WriteTo(TextWriter tw)
        {
            tw.Write($@"
            Delete.Index(");

            if (!string.IsNullOrEmpty(Expression.Index.Name))
                tw.Write($@"""{Expression.Index.Name}""");

            tw.Write($@").OnTable(""{Expression.Index.TableName}"")");

            if (!string.IsNullOrEmpty(Expression.Index.SchemaName))
                tw.Write($@".InSchema(""{Expression.Index.SchemaName}"")");
        }
    }
}