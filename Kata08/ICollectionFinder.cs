using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata08
{
    interface ICollectionFinder
    {
        ICollection GetSplittedCollection(ICollection collectionToWorkWith, int maxNumberOfChars);
    }
}
