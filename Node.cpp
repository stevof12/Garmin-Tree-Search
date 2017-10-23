//Steven Ferrarese
//Steven.Ferrarese@maine.edu
//Garmin Tree Search C++
//10/21/2017

#include <iostream>
#include <string>
#include <vector>
using namespace std;
class Node
{
   public:
	string name;
	vector<Node> child;
	Node();
	Node(string);
	void addNode(Node);
	Node getNode(int);
	string toString();
 
};

Node :: Node()
{

	name = "";
}
Node ::Node(string n)
{
	name = n;
}
void Node ::addNode(Node n1)
{
	child.push_back(n1);
}
Node Node :: getNode(int x)
{
	if(child.size() > x)
	{
		return child.at(x);
	}
	else 
	{
		return Node("");
	}
}
string Node ::toString()
{
	return name;
}
