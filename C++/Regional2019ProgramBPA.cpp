//============================================================================
// Name        : Regional2019ProgramBPA.cpp
// Author      : Justin Yang
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================

#include <iostream>
#include <iomanip> //setw() function
#include <string>	//for getline and getchar

using namespace std;

int* menu_collect() {	//include the pointer (the astrick) for array transfer
	int Dept;
	static int studentNumber[11]; //allows for transfer of array to main function using static
	cout << setw(40) << "Up Town University" << endl << endl;
	cout << setw(35) << "0. English Department" << endl;
	cout << setw(35) << "1. Mathematics Department" << endl;
	cout << setw(35) << "2. Computer Science Department" << endl;
	cout << setw(35) << "3. Business Department" << endl;
	cout << setw(35) << "4. Kinesiology Department" << endl;
	cout << setw(35) << "5. Architecture Department" << endl;
	cout << setw(35) << "6. Biology Department" << endl;
	cout << setw(35) << "7. Education Department" << endl;
	cout << setw(35) << "8. Chemistry Department" << endl;
	cout << setw(35) << "9. Engineering Department" << endl << endl;
	cout << "Please pick the department: " << flush;
	cin >> Dept;
	if (Dept < 0 || Dept > 9) {
		cout << "Please enter a correct department number (0-9)" << endl;
		menu_collect();
	}
	cout << endl;
	for (int i = 0; i < 10; i++) {
		do {
			cout << "Class sizes are from 0 - 40 students: " << endl;
			cout << Dept << "0" << i << " ";
			cin >> studentNumber[i];
			if (studentNumber[i] < 0 || studentNumber[i] > 40) {
				cout << "Please enter valid numbers only from 0 to 40." << endl;
			}
		} while (studentNumber[i] < 0 || studentNumber[i] > 40);
	}
	studentNumber[11] = Dept;	//Allow for department # to be used in graphs without returning 2 variables

	return studentNumber;
}

void horizontal_graph(int department, int arr[]) {
	string Trash;		//clean buffer so getchar works
	getline (cin, Trash);	//clean buffer so get char works
	cout << "Department" << setw(79) << "Students" << endl;
	int i;
	int spacing = 0;
	string temp;
	for (i = 0; i < 9; i++) {
		cout << department << "0" << i << "  ";
		for (int j = 0; j < arr[i]; j++) {
			cout << "*";
		}
		spacing = arr[i];
		cout << setw(80 - spacing) << arr[i] << endl; //spacing used for formatting graph
	}
	cout << endl;
	cout << setw(40) << "Press ENTER to see Vertical Graph." << endl;
	getchar();	//holds message screen until user presses Enter
}

void vertical_graph(int department, int arr[]) {
	cout << "Students" << endl << endl;
	int highest = arr[0];
	for (int check = 0; check < 9; check++) {	//formats highest number of students as the highest y value of graph
		if (arr[check] > highest) {
			highest = arr[check];
		}
	}

	for (int rows = highest; rows >= 1; rows--) {	//formatting vertical graph
		for (int cols = 0; cols <= 9; cols++) {
			if (arr[cols] >= rows)
				cout << "* ";
			else
				cout << "  ";
		}
		cout << endl;
	}
	cout << endl;
	for (int deptNumber = 0; deptNumber < 10; deptNumber++)		//for making department number
		cout << department << " ";
	cout << endl;
	for (int i = 0; i < 10; i++)
		cout << "0 ";
	cout << endl;
	for (int cols = 0; cols < 10; cols++)
		cout << cols << " ";
	cout << endl;
}

int main() {

	int* studentNumber = menu_collect();	//include astrick for array transfer

	int Dept = studentNumber[11];	//stores department number
	horizontal_graph(Dept, studentNumber);
	vertical_graph(Dept, studentNumber);

	return 0;
}
