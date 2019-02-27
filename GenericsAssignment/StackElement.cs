using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsAssignment
{
    internal class StackElement : IEnumerable<CustomerRecord>
    {
        private List<CustomerRecord> List { get; set; }
        private List<CustomerRecord> tempList { get; set; }
        public int Count { get { return List.Count; } }
        public StackElement()
        {
            List = new List<CustomerRecord>();
        }
        public void Push(CustomerRecord record)
        {
            List.Add(record);
        }
        public void Pop()
        {
            if (List.Count > 0)
            {
                List.Remove(List[List.Count-1]);
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
                return (List[List.Count-1]).ToString();
            }
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<CustomerRecord> GetEnumerator()
        {
            tempList = List;
            tempList.Reverse();
            return tempList.GetEnumerator();
        }
    }

}
