#include <iostream>
#include <Windows.h>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Ru");
	int varInt = 123456;
	string varString = "DefaultString";
	char arrChar[128] = 
	{ 
		'L','o','n','g',
		' ', 'c', 'h', 'a', 'r', ' ', 
		'a', 'r', 'r', 'a', 'y', ' ', 
		'r', 'i', 'g', 'h', 't', ' ', 
		'h', 'e', 'r', 'e', ' ',
		'-','>', 
	};
	int *pvarInt = &varInt;
	int *pvarString = (int*)&varString;
	int *parrChar = (int*)&arrChar;
	DWORD prVers = GetCurrentProcessId();
	cout << "Process ID: " << prVers << endl;
	cout << "\nvarInt = 0x" << pvarInt << " = " << *pvarInt << endl;
	cout << "varString = 0x" << pvarString << " = " << *pvarString << endl;
	cout << "arrChar[128] = 0x" << parrChar << " = " << arrChar  << endl;
	system("pause");
}


