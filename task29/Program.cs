// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int[] point = new int[8];   

point[0] = new Random().Next(10, 100);;

point[1] = new Random().Next(10, 100);;

point[2] = new Random().Next(10, 100);;

point[3] = new Random().Next(10, 100);;

point[4] = new Random().Next(10, 100);;

point[5] = new Random().Next(10, 100);;

point[6] = new Random().Next(10, 100);;

point[7] = new Random().Next(10, 100);;


System.Console.WriteLine($"| {point[0]} | {point[1]} | {point[2]} | {point[3]} | {point[4]} | {point[5]} | {point[6]} | {point[7]} |");

/*int Random();
{
    int number = new Random().Next(10, 100);
    break;
}*/





