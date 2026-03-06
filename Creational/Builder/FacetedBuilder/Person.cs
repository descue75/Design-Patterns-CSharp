using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FacetedBuilder
{
    internal class Person
    {
        // address
        public string ?StreetAddress, Postcode, City;

        // employment
        public string ?CompanyName, Position;
        public int? AnnualIncome;

        public override string ToString()
        {
            var nl = Environment.NewLine;
            return
                $"{nameof(StreetAddress)}: {StreetAddress}{nl}" +
                $"{nameof(Postcode)}: {Postcode}{nl}" +
                $"{nameof(City)}: {City}{nl}" +
                $"{nameof(CompanyName)}: {CompanyName}{nl}" +
                $"{nameof(Position)}: {Position}{nl}" +
                $"{nameof(AnnualIncome)}: {AnnualIncome}";
        }

    }
}
