using System.IO;

namespace FluentMigrator.NHibernateGenerator.SF.Templates
{
    public interface ITemplate
    {
        void WriteTo(TextWriter tw);
    }
}