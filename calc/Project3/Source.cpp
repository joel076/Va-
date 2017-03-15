#include <iostream>
#include <windows.h>
#include <string>
#include <cmath>
#include <ctime>
using namespace std;
int calc() {
	double a;
	double b;
	a = 0;
	b = 0;
	int r;
	r = 1;
	int y;
	y = 5;
	string question;

	while (y != 6) {
		cout << "Minus,plus,division,multiplication or quit the program. >>";
		cin >> question;

		if (question == "minus") {
			cout << "You choosed minus." << endl;
			cout << "Put in first number. >>";
			cin >> a;
			cout << "Minus. >>";
			cin >> b;
			cout << "Difference:" << a - b << endl;

		}
		else if (question == "quit") {
			
		}
		else if (question == "plus") {
			cout << "You choosed plus." << endl;
			cout << "Put in first number. >>";
			cin >> a;
			cout << "Plus. >>";
			cin >> b;
			cout << "Difference:" << a + b << endl;
		}
		else if (question == "multiplication") {
			cout << "You choosed multiplication." << endl;
			cout << "Put in first number. >>";
			cin >> a;
			cout << "Multiplied by. >>";
			cin >> b;
			cout << "Difference:" << a * b << endl;
		}
		else if (question == "division") {
			cout << "You choosed division." << endl;
			cout << "Put in first number. >>";
			cin >> a;
			cout << "Divided by. >>";
			cin >> b;
			cout << "Difference:" << a / b << endl;
		}
		else {
			cout << "I did not understand please type again" << endl;
		}
	}
	system("pause");
	
	return 0;
}
int main()
{
   HANDLE h = GetStdHandle( STD_OUTPUT_HANDLE );
   SetConsoleTextAttribute(h,FOREGROUND_GREEN | FOREGROUND_INTENSITY);

   int regular[5] = {4,3,8,2,9};
   int multi[5][5];
   multi [0][0] = 10;
   multi [0][1] = 9;
   srand(time(NULL));
   for(int i = 0; i < 11; i++)
   cout  << rand() % 10 << endl;
   

   calc();

   system("pause");
   return 0;
}