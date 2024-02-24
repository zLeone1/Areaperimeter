

using Areaperimeter;


bool control = false;
while (control ==  false)
{
    Console.WriteLine("Welcome, which geometrical figure do you want to calculate the Area and Perimeter \n 1. Square \n 2. Rectangle \n 3. Triangle \n 4. Leave ");
    int option1 = Convert.ToInt32(Console.ReadLine());
    switch (option1)
    {
        case 1:
            Console.WriteLine("Give a side of the square");
            double sidesquare = Convert.ToDouble(Console.ReadLine());
            Square? A = new Square(sidesquare);
            Console.WriteLine("The perimeter of the Square is: " + A.GetSquareArea());
            Console.WriteLine("The perimeter of the Square is: " + A.GetSquarePerimeter());
            A = null;
            break;

        case 2:
            Console.WriteLine("Give the width of the Rectangle");
            double widthrect = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the Height of the Rectangle");
            double heightrect = Convert.ToDouble(Console.ReadLine());
            Rectangle? rectangle = new Rectangle(widthrect, heightrect);

            Console.WriteLine("The Area of the Rectangle is: " + rectangle.GetArea());
            Console.WriteLine("The perimeter of the Rectangle is: " + rectangle.GetPerimeter());
            rectangle = null;
            
            break;


        case 3:
            Console.WriteLine("Give the width of the Triangle ");
            double widthTriangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the Height of the Triangle");
            double heighTriangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give a side of the Triangle");
            double sideTriangle = Convert.ToDouble(Console.ReadLine());
            Triangle? t = new Triangle(widthTriangle, heighTriangle);

            Console.WriteLine("The Area of the Triangle is: " + t.GetTriangleArea());
            Console.WriteLine("The perimeter of the Triangle is: " + t.GetTrianglePerimeter(sideTriangle));
            t = null;
            break;


        case 4:

            Console.WriteLine("Goodbye!" );
            control = true;

            break;



    }
}


Console.ReadKey();
