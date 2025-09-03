#include<iostream>
#include<math.h>
using namespace std;// This namespace includes most of the C++ Standard Library, such as functions for input/output, strings, and more.

class Point
{   public://if want to use the class in other functions too, or else its privatwe
        double x;
        double y;
        // we we call what we wrote in class i n main, it checks wich parametrs it matchs
        Point (double t, double r)
        {
            x = t;
            y = r;
        }
        Point (double w) //hrer we difind our x and y so we dont need to difine i tanywhere else
        {
            x = w;
            y = w;
            cout << "x in c:"<< x<< " ,y in c:"<<y <<endl;
        }

        Point ()
        {
            //when we first printed a point it was a rendom x and y, its the same, now that we definde others if we want to have this we have to define it too
        }

        // Point (Point* q)//pointer becuase we need some empty space
        // {
        //     x = q->x;
        //     y = q->y;
        // }
        Point (const Point& q) // incase we dont want to be able to make change we add {const}
                               // {&} means refrence. its like a pointer.
        {
            x = q.x;
            //q.y+=1 //now that we have {const} we cant change it
            y = q.y;

        }
        



        void print_point()
        {
            cout << "x: " << x << ",y: " << y <<endl;
        }

        double distance( Point w)
        {
            double disx = x - w.x;
            double disy= y- w.y;
            // here we already have difined the first point so we dont need to do it again. its where we are
            return sqrt(disx*disx + disy*disy); //sqrt = radical
        }
        
        ~Point(){// {~} this distruct the things we dont use anymore to empty the space
            cout << "x in d:"<< x<<", y in d"<<y <<endl; // we print this to see when we have a distruction
        }


    


};

// void pirnt_point(Point p)
// {
//     cout << "x: " <<p.x << ",y: " << p.y <<endl;
    

// }

// double distance( Point p1 , Point p2)
// {
//     double disx = p1.x - p2.x;
//     double disy= p1.y- p2.y;
//     return sqrt(disx*disx+disy*disy);




int main()
{   
    Point p0(9);// in this one it will use with only one parametr
    p0.print_point();

    Point p1(4,5);
    //this one use the one with 2 parametrs
    p1.print_point();


    Point p2(2,3);
    p2.print_point();
    p2.x = -5;
    p2.y = 3;
    p2.print_point();
    
    double r = p1.distance(p2);
    cout <<r<<endl;

   
   
   
    cout << p1.x << endl;
   

    int a;
    cin>>a;
    cout<<"a:" <<a<<std::endl;
    return 0;
}