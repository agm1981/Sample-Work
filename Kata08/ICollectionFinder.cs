using System.Collections;
using System.Collections.Generic;

namespace Kata08
{
    public delegate bool DoesWordBelongInOutput<T>(T element, HashSet<T> collectionToSearchOn);

    public interface ICollectionFinder<T>
    {
        ICollection GetSplittedCollection(IEnumerable collectionToWorkWith, DoesWordBelongInOutput<T> comparer);
    }
}
