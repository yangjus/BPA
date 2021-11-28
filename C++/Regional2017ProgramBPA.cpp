//============================================================================
// Name        : Regional2017ProgramBPA.cpp
// Author      : Justin Yang
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================

#include <iostream>
#include <fstream>	//I/O file reading
#include <istream>	//ignore()
#include <string>
#include <sstream>	//for istringstream
using namespace std;

int main() {

	ifstream infile;	//read file
	infile.open("human_jabber.txt");

	string line;
	while(infile.good()) {
		getline(infile, line);
		cout << line << endl;
	}

	int count;
	infile >> count;
	infile.ignore(1, '\n');		//n = how many characters to skip after delimiter (" ")

	for (int i = 0; i < count; i++) {

	}

	return 0;
}
