using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    class MyDictionary<TKey, TValue>
    {
        List<TKey> KeyList;
        List<TValue> ValueList;

        public MyDictionary()
        {
            KeyList = new List<TKey>();
            ValueList = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            if(KeyList.Contains(key))
            {
                throw new ArgumentException("Key is already present");
            }
            KeyList.Add(key);
            ValueList.Add(value);
        }
        
        public void Remove(TKey key)
        {
            if (!KeyList.Contains(key))
            {
                throw new ArgumentException("Key is not present");
            }
            var index = KeyList.IndexOf(key);
            KeyList.RemoveAt(index);
            ValueList.RemoveAt(index);
        }
        
        public void Sorted()
        {
            var KeyListNew = new List<TKey>();
            var ValueListNew = new List<TValue>();
            for(int i=0; i<KeyList.Count; i++)
            {
                for(int j=0; j<KeyList.Count-1; j++)
                {
                    var i1 = Int32.Parse(KeyList[j].ToString());
                    var i2 = Int32.Parse(KeyList[j+1].ToString());
                    if (i1 > i2)
                    {
                        var buf1 = KeyList[j];
                        var buf2 = ValueList[j];
                        KeyList[j] = KeyList[j + 1];
                        ValueList[j] = ValueList[j + 1];
                        KeyList[j + 1] = buf1;
                        ValueList[j + 1] = buf2;
                    }
                }
            }
            
        }
        
        public void Print()
        {
            for (int i = 0; i < KeyList.Count; i++)
                Console.WriteLine("{0} : {1}", KeyList[i].ToString(), ValueList[i]);
        }
    }
}
