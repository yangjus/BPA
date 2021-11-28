//============================================================================
// Name        : Regional2014ProgramBPA.cpp
// Author      : Justin Yang
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================

#include <iostream>
#include <fstream>
#include <string>	//string(n, char) function
using namespace std;

void display_inventory() {
	ifstream inFile;
	string line;

	inFile.open("gameinventory.txt");

	if (inFile.fail()) {
		cout << "File not found! Exiting..." << endl;	//File Exception Handling
		return;
	}
	while (inFile.good()) {		//loops until no more lines to read
		getline(inFile, line);	//Reads one line at a time
		cout << line << endl;
	}
	cout << endl;
	system("pause");
	return;
}

void add_item() {
	string item;
	int cost;
	int quantity;

	cout << "Enter the name for this new item: ";
	cin >> item;
	cin.ignore(80, '\n');	//ignores the next 80 input characters until a newline is read/inputted
	cout << "Enter unit cost for this item: ";
	cin >> cost;
	cin.ignore(80, '\n');
	cout << "Enter quantity in stock for this item: ";
	cin >> quantity;
	cin.ignore(80, '\n');

	ofstream outFile;	//creates output file object
	outFile.open("gameinventory.txt", ios::app);	//includes ios::app for file appending

	//commit data to file
	outFile << endl << item << "\t" << cost << "\t" << quantity;
	outFile.close();	//close file

	cout << "Item added to the inventory!" << endl;
	system("pause");
	return;
}

int main() {

	bool flag = false;
	char choice;
	do {
		cout << string(50, '*') << endl;	//repeats char n amount of times
		cout << endl << "Game Item Inventory" << endl;
		cout << endl << string(50, '*') << endl;
		cout << endl << "[d] Display all the inventory from file." << endl;
		cout << "[a] Append an item to the inventory file." << endl;
		cout << "[q] Quit and commit changes to file." << endl << endl;
		cout << "Choice <enter upper or lowercase letter option>: " << flush;
		cin >> choice;

		switch (choice) {
		case 'd':
		case 'D':
			cout << string(30, '\n');
			display_inventory();
			cout << string(30, '\n');
			break;
		case 'a':
		case 'A':
			cout << string(30, '\n');
			add_item();
			cout << string(30, '\n');
			break;
		case 'q':
		case 'Q':
			flag = true;
			cout << "Saving changes to file. Shutting down..." << endl;
			break;
		default:
			cout << "Invalid selection. " << flush;
			system("pause");
			//cin.ignore();	//ignores the newlines created
			//cin.get();		//recieves any char inputted
			cout << string(50, '\n');	//makes it seem like system("cls")
		}

	} while (flag == false);

	return 0;
}
