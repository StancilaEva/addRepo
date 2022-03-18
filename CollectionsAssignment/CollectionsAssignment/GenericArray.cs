using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    public class GenericArray<T>
    {
        T[] genericArray;
        public int Length { get; }

        public GenericArray()
        {

        }

       public GenericArray(T[] arr)
        {
            genericArray = new T[arr.Length];
            Length = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                genericArray[i] = arr[i];
            }
            
        }

        public T get(int index)
        {
            if(index>=0&&index<genericArray.Length)return genericArray[index];
            else throw new IndexOutOfRangeException();
        }

        public void set(int index,T value)
        {
            if (index >= 0 && index < genericArray.Length)
                genericArray[index] = value;
            else
                throw new IndexOutOfRangeException();
        }

        public void swap (int index1,int index2)
        {
            if( (index1 >= 0 && index1 < genericArray.Length) && (index2 >= 0 && index2 < genericArray.Length))
            {
                T aux = genericArray[index1]; 
                genericArray[index1] = genericArray[index2];
                genericArray[index2] = aux;
            }
        }
    }
}
