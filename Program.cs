//Steven Ferrarese
//Steven.Ferrarese@maine.edu
//Garmin Tree Search
//10/21/2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Node
    {
        public string Name { get; set; }
        public List<Node> Children { get; set; }
    }
    class Program
    {
        static bool TreeSearch(Node tree, string find)
        {
            if (tree.Children == null)
            {
                Console.WriteLine("{0}", tree.Name);
                if (String.Equals(tree.Name, find))
                {
                    Console.WriteLine("We Found: {0}", tree.Name);
                    return true;
                }
            }
            else
            {
                string ss = "" ;
                int x = 0, count = tree.Children.Count;
                if (String.Equals(tree.Name, find))
                {
                    Console.WriteLine("We Found: {0}", tree.Name);
                    return true;
                }
                while (x < count)
                {
                    ss = tree.Name;
                    Console.WriteLine("{0}",ss);
                    
                    if (TreeSearch(tree.Children.ElementAt(x), find))
                    {
                        return true;
                    }
                    x++;
                }
            }
           
            return false;

        }


        static void Main(string[] args)
        {
            Node nn = new Node(), n = new Node(), n2 = new Node(), n3 = new Node(), n4 = new Node();
            Node an = new Node(), a = new Node(), a2 = new Node(), a3 = new Node(), a4 = new Node();
            Node cn = new Node(), c = new Node(), c2 = new Node(), c3 = new Node(), c4 = new Node();

            nn.Name = "Start";


            c2.Children = new List<Node>();
            c.Children = new List<Node>();
            cn.Children = new List<Node>();
            a2.Children = new List<Node>();
            a.Children = new List<Node>();
            an.Children = new List<Node>();
            n2.Children = new List<Node>();
            n.Children = new List<Node>();
            nn.Children = new List<Node>();
            Node nn1 = new Node(), nn2 = new Node();
            nn1.Children = new List<Node>();
            nn2.Children = new List<Node>();

            n4.Name = "E1";
            n2.Name = "D1";
            n.Name = "A1";

            n2.Children.Add(n4);
            n.Children.Add(n2);
            nn2.Children.Add(n);


            a3.Name = "C1";
            a2.Name = "B2";
            
            a2.Children.Add(a3);

            c3.Name = "Find Me";
            c2.Name = "B1";

            c2.Children.Add(c3);

            Node[] nnn1 = { c2, a2 };

            nn1.Name = "A2";
            nn1.Children.AddRange(nnn1);

            Node[] nnn = {nn2,nn1 };
            
            nn.Children.AddRange(nnn);
           
            TreeSearch(nn, "Find Me");
            while (1 == 1) ;


        }
    }
}
