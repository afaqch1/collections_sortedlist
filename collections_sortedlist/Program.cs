using System;
using System.Collections.Generic;

namespace collections_list
{
    class Program
    {
        public static void show(SortedList<int,string> list)
        {
            foreach (var i in list)
            {
                System.Console.WriteLine("Key:"+i.Key+" "+"Value:"+i.Value);
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {

            SortedList<int,string> list = new SortedList<int,string>();
            list.Add(5,"Pak");
            list.Add(2,"Ind");
            list.Add(1,"Afg");
            list.Add(3,"Chi");
            list.Add(4, "Ira");

            System.Console.WriteLine("//////////////////SortedList////////////////////");
            show(list);

            System.Console.WriteLine("//////////////////Remove///////////////////");
            list.RemoveAt(4);
            show(list);

            System.Console.WriteLine("//////////////////Add new values////////////////////");
            list.Add(8, "UAE");
            list.Add(7, "USA");
            list.Add(6, "UK");
            list.Add(9, "AUS");
            show(list);

            System.Console.WriteLine("//////////////////Contains////////////////////");
            if (list.ContainsKey(7))
            {
               list.TryGetValue(7, out string value);
                System.Console.WriteLine("key 7 has value:" + value);
            }



        }
    }
}
