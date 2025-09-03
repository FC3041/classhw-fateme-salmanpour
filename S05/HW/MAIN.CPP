#include <iostream>
using namespace std;

class MyList {
public:
    int m_size;
    int m_capacity;
    int* m_Pnums;

    MyList(int size, int* nums) : m_size(size), m_capacity(size) {
        m_Pnums = new int[m_capacity];
        for (int i = 0; i < m_size; i++) {
            m_Pnums[i] = nums[i];
        }
    }

    
    ~MyList() {
        delete[] m_Pnums;
    }

    void append(int x) {
        if (m_size >= m_capacity) {
            resize(m_capacity * 2);
        }
        m_Pnums[m_size] = x;
        m_size++;
    }

    void insert(int position, int x) {
    
        if (m_size >= m_capacity) {
            resize(m_capacity * 2);
        }
       
        for (int i = m_size; i > position; i--) {
            m_Pnums[i] = m_Pnums[i - 1];
        }
        m_Pnums[position] = x;
        m_size++;
    }

   
    void erase(int position) 
    {
            for (int i = position; i < m_size - 1; i++)
            {
            m_Pnums[i] = m_Pnums[i + 1];
            }
        m_size--;
    }

   
    void print() const 
    {
        for (int i = 0; i < m_size; i++) {
            cout << m_Pnums[i] << " ";
        }
        cout << endl;
    }

private:
    
    void resize(int new_capacity) {
        if (new_capacity <= m_capacity) {
            return;
        }
        int* newMem = new int[new_capacity];
        for (int i = 0; i < m_size; i++) {
            newMem[i] = m_Pnums[i];
        }
        delete[] m_Pnums;
        m_Pnums = newMem;
        m_capacity = new_capacity;
    }
};

class String 
{
public:
    int m_size;
    char* m_string;

    
    String(const char* str = "")
    {
        m_size = 0;
        while (str[m_size] != '\0')
        {
            m_size++;
        }
        m_string = new char[m_size + 1];
        for (int i = 0; i < m_size; i++) {
            m_string[i] = str[i];
        }
        m_string[m_size] = '\0';
    }

    
    ~String() {
        delete[] m_string;
    }

   
    void assign(const char* str)
    {
        delete[] m_string;
        m_size = 0;
        while (str[m_size] != '\0') {
            m_size++;
        }
        m_string = new char[m_size + 1];
        for (int i = 0; i < m_size; i++) {
            m_string[i] = str[i];
        }
        m_string[m_size] = '\0';
    }

   
    int size() const {
        return m_size;
    }

    
    void append(const char* str) {
        int str_len = 0;
        while (str[str_len] != '\0') {
            str_len++;
        }
        char* new_string = new char[m_size + str_len + 1];
        for (int i = 0; i < m_size; i++) {
            new_string[i] = m_string[i];
        }
        for (int i = 0; i < str_len; i++) {
            new_string[m_size + i] = str[i];
        }
        new_string[m_size + str_len] = '\0';
        delete[] m_string;
        m_string = new_string;
        m_size += str_len;
    }

    
    const char* c_str() const
    {
        return m_string;
    }

   
    void print() const
    {
        cout << m_string;
    }
};

int main() {
   
    int nums[5] = {1, 2, 3, 4, 5};
    MyList m(5, nums);
    m.print();

    m.append(33);
    m.print();

    m.insert(2, 7);
    m.print();

    m.erase(3);
    m.print();

    String name("ali");
    String name2;
    name2.assign("mozhdeh");

    cout << "Name: " << name.c_str() << ", Size: " << name.size() << endl;
    cout << "Name2: " << name2.c_str() << ", Size: " << name2.size() << endl;

    name.append(" + ");
    name.append(name2.c_str());
    name.append("\n");

    name.print();

    return 0;
}