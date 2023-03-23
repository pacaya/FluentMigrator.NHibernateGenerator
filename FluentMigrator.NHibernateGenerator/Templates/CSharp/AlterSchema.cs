using System;
using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates.CSharp
{
    public class AlterSchemaExpressionTemplate : ExpressionTemplate<Expressions.AlterSchemaExpression>
    {
        public override void WriteTo(TextWriter tw)
        {
            throw new NotImplementedException("FluentMigrator.Expressions.AlterSchemaExpression");
        }
    }
}

