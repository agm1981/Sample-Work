using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata08
{
    abstract class CollectionFinderAbstractFactory
    {
        public abstract ICollectionFinder FactoryMethod(ICollection collection);
    }

    class CollectionFactory : CollectionFinderAbstractFactory
    {
        public override ICollectionFinder FactoryMethod(ICollection collection)
        {
            if (collection.GetType() == typeof (IEnumerable<string>) ||
                collection.GetType() == typeof (List<string>))
            {
                return new StringCollectionFinder();
            }
            return null;
            
        }
    }
}
