using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace FluentMigrator.NHibernateGenerator.SF {
    public sealed class MigrationCreator {
        private readonly MigrationConfigurationBase configuration;

        public MigrationCreator(MigrationConfigurationBase configuration) {
            this.configuration = configuration;
        }

        public void Create(string name) {
            name = AppendDate(StripNonAlphaNumeric(name));
            var migration = configuration.Generate(name);
            if (!string.IsNullOrEmpty(migration.ErrorMessage)) throw new Exception(migration.ErrorMessage);
            
            var appName = Assembly.GetCallingAssembly()?.GetName()?.Name ?? throw new NullReferenceException();
            var dir = Path.Combine(GetProjectPath(appName), migration.MigrationsDirectory);
            Directory.CreateDirectory(dir);
            
            using (StreamWriter outputFile = new (Path.Combine(dir, $"{migration.FileNamePrefix}{name}.cs")))
            {
                outputFile.Write(migration.Code);
            }
            using (StreamWriter outputFile = new (Path.Combine(dir, $"{migration.FileNamePrefix}Designer.cs")))
            {
                outputFile.Write(migration.Designer);
            }
        }

        private static string AppendDate(string name) {
            var now = DateTime.UtcNow;
            return $"{name}_{now.Year:0000}{now.Month:00}{now.Day:00}{now.Hour:00}{now.Minute:00}{now.Second:00}";
        }

        private static string StripNonAlphaNumeric(string str) {
            return Regex.Replace(str, "[^a-zA-Z0-9_]+", "", RegexOptions.Compiled);
        }

        private static string GetProjectPath(string appName) {
            
            var dir = new DirectoryInfo(Environment.CurrentDirectory);
            var file = Path.Combine(dir.FullName, $"{appName}.csproj");
            while (! File.Exists(file)) {
                dir = Directory.GetParent(dir.FullName);
                file = Path.Combine(dir.FullName, $"{appName}.csproj");
            }
            return dir.FullName;
        }
    }
}