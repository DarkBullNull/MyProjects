#include <iostream>
#include <ctime>
using namespace std;

int main()
{
	setlocale(LC_ALL, "");
	const int SIZE = 10;
	srand(time(NULL));
	int num[SIZE];
	num[0] = 0;
	int a = rand()%10;
		for (int i = 0; i < SIZE; i++)
		{
		New:
			for (int k = 0; k < SIZE; k++)
			{
				if (num[k] == a)
				{
					a = rand()%10;
					goto New;
				}
			}
			num[i] = a;
			cout << num[i] << endl;
			
		}
}