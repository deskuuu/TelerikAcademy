﻿namespace High.Quality.Code.BadExample.Models
{
    using System;
    using System.Text;

    using Contracts;
    using Enumerations;
    using Exstensions;

    [Serializable]
    public class Bunny
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public FurType FurType { get; set; }

        public Bunny(string name, int age, FurType furType)
        {
            this.Name = name;
            this.Age = age;
            this.FurType = furType;
        }

        public void Introduce(IWriter writer)
        {
            writer.WriteLine($"{this.Name} - \"I am {this.Age} years old!\"");
            writer.WriteLine($"{this.Name} - \"And I am {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");
        }

        public override string ToString()
        {
            var builderSize = 200;
            var builder = new StringBuilder(builderSize);

            builder.AppendLine($"Bunny name: {this.Name}");
            builder.AppendLine($"Bunny age: {this.Age}");
            builder.AppendLine($"Bunny fur: {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");

            return builder.ToString();
        }
    }
}
