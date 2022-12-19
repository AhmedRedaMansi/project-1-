// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter a number ");
int num=int.Parse(Console.ReadLine());
for(int i=2;i<num;i++)
{

    if (num %i==0)
        
        Console.WriteLine("this number not prime");
    return;
}
Console.WriteLine("this number prime");