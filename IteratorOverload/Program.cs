using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            ListExtender lst = new ListExtender
                               {
                                   new Element("B", 2),
                                   new Element("C", 3),
                                   new Element("A", 1),
                                   new Element("F", 5),
                                   new Element("D", 4),

                               };
            foreach (Element element in lst)
            {
                Console.WriteLine("{0} - {1}", element.Name, element.Data);
            }

            Console.ReadLine();

        }
    }

    public class ListExtender : List<Element>
    {
        new public IEnumerator GetEnumerator()
        {
            return this.AsEnumerable().OrderBy(x => x.Data).GetEnumerator();
        }

        
    }

    public class Element
    {
        public string Name
        {
            get;
            set;
        }

        public int Data
        {
            get;
            set;
        }

        public Element(string name, int data)
        {
            Name = name;
            Data = data;
        }
    }
}
