using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
    where T : IComparable<T>
    {
        private uint capacity;
        private uint count;
        private T[] list;

        private T[] List
        {
            get
            {
                return this.list;
            }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentOutOfRangeException("Index cannot be negative!");
                }
                else
                {
                    this.list = value;
                }
            }
        }

        public uint Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public uint Count
        {
            get
            {
                return this.count;
            }
        }

        public GenericList(int length = 0)
        {
            if (length >= int.MaxValue)
            {
                throw new ArgumentOutOfRangeException("The maximum number of elements you can add are 2147483646");
            }
            this.List = new T[length + 1];
            this.count = 0;
            if (length >= 0)
            {
                this.capacity = (uint)length;
            }
            else
            {
                throw new ArgumentOutOfRangeException("List capacity cannot be negative");
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < this.count && index >= 0)
                {
                    return this.list[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Format("Index {0} is invalid", index));
                }
            }
        }

        public void Add(T element)
        {
            if (this.capacity == 0)
            {
                this.capacity = 4;
                this.List = new T[4];
            }
            long doubleCapacity = this.capacity * 2;
            if (this.count == this.capacity && doubleCapacity < int.MaxValue)
            {
                T[] newList = new T[this.capacity * 2];
                for (int i = 0; i < this.count; i++)
                {
                    newList[i] = this.list[i];
                }
                this.List = newList;
                this.capacity *= 2;
            }
            if (count < int.MaxValue)
            {

                this.list[count] = element;
                count++;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cannot extend this list anymore");
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentOutOfRangeException("Index out of range of list");
            }
            else
            {
                for (int i = 0; i < this.list.Length - index - 1; i++)
                {
                    this.list[index + i] = this.list[index + i + 1];
                }
                this.count--;
            }
        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index > this.count)
            {
                throw new ArgumentOutOfRangeException("Index out of range of list");
            }
            else if (index == count)
            {
                this.Add(element);
            }
            else
            {
                this.Add(this.list[count - 1]);
                for (uint i = this.count - 2; i > index; i--)
                {
                    this.list[i] = this.list[i - 1];
                }
                this.list[index] = element;
            }
        }

        public void Clear()
        {
            this.list = new T[1];
            this.capacity = 0;
            this.count = 0;
        }

        public int Find(T value)
        {
            dynamic val = value;
            for (int i = 0; i < this.count; i++)
            {
                if (this.list[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }

        public T Min()
        {
            if (this.count > 0)
            {
                dynamic min = this.list[0];
                for (int i = 1; i < this.count; i++)
                {
                    if (min > this.list[i])
                    {
                        min = this.list[i];
                    }
                }
                return min;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The list is empty");
            }
        }

        public T Max()
        {
            if (this.count > 0)
            {
                dynamic max = this.list[0];
                for (int i = 1; i < this.count; i++)
                {
                    if (max < this.list[i])
                    {
                        max = this.list[i];
                    }
                }
                return max;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The list is empty");
            }
        }

        public override string ToString()
        {
            StringBuilder listInfo = new StringBuilder();
            listInfo.Append("{ ");
            for (int i = 0; i < this.count; i++)
            {
                if (i == this.count - 1)
                {
                    listInfo.Append(String.Format("{0} ", this.list[i].ToString()));
                }
                else
                {
                    listInfo.Append(String.Format("{0}, ", this.list[i].ToString()));
                }
            }
            listInfo.Append("}");
            return listInfo.ToString();
        }
    }
}
