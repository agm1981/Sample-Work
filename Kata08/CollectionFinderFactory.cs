using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata08
{
    public abstract class CollectionFinderAbstractFactory<T>
    {
        public abstract ICollectionFinder<T> FactoryMethod(ICollection collection);
    }

    public class CollectionFactory<T> : CollectionFinderAbstractFactory<T>
    {
        public override ICollectionFinder<T> FactoryMethod(ICollection collection)
        {
            return new StringCollectionFinder<T>();
        }
    }
}
