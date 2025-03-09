#include<vector>
#include<iostream>
#include<string>
#include<stdio.h>
#include<Windows.h>

// RAII
// Resource Acquisition Is Initialization

using namespace std;

class keeptime
{
    string information; 
    unsigned long long start; 
    
    public:
         keeptime(string info) : information(info)
        {
            start = GetTickCount64();
        }

    
    ~keeptime()
    {
        unsigned long long end = GetTickCount64();
        unsigned long long du = end - start;
        cout << information << " : " << du <<  endl;
    }

};

bool inst = false;
int main()
{
    {
        keeptime t("for loop 365 double mul");
        double d = 2;
        for(int i=0; i<1000000; i++)
            d = d * 1.01;
        return 0;
    }

}

