#include <iostream>
using namespace std;
int main()
{
	string pass;
	cout << "Enter a password: ";
	cin >> pass;
	if (pass == "Dark_Bull")
	{
		cout << "GOOD" << endl;
	}
	else cout << "BAD" << endl;
	system("pause");
}
