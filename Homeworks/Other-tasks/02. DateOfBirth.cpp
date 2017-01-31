// 02. DateOfBirth.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	string egn, year, month, monthHelper, dayFirstDigit, daySecondDigit, gender, genderOutput;
	bool isMale;

	cin >> egn;

	year = egn.substr(0, 2);
	month = egn.substr(2, 2);
	monthHelper = egn.substr(3, 1);
	dayFirstDigit = egn.substr(4, 1);
	daySecondDigit = egn.substr(5, 1);
	gender = egn.substr(8, 1);

	int yearHelper = stoi(year),
		monthHelperAsInt = stoi(monthHelper),
		dayHelperFirstDigit = stoi(dayFirstDigit),
		birthDayHelperSecondDigit = stoi(daySecondDigit),
		genderHelper = stoi(gender),
		birthDayCheck = dayHelperFirstDigit * 10 + birthDayHelperSecondDigit;

	isMale = genderHelper % 2 == 0;
	genderOutput = isMale ? "M" : "F";

	if (((yearHelper % 4 == 0) && (yearHelper % 100 != 0)) || (yearHelper % 400 == 0)) {
		if (birthDayCheck >= 29) {
			cout << "Bad input data!\n";
		}
	}
	else {
		if (birthDayCheck >= 28) {
			cout << "Bad input data!\n";
		}
	}

	if (month[0] == '0' && monthHelperAsInt < 0) {
		cout << "Bad input data!" << endl;
	}
	else if (month[0] == '1' && (monthHelperAsInt < 0 || monthHelperAsInt > 2))
	{
		cout << "Bad input data!" << endl;
	}
	else if (dayHelperFirstDigit == 0 && (birthDayHelperSecondDigit < 0))
	{
		cout << "Bad input data!" << endl;
	}
	else if (dayHelperFirstDigit == 1 && birthDayHelperSecondDigit < 0)
	{
		cout << "Bad input data!" << endl;
	}
	else if (dayHelperFirstDigit == 2 && birthDayHelperSecondDigit < 0)
	{
		cout << "Bad input data!" << endl;
	}
	else if (dayHelperFirstDigit == 3 && (birthDayHelperSecondDigit < 0 || birthDayHelperSecondDigit>1))
	{
		cout << "Bad input data!" << endl;
	}
	else
	{
		cout << dayFirstDigit << daySecondDigit << '.' << month << '.' << "19" << year << ' ' << genderOutput << endl;
	}
}