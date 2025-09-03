#include<iostream>

using namespace std;

class MyStr
{
    public:
    int m_size;
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }
    ~MyStr()
    {
            delete[] m_PChars;
    }
    void printStr()
    {
        cout << m_PChars << endl;
    }

   bool checkSubstr(const  MyStr& s1)
    {
        int i;
        int j;
        for (i = 0; i <= m_size - s1.m_size ; i++)
        {
            bool flag = true;
            for (j = 0; j < s1.m_size - 1 ; j++)
            {
                if(m_PChars[j+i]!= s1.m_PChars[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                return true;
            }
        }
        return false;
    }

    int len()
    {
        int len=0;
        while (m_PChars[len] != '\0')
        {
            len++;
        }
        return len;
 
    }

    void add(const  MyStr& s1)
    {
    int new_size = m_size + s1.m_size - 1;
       char* newstr = new char[new_size];
       int i = 0;
       while (m_PChars[i] != '\0')
       {
        newstr[i] = m_PChars[i];
        i++;
       }
       int j = 0 ;
       while ( s1.m_PChars[j] != '\0')
       {
         newstr[i+j] = s1.m_PChars[j];
         j++;
       }
        newstr[i + j] = '\0';
        delete[] m_PChars;
        m_PChars = newstr;
        m_size = new_size;
    }    
};


int main()
{
    MyStr s1(".");

    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();

    cout<<boolalpha<<s2.checkSubstr("haji")<<endl; // TODO1

    cout<<s2.len()<<endl; //TODO2
    
   s2.add(s1); // TODO3 
   s2.printStr();
   
   return 0;
   
    
}