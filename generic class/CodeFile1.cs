using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class myCollection<Array>
{
    public Array[] items;
    public int Length;
    public myCollection()
    {

    }
    public myCollection(int Length)
    {
        this.Length = Length;
        this.items = new Array[Length];
    }
    public Array this[int index]
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
            for (int index = 0; index <= 9; index++)
            {
                positiveIndexarray[index] = index + 1;
            }

            Console.WriteLine("The output when index is positive");

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(positiveIndexarray[index]);
            }

            Console.WriteLine("The output when index is Negative");

            for (int index = 0; index >= -9; index--)
            {
                negativeIndexarray[index] = positiveIndexarray[System.Math.Abs(index)];

            }
            for (int index = 0; index <= 9; index++)
            {
                Console.WriteLine(negativeIndexarray[index]);
            }

            Console.ReadKey();
        }
    }
}










