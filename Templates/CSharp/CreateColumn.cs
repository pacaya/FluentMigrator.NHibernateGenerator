using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates.CSharp
{
    public class CreateColumnExpressionTemplate : ExpressionTemplate<Expressions.CreateColumnExpression>
    {
        public override void WriteTo(TextWriter tw)
        {
            tw.Write($@"
            Create.Column(""{Expression.Column.Name}"").OnTable(""{Expression.TableName}"")");

            if (!string.IsNullOrEmpty(Expression.SchemaName))
                tw.Write($@".InSchema(""{Expression.SchemaName}"")");

            ColumnDefinitionTemplate.WriteColumnValue(tw, Expression.Column);
        }
    }
}

