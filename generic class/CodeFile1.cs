using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class myCollection<T>
{
    private T[] items;
    private int Length;
    public myCollection()
    {

    }
    public myCollection(int Length)
    {
        this.Length = Length;
        this.items = new T[Length];
    }
    public T this[int index]
    {

        get
        {
            var element = items[index];

            return element;
        }
        set
        {
            if ((index >= 0) && (index < 9))


                items[index + 1] = value;

            else
                if ((index <= 0) && ((index < 9) && (index >= -10)))


                items[10 - (System.Math.Abs(index))] = value;
        }

    }
}



namespace generic_class
{
    class program
    {

        static void Main(string[] args)
        {
            myCollection<int> positiveIndexarray = new myCollection<int>(10);
            myCollection<int> negativeIndexarray = new myCollection<int>(10);
            for (int count = 0; count <= 9; count++)
            {
                positiveIndexarray[count] = count + 1;
            }

            Console.WriteLine("The output when index is positive");

            for (int num = 0; num < 10; num++)
            {
                Console.WriteLine(positiveIndexarray[num]);
            }

            Console.WriteLine("The output when index is Negative");

            for (int count = 0; count >= -9; count--)
            {
                negativeIndexarray[count] = positiveIndexarray[System.Math.Abs(count)];

            }
            for (int count = 0; count <= 9; count++)
            {
                Console.WriteLine(negativeIndexarray[count]);
            }

            Console.ReadKey();
        }
    }
}










