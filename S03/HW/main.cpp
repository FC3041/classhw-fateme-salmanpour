#include<iostream>
#include<string.h>
using namespace std;
class Student
{
public:
    int m_stdNum;
    char m_FirstName[20];
    char m_LastName[20];
    // int m_CoursesPassed;
    // int m_Credits[40];
    // double m_Grades[40];
    // char* m_CourseNames[40];

    Student(int stdnum, const char* fname, const char* lname)
    {   
        
        m_stdNum = stdnum;
        char* fnamecopy = new char[strlen(fname) + 1];
        char* lnamecopy = new char[strlen(lname) + 1];
        fnamecopy = m_FirstName ;
        lnamecopy = m_LastName ;
        strcpy(fnamecopy, fname);
        strcpy(lnamecopy, lname);
        
       


    }
    ~Student()
    {   delete[] m_FirstName;
        delete[] m_LastName;
    } 
    // double GetGPA()
    // {
    //     double sumGrade = 0;
    //     int sumCredit = 0;
    //     for(int i=0; i<m_CoursesPassed; i++) {
    //         sumGrade += m_Credits[i] * m_Grades[i];
    //         sumCredit += m_Credits[i];
    //     }
    //     return sumGrade / sumCredit;
    // }

    // void list_courses()
    // {
    //     for(int i=0; i<m_CoursesPassed; i++) {
    //        cout << m_CourseNames[i] << ": "
    //                   << m_Credits[i] << " : "
    //                   << m_Grades[i] << endl;        
    //     }
    // }

    // void register_course(int credits, const char* name, double grade)
    // {
    //     m_Credits[m_CoursesPassed] = credits;
    //     m_Grades[m_CoursesPassed] = grade;
    //     char* namecopy = new char[strlen(name) + 1];
    //         //(char*) malloc(strlen(name) + 1);
    //     strcpy(namecopy, name);
    //     m_CourseNames[m_CoursesPassed] = namecopy;
    //     m_CoursesPassed++;
    // }
   
};

int main()
{
    // Student s(3423, "asdf", "lasdkfj");
    // Student* s2 = new Student(3423, "asdf", "lasdkfj");
    // Student* s3 = &s;
    // int * pn = new int[10];
    // s.m_CoursesPassed = 0;
    // char bufc[20];
    // double grade;
    // int credits;

    // while(true)
    // {
    //     cout << "course name?" ;
    //     cin >> bufc ;
    //     if (*bufc == 'A')
    //         break;
    //     cout << "course credits?" ;
    //     cin >> credits ;
    //     cout << "course grade?" ;
    //     cin >> grade ;
    //     s.register_course(credits, bufc, grade);
    // }
    // s.list_courses();
    // cout << s.GetGPA() << endl;
    Student s1(8247,"fateme", "salmanpour" );
    cout << "Student 1:" << endl;
    cout << "Student Number: " << s1.m_stdNum << endl;
    cout << "First Name: " << s1.m_FirstName << endl;
    cout << "Last Name: " << s1.m_LastName << endl;

    return 0;
}