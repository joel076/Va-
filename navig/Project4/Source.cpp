#include <conio.h>
#include <iostream>
#include <windows.h>
#include <string>
using namespace std;

#define KEY_UP 72
#define KEY_DOWN 80
#define KEY_LEFT 75
#define KEY_RIGHT 77
void screen() {
system("cls");
	cout << "google" << endl;
	cout << "help" << endl;
	cout << "quit" << endl;

}
void StartProgram(string filename)
{
	ShellExecute(NULL,"open",filename.c_str(),NULL,NULL,SW_SHOWNORMAL);
}
int main()
{
	cout << "google" << endl;
	cout << "help" << endl;
	cout << "quit" << endl;
    int choosen1;
	choosen1 = 1;
	
	
	
	int c = 0;
	while (1)
	{
		c = 0;

		switch ((c = _getch())) {
		case KEY_UP:
			choosen1--;
			if (choosen1 == 1) {
				system("cls");
				cout << "google-" << endl;
				cout << "help" << endl;
				cout << "quit" << endl;

			}

			else if (choosen1 == 2) {
				system("cls");
				cout << "google" << endl;
				cout << "help-" << endl;
				cout << "quit" << endl;

			}

			else if (choosen1 == 3) {
				system("cls");
				cout << "google" << endl;
				cout << "help" << endl;
				cout << "quit-" << endl;
			}
			else if(choosen1 >= 4){
			choosen1 = 3;
			
			}
			else if (choosen1 <= 0) {
				choosen1 = 1;

			}
			break;
		case KEY_DOWN:
			choosen1++;
			if (choosen1 == 1) {
				system("cls");
				cout << "google-" << endl;
				cout << "help" << endl;
				cout << "quit" << endl;

			}

			else if (choosen1 == 2) {
				system("cls");
				cout << "google" << endl;
				cout << "help-" << endl;
				cout << "quit" << endl;

			}

			else if (choosen1 == 3) {
				system("cls");
				cout << "google" << endl;
				cout << "help" << endl;
				cout << "quit-" << endl;
			}
			else if (choosen1 >= 4) {
				choosen1 = 3;

			}
			else if (choosen1 <= 0) {
				choosen1 = 1;
}
		break;
		case KEY_RIGHT:
			
			if (choosen1 == 1) {
			    system("cls");
				StartProgram("iexplore");

			}

			else if (choosen1 == 2) {
				
				cout << "Do you really need help" << endl;

			}

			else if (choosen1 == 3) {
				system("cls");
				
				return 0;
			}
			
			break;
		case KEY_LEFT:

			screen();
			break;
		}
		}
		
	
	

	return 0;
}