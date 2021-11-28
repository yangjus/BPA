//============================================================================
// Name        : Regional2015ProgramBPA.cpp
// Author      : Justin Yang
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================

#include <iostream>
#include <iomanip>	//setprecision(), setw()
#include <string>
using namespace std;

double valueOfLeibnizSeries(double nlimit) {		//function to calculate Leibniz based on n value

	double calculatedValue = 0.0;

	calculatedValue = 1;

		for (int n = 1; n <= nlimit; n++) {		//starts at n=1, since calculatedValue = 1 at n=0
			if ((n % 2) == 0) {			//even n values add to calculatedValue, odd n values subtract
				calculatedValue = calculatedValue + ((double)1 / ((2 * n) + 1));
			}
			else {
				calculatedValue = calculatedValue - ((double)1 / ((2 * n) + 1));
			}
		}

	return (double)4 * calculatedValue;		//since calculatedValue is Pi/4
}

void difference(double TRUEPi, double Leibniz_Pi) {		//function for solving the difference between Pi and Leibniz
	double difference;
	cout << left << setw(55) << "The difference between PI and the Leibniz Series: ";
	if 	(TRUEPi > Leibniz_Pi) {
		difference = TRUEPi - Leibniz_Pi;
	}
	else
		difference = Leibniz_Pi - TRUEPi;
	cout << right << setprecision(15) << fixed << difference << endl;		//fixed helps get rid of scientific notation
}


int main() {
	double truePi = 3.141592653589793;
	double valueOne = (double)22 / (double)7;	//cast operands to double in order to display decimal value
	double valueTwo = (double)355 / (double)113;
	long int n;
	int format = 55;
	int decimalPlace = 15;

	//first group
	cout << left << setw(format) << "The value of n in the Leibniz Series: ";	//left is used to align string on the left side
	do {
		cin >> n;
		if (n < 0) {
			cout << "Please input a non-negative integer." << endl;
		}
	} while (n < 0);	//loop is repeated until non-negative integer is achieved

	double LeibnizPi = valueOfLeibnizSeries(n);		//solves for Leibniz value at n
	cout << left << setw(format) << "The Leibniz Series approximation of PI at n is: ";	//setw sets the width of cout,
																						//and if string is less than the setw then
	cout << right << setprecision(decimalPlace) << fixed << LeibnizPi << endl << endl;	//the leftover width will be blank spaces

	//second group
	cout << left << setw(format) << "The known value of PI to 15 decimal points: ";
	cout << right << setprecision(decimalPlace) << truePi << endl;						//'right' aligns the values to the right side
	difference (truePi, LeibnizPi);
	cout << endl;

	//third group
	cout << left << setw(format) << "The approximation of PI using 22 / 7: ";
	cout << right << setprecision(decimalPlace) << valueOne << endl;
	difference (valueOne, LeibnizPi);
	cout << endl;

	//fourth group
	cout << left << setw(format) << "The approximation of PI using 355 / 113: ";
	cout << right << setprecision(15) << valueTwo << endl;
	difference (valueTwo, LeibnizPi);

	return 0;
}
