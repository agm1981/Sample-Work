using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBaseinMemory
{
    interface IDataBaseOperationsBasic
    {
        string Get(string variableNameLowerCase);

        void Set(string variableNameLowerCase, string value);

        void UnSet(string variableNameLowerCase);

        int NumEqualTo(string value);
    }
}
