using FluentMigrator.Expressions;
using FluentMigrator.Model;

namespace FluentMigrator.NHibernateGenerator.SF
{
    public class ExtendedAlterColumnExpression : AlterColumnExpression
    {
        public virtual ColumnDefinition Previous { get; set; }
    }
}
