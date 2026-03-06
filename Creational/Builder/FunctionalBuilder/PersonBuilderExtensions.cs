using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FunctionalBuilder
{
    internal static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAs(this PersonBuilder builder, string position)
            => builder.Do(p => p.Position = position);
    }
}
