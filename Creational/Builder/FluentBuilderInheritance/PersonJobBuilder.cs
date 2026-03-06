using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FluentBuilderInheritance
{
    internal class PersonJobBuilder<SELF> : PersonInfoBuilder<SELF> where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorksAsA(string position)
        {
            person.Position = position;
            return (SELF)this;
        }
    }
}
