#include<iostream>
#include <string>
#include <array>
#include <list>

using namespace std;

bool IsPrime(int num);
bool IsEven(int num);

int main()
{
    int num;
    /*string arr[];
    list<string> _list;
    arr[] = {"Marc","Alder","Delma"};
    _list = {arr};
    cout << _list << endl;*/
    cout << "Digite um numero para saber se eh primo ou nao ou digite -1." << endl;
    cin >> num;

    
    while(num != -1){
        if(num==0){
            cout << "\t" << num << " eh nullo.\n";
        }
        else if(IsPrime(num) && IsEven(num))
        {
            cout << "\t" << num << " eh primo e par.\n";
        }
        else if(IsPrime(num) && !IsEven(num))
        {
            cout << "\t" << num << " eh primo e impar.\n";
        }
        else if(IsEven(num))
        {
            cout << "\t" << num << " eh par.\n";
        }       
        else
        {
            cout << "\t" << num << " eh impar.\n";
        }
        cout << "Digite um outro numero ou -1\n";
        cin >> num;
   }
    
    system("pause");
    return 0;
}
bool IsPrime(int num){    
    for(int i = 2; i < num; i++)
        if (num % i == 0)
            return false;
        return true;
}
bool IsEven(int num){
    
    if (num % 2 != 0) 
        return false;
    
    return true;
}