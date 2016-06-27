namespace _11.Version_attribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
     AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
     AllowMultiple = true)]

    public class VersionAttribute : Attribute
    {
        // Create a[Version] attribute that can be applied to structures, classes, interfaces, enumerations 
        // and methods and holds a version in the format major.minor (e.g. 2.11).
        // Apply the version attribute to a sample class and display its version at runtime.

        public int Major { get; private set; }
        public int Minor { get; set; }
        public Type Commponent { get; set; }

        public VersionAttribute(Type commponent, int major, int minor)
        {
            this.Commponent = commponent;
            this.Major = major;
            this.Minor = minor;
        }

        public enum Type
        {
            Class,
            Struct,
            Iterface,
            Enum,
            Method
        }

        public override string ToString()
        {
            return string.Format($" Type[{Commponent}]                                         Version [{Minor}.{Major}]");
        }
    }
}
