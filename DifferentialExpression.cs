using FluentMigrator.Expressions;

namespace FluentMigrator.NHibernateGenerator.SF
{
    public class DifferentialExpression
    {
        public DifferentialExpression(IMigrationExpression upReversible)
        {
            Up = upReversible;
            Down = upReversible.Reverse();
        }
        public DifferentialExpression(IMigrationExpression up, IMigrationExpression down)
        {
            Up = up;
            Down = down;
        }

        public IMigrationExpression Up { get; set; }
        public IMigrationExpression Down { get; set; }
    }
}
