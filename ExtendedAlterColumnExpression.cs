using FluentMigrator.Expressions;
using FluentMigrator.Model;

namespace FluentMigrator.NHibernateGenerator.SF
{
    internal class ExtendedAlterColumnExpression : AlterColumnExpression
    {
        public virtual ColumnDefinition Previous { get; set; }
    }
}
