namespace _11.Version_attribute
{
    using System;
    using System.Reflection;

    [Version(VersionAttribute.Type.Class, 11, 2)]
    class Test
    {
        static void Main()
        {
            var attr = typeof(Test).GetCustomAttributes<VersionAttribute>();
            foreach (var item in attr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
