// Напишите программу, которая приниает вход координаты двух точек находит расстояние между ними в 3D пространстве.


int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");
int zA = Coordinate("z", "A");

int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");
int zB = Coordinate("z", "B");


int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}



int xC = xA;
int yC = yB;
int zC = zB-zA; 
 
/* Console.WriteLine($"A({xA},{yA},{zA})");
Console.WriteLine($"B({xB},{yB},{zB})"); Тут я выводил координаты точек, но потом не понял как координаты z от точки C вывести в 3D пространстве.
Console.WriteLine($"C({xC},{yC}),{zC}"); 
 */
double Gip(int yA, int yC, int xC, int xB, int zA, int zB)
{
    int ac;
    int bc;
    int z;
    int distnce;

    ac = yC - yA;
    bc = xB - xC;
    z = zB - zA;
    distnce = (ac * ac) + (bc * bc) + (z * z);
    return Math.Sqrt(distnce);
    // Это же решение:
    // return Math.Sqrt(Math.Pow(ac,2)+ Math.Pow(bc,2)+Math.Pow(z,2);  
}

Console.WriteLine("Расстояние между заданными точками A и B: " + Gip(yA, yC, xC, xB, zA, zB));
