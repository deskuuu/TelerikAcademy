#include <iostream>
using namespace std;
 
int main() {
   
    string name,
           cutName,
           otherPart;
 
    int counter,
        length,
        position;
   
    cin >> name;
    cin >> counter;
   
    length = name.length();
    position = length - counter;
       
    for(int index=position;index<length;index++){
        cutName+=name[index];
    }
 
    for(int index=0;index<position;index++){
        otherPart+=name[index];
    }
 
    cout << cutName+otherPart;
   
    return 0;
}