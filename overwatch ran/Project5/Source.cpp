#include <iostream>
#include <windows.h>
#include <string>
#include <ctime>
#include <cmath>
#include <stdlib.h>
using namespace std;

int main() {
string heroes[23] ={"Genji","Mccree","Pharah","Reaper","Soldier:76","Sombra","Tracer","Bastion","Hanzo","Junkrat","Mei","Torbjörn",
"Widowmaker","D.VA","Reinhardt","Roadhog","Winston","Zarya","Ana","Lucio","Zenyatta","Symmetra","Mercy"};
string test;
string extra;
bool bool1 = true;
bool bool2 = true;
bool bool3 = false;
srand(time(NULL));
int i;
string rand1;
while(bool3 == false)
bool3 = true;
cout << "Do you want to include Mercy? (y/n)" << endl;
cin >> extra;
if(extra == "y"){
bool3 = true;
while(bool1 == true){
bool2 = true;
i = rand() % 23;
rand1 = heroes[i];
cout << rand1 << endl;
while (bool2 == true) {
cin >> test;
if (test == "start") {
	bool2 = false;
}
else if (test == "quit") {
return 0;

}
else {
cout << "I did not understand." << endl;
}
}
}
}
else if(extra == "n"){
bool3 = true;
while (bool1 == true) {
	bool2 = true;
	i = rand() % 22;
	rand1 = heroes[i];
	cout << rand1 << endl;
	while (bool2 == true) {
		cin >> test;
		if (test == "start") {
			bool2 = false;
		}
		else if (test == "quit") {
			return 0;

		}
		else {
			cout << "I did not understand." << endl;
		}
	}
}


}



}