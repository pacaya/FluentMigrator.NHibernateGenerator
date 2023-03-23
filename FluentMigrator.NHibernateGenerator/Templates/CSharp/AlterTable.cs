using System;
using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates.CSharp
{
    public class AlterTableExpressionTemplate : ExpressionTemplate<Expressions.AlterTableExpression>
    {
        public override void WriteTo(TextWriter tw)
        {
            throw new NotImplementedException("FluentMigrator.Expressions.AlterTableExpression");
        }
    }
}

