using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build() => person;
    }
}
