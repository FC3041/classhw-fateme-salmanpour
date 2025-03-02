#include<iostream>
#include<math.h>

using namespace std;


class point
{
    public:
    double x;
    double y;

    point( double t, double f)
    {
        x = t;
        y = f;

    }


};

class circle
{
    public:
    double centerx;
    double centery;
    double radius;

    circle (double r, double x, double y)
    {
        centerx = x;
        centery = y;
        radius = r;
    }

    double cir()
    {
        double mohit = 3.14*2*radius;
        return mohit;
        
    }

    double  side()
    {
        double masahat = radius*radius*3.14;
        return masahat;
    }

    double distance_of_centers(circle c )
    {
        double x_diff = centerx - c.centerx;
        double y_diff = centery - c.centery;

        return sqrt(x_diff*x_diff + y_diff*y_diff);
    }
    
    double distance_of_center_and_point( point p)
    {
        double x_diff = p.x - centerx;
        double y_diff = p.y - centery;

        return sqrt(x_diff*x_diff + y_diff*y_diff);
    }

    string check(point p)
    {   
        double distance = distance_of_center_and_point(p);
        if (distance<radius)
        {
            return "Point is inside the circle";
        }
        else if (distance == radius)
        {
            return "Point is on the circle";
        }
        else
        {
            return "Point is outside the circle";
        }
        
    }


};

int main()
{
    circle c1(4,0,0);
    circle c2(4,2,1);
    point p1(4,5);
    double r = c1.cir();
    cout<< "circumference of this circle is "<<r<< endl;

    double m = c1.side();
    cout<< "side of this circle is "<< m << endl;

    double d = c1.distance_of_centers(c2);
    cout<< "the distance between c1(0,0) and c2(2,1) is "<< d << endl;

    double b = c1.distance_of_center_and_point(p1);
    cout << "the distance between p1(4,5) and c1(0,0) is "<< b <<endl;

    string result = c1.check(p1);
    cout << result << endl;

}