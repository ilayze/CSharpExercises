using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behaviourial
{
 
    public class Element
    {
        public string Name { get; set; }
    }

    public class Iterator: IEnumerable<Element>
    {
        public Element[] array;
        public Element this[int i]
        {
            get
            {
                return array[i];
            }
        }

        #region IEnumerable<Element> Members

        public IEnumerator<Element> GetEnumerator()
        {
            foreach (Element arr in this.array)
                yield return arr;
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (Element arr in this.array)
                yield return arr;
        }

        #endregion
    }
}
