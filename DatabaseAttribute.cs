using System;

namespace Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DatabaseAttribute : Attribute
    {
        public DatabaseAttribute(string databaseName)
        {
            DatabaseName = databaseName;
        }

        public string DatabaseName { get; }
    }
}
