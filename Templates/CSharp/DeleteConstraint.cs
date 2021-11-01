using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates.CSharp
{
    public class DeleteConstraintExpressionTemplate : ExpressionTemplate<Expressions.DeleteConstraintExpression>
    {
        public override void WriteTo(TextWriter tw)
        {
            tw.Write($@"
            Delete.{(Expression.Constraint.IsPrimaryKeyConstraint ? "PrimaryKey" : "UniqueConstraint")}(""{Expression.Constraint.ConstraintName}"")");

            tw.Write($@".FromTable(""{Expression.Constraint.TableName}"")");

            if (!string.IsNullOrEmpty(Expression.Constraint.SchemaName))
                tw.Write($@".InSchema(""{Expression.Constraint.SchemaName}"")");
        }
    }
}