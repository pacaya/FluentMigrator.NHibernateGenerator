using FluentMigrator.Infrastructure.Extensions;
using FluentMigrator.Model;
using FluentMigrator.SqlServer;
using System.Collections.Generic;

namespace FluentMigrator.NHibernateGenerator.SF
{
    public static class Extensions
    {
        public static ICollection<IndexIncludeDefinition> GetIncludes(this IndexDefinition index)
        {
            var includes = index.GetAdditionalFeature(SqlServerExtensions.IncludesList, () => new List<IndexIncludeDefinition>());
            return includes;
        }
    }
}
