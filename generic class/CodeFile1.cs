using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class myCollection<Array>
{
    public Array[] collection;
    public int Length;
    public myCollection()
    {

    }
    public myCollection(int Length)
    {
        this.Length = Length;
        this.collection = new Array[Length];
    }
    public Array this[int index]
    {

        get
        {
            var element = collection[index];

            return element;
        }
        set
        {
            if ((index >= 0) && (index < 9))


                collection[index + 1] = value;

            else
                if ((index <= 0) && ((index < 9) && (index >= -10)))


                collection[10 - (System.Math.Abs(index))] = value;
        }

    }
}

namespace generic_class
{
    class Execution
    {

        static void Main(string[] args)
        {
            myCollection<int> positiveIndexarray = new myCollection<int>(10);
            myCollection<int> negativeIndexarray = new myCollection<int>(10);
            for (int positiveIndex = 0; positiveIndex <= 9; positiveIndex++)
            {
                positiveIndexarray[positiveIndex] = positiveIndex + 1;
            }

            Console.WriteLine("The output when index is positive");

            for (int positiveIndex = 0; positiveIndex < 10; positiveIndex++)
            {
                Console.WriteLine(positiveIndexarray[positiveIndex]);
            }

            Console.WriteLine("The output when index is Negative");

            for (int negativeIndex = 0; negativeIndex >= -9; negativeIndex--)
            {
                negativeIndexarray[negativeIndex] = positiveIndexarray[System.Math.Abs(negativeIndex)];

            }
            for (int negativeIndex = 0; negativeIndex <= 9; negativeIndex++)
            {
                Console.WriteLine(negativeIndexarray[negativeIndex]);
            }

            Console.ReadKey();
        }
    }
}










