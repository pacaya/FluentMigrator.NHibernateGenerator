using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates.CSharp
{
    public class DeleteSequenceExpressionTemplate : ExpressionTemplate<Expressions.DeleteSequenceExpression>
    {
        public override void WriteTo(TextWriter tw)
        {
            tw.Write($@"
            Delete.Sequence(""{Expression.SequenceName}"")");

            if (!string.IsNullOrEmpty(Expression.SchemaName))
                tw.Write($@".InSchema(""{Expression.SchemaName}"")");
        }
    }
}