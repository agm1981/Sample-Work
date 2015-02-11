using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBaseinMemory
{
    //here we define the database operations
    public interface IDatabaseOperations
    {

        void End();

        void Begin();

        string RollBack();

        string Commit();

    }
}
