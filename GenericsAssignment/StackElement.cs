using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsAssignment
{
    class StackElement : IEnumerable
    {
        private List<CustomerRecord> List { get; set; }
        public int Count { get { return List.Count; } }

        public void Push(CustomerRecord record)
        {
            List.Add(record);
        }
        public void Pop()
        {
            if (List.Count > 0)
            {
                List.Remove(List[List.Count]);
            }

        }

        public string Peek()
        {
            if (List.Count <=0 )
            {
                return "List is empty";
            }
            else
            {
                return (List[List.Count]).ToString();
            }
        }

        public IEnumerator GetEnumerator()
        {

            for (int i = List.Count; i ==0; i--)
            {
                yield return List[i];
            }
        }
    }

    }
}
