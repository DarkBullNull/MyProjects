#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Ru");
	int a = 1, b = 2;
	int *num1 = &a;
	int *num2 = &b;
	printf("a" + *num1);
	*num1 = *num2;
	system("pause");
}