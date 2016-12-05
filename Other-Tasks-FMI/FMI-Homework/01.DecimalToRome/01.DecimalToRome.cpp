// FMI-Homeworks.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int inDecimal;
	string inRome;

	cin >> inDecimal;

	if (inDecimal < 0 || inDecimal > 3000) {
		cout << "Invalid number!" << endl;
	}
	else
	{
		int thousandth = inDecimal / 1000;
		int hundredth = (inDecimal % 1000) / 100;
		int decimal = (inDecimal % 100) / 10;
		int last = (inDecimal % 10) / 1;

		if (thousandth == 1) {
			inRome = "M";
		}
		else if (thousandth == 2)
		{
			inRome = "MM";
		}

		switch (hundredth)
		{
		case 1:inRome += "C"; break;
		case 2:inRome += "CC"; break;
		case 3:inRome += "CCC"; break;
		case 4:inRome += "CD"; break;
		case 5:inRome += "D"; break;
		case 6:inRome += "DC"; break;
		case 7:inRome += "DCC"; break;
		case 8:inRome += "DCCC"; break;
		case 9:inRome += "CM"; break;
		default: inRome += "";
			break;
		}

		switch (decimal)
		{
		case 1:inRome += "X"; break;
		case 2:inRome += "XX"; break;
		case 3:inRome += "XXX"; break;
		case 4:inRome += "XL"; break;
		case 5:inRome += "L"; break;
		case 6:inRome += "LX"; break;
		case 7:inRome += "LXX"; break;
		case 8:inRome += "LXXX"; break;
		case 9:inRome += "XC"; break;
		default:inRome += "";
			break;
		}

		switch (last)
		{
		case 1:inRome += "I"; break;
		case 2:inRome += "II"; break;
		case 3:inRome += "III"; break;
		case 4:inRome += "IV"; break;
		case 5:inRome += "V"; break;
		case 6:inRome += "VI"; break;
		case 7:inRome += "VII"; break;
		case 8:inRome += "VIII"; break;
		case 9:inRome += "IX"; break;
		default:inRome += "";
			break;
		}

		cout << inRome << endl;
	}
}

