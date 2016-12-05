
#include "stdafx.h"
#include<iostream>
using namespace std;

int main()
{
	int bill;
	cout << "Enter the bill: ";
	cin >> bill;
	cout << bill << " = ";
	int numberOf50 = bill / 50;
	bill %= 50;
	int numberOf20 = bill / 20;
	bill %= 20;
	int numberOf10 = bill / 10;
	bill %= 10;
	int numberOf5 = bill / 5;
	bill %= 5;
	int numberOf2 = bill / 2;
	bill %= 2;
	if (numberOf50 > 0)
	{
		cout << numberOf50 << "*50";
	}
	if (numberOf20 > 0)
	{
		cout << " + " << numberOf20 << "*20";
	}
	if (numberOf10 > 0)
	{
		cout << " + " << numberOf10 << "*10";
	}
	if (numberOf5 > 0)
	{
		cout << " + " << numberOf5 << "*5";
	}
	if (numberOf2 > 0)
	{
		cout << " + " << numberOf2 << "*2";
	}
	if (bill > 0)
	{
		cout << " + " << bill << "*1\n";
	}
	return 0;
}