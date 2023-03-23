using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates.CSharp
{
    public class DeleteColumnExpressionTemplate : ExpressionTemplate<Expressions.DeleteColumnExpression>
    {
        public override void WriteTo(TextWriter tw)
        {
            foreach (var cn in Expression.ColumnNames)
            {
                tw.Write($@"
            Delete.Column(""{cn}"").FromTable(""{Expression.TableName}"")");

                if (!string.IsNullOrEmpty(Expression.SchemaName))
                    tw.Write($@".InSchema(""{Expression.SchemaName}"")");
            }
        }
    }
}