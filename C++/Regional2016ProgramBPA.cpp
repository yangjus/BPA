//============================================================================
// Name        : Regional2016ProgramBPA.cpp
// Author      : Justin Yang
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================

#include <iostream>
#include <string>	//for string(n, char) function
#include <vector>	//for divisors
#include <algorithm>	//for_each
using namespace std;

void generateFibonacciNumbers() {
	int number[21];	//array of 20 elements
	number[1] = 1;	//n=1 fibonacci number
	number[2] = 1;	//n=2 fibonacci number

	cout << "Fibonacci # 1 is: " << number[1] << endl;
	cout << "Fibonacci # 2 is: " << number[2] << endl;
	for (int i = 3; i < 21; i++) {
		number[i] = number[i-1] + number[i-2];	//current fibonacci number adds the sum of the last two values
		cout << "Fibonacci # " << i << " is: " << number[i] << endl;
	}
	cout << endl;
	system("pause");	//waits for user input
}

void generatePerfectNumbers() {	//debug: values are 6, 28, 496

	vector<int> divisors;
	int divisorSum = 0;
	cout << "Here are all the perfect numbers less than 1000:" << endl;

	for (int i = 1; i < 1001; i++) {
		for (int k = 1; k < i; k++) {	//solves for divisors (excludes i value itself)
			if (i % k == 0) {		//if remainder when divided by k = 0, then k is a divisor
				divisors.push_back(k);	//adds k value at the end of vector
			}
		}
		for_each (divisors.begin(), divisors.end(), [&] (int n) {	//sum of all divisors
			divisorSum += n;
		});
		/*
		 * Instead of for_each function, use accumulate function:
		 * #include <numeric>
		 *
		 * divisorSum = accumulate(divisors.begin(), divisors.end(), 0);
		 *
		 * first input, last input, initial start value
		 *
		 */
		if (i == divisorSum) {
			cout << i << endl;
		}
		divisors.erase(divisors.begin(), divisors.end()); //clears vector for next set of divisors
		divisorSum = 0;		//clears sum of divisors for next set
	}

	cout << endl;
	system("pause");
}

int main() {

	int choice;
	bool flag = false;	//create a condition for quitting program

	do {
		cout << endl;
		cout << string(50, '*') << endl;
		cout << "Special Number Generator" << endl;
		cout << string(50, '*') << endl;

		cout << "1) Calculate Fibonacci Numbers" << endl;
		cout << "2) Calculate Perfect Numbers" << endl;
		cout << "3) Exit Program" << endl;
		cout << "Please select an option: " << flush;
		cin >> choice;

		switch (choice) {
		case 1:
			generateFibonacciNumbers();	//calculates first 20 fibonacci numbers
			break;
		case 2:
			generatePerfectNumbers();	//generates output of all perfect numbers less than 1000
			break;
		case 3:
			flag = true;	//when condition is true, then loop ends
			cout << "Shutting down..." << endl;
			break;
		default:
			cout << "Invalid option entered." << endl;
			system("pause");	//waits for user input
		}
	} while (flag == false);

	return 0;
}
