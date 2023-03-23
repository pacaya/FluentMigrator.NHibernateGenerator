using FluentMigrator.Expressions;

namespace FluentMigrator.NHibernateGenerator.SF.Templates
{
    public interface ITemplateFromExpressionFactory
    {
        ITemplate GetTemplate(IMigrationExpression expr);
    }
}