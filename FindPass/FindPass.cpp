#include <iostream>
using namespace std;
int main()
{
	string pass;
	cout << "Enter a password: ";
	cin >> pass;
	if (pass == "bhf.io")
	{
		cout << "GOOD" << endl;
	}
	else cout << "BAD" << endl;
	system("pause");
}
