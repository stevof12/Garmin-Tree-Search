//Steven Ferrarese
//Steven.Ferrarese@maine.edu
//Garmin Tree Search C++
//10/21/2017

#include "Node.cpp"
#include <iostream>

int TreeSearch(Node tree,string find)
{
		int x = 0;
		if (tree.toString() == find)
		{
			cout<<"We Found: "<< tree.toString()<<endl;
			return 1;
		}
		while (tree.getNode(x).toString() != "" )
		{
			cout <<tree.toString()<<endl;
			if (TreeSearch(tree.getNode(x),find) == 1)
			{
				return true;
			}
			x++;
		}
		if (tree.getNode(0).toString() == "")
		{
			cout << tree.toString() <<endl<<endl;
		}
		return 0;
		
}

int main()
{
	Node nn , n = Node("A1"),n2 = Node("D1"),n3 = Node("E1");
	nn = Node("Start");
		
	n2.addNode(n3);
	n.addNode(n2);
	nn.addNode(n);
	
	n2 = Node("B1");
	n = Node("A2");
	n2.addNode(Node("Find Me"));
	n.addNode(n2);
		
	n2 = Node("B2");
	n2.addNode(Node("C1"));
	n.addNode(n2);
	nn.addNode(n);

	TreeSearch(nn,"Find Me");		

	return 0;
}
