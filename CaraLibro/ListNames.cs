using System;
using System.Collections.Generic;
using System.Text;

namespace CaraLibro
{
    class ListNames
    {
        private readonly List<Tuple<string, string>> nombres;

        public ListNames()
        {
            nombres = new List<Tuple<string, string>>();
            nombres.Add(new Tuple<string, string>("Juan", "Pedro"));
            nombres.Add(new Tuple<string, string>("Juan", "Fernando"));
            nombres.Add(new Tuple<string, string>("Fernando", "Maria"));
            nombres.Add(new Tuple<string, string>("Maria", "Clara"));
        }


        public List<string> Saludar(string name1, string name2)
        {
            List<string> ListNames = new List<string>();
            if (name1 == name2)
            {
                ListNames.Add(name1);
                return ListNames;
                //Console.WriteLine($"{tuple.Item1} saluda a {tuple.Item2}");
            }
            foreach (var tuple in nombres)
            {
                if (tuple.Item2 == name1)
                {
                    if (ListNames.Contains(name1))
                    {
                        ListNames.Add(name1);
                    }
                    
                    ListNames.AddRange(Saludar(tuple.Item1, name2));
                }
                //Saludar(tuple.Item2, name2);
            }
           
            return ListNames;
        }

        //= new List<Tuple<string, string>>();

    }
}
