#include<iostream>
#include<stdlib.h>
#include<string.h>

using namespace std;

class student //class and struct are almost the same thing
{
    public:
    int m_stdnum;
    char m_firstname[20];
    char m_lastname[20];
    double m_GPA;
    int m_coursesPassed;
    int m_credits[40];
    double m_grade[40];
    char* m_courseName[40];

    double getGPA()
    {
        double sumcredit = 0;
        int sumgrade = 0;
        for (int i = 0; i <m_coursesPassed ; i++)
        {
            sumgrade += m_credits[i] * m_grade[i];
            sumcredit += m_credits[i];
        }
        return sumgrade/sumcredit;
    }
    
    void list_course()
    {
        for (int i = 0; i <m_coursesPassed ; i++)
        {
            cout<< m_courseName[i]<<" : "<<m_credits[i] << " : "<< m_grade[i]<< endl;
        }
    }

    void register_course(int credit, const char* name, double grade)
    {
        m_credits[m_coursesPassed] = credit;
        m_grade[m_coursesPassed]= grade;
        m_courseName[m_coursesPassed] = name;
        m_coursesPassed++;
    }
};





int main()
{
     student s;
     s.m_coursesPassed = 0;

     char bufc[20];
     double grade;
     int credit;
     while(true)
     {
        cout << "course name?";
        cin >> bufc ;
        if(*bufc == 'A')
            break;
        cout << "course credit?";
        cin >> credit ;
        cout << "course grade?";
        cin >> grade ;

     }
     cout<< s.getGPA()<< endl;
     return 0;
}