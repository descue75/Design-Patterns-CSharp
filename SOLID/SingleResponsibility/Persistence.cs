using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResponsibility
{
    internal class Persistence
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, journal.ToString());
        }
    }
}
