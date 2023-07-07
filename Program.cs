// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Formats.Asn1;

Console.WriteLine("Welcome to Maria Ragone's Room Detail Generator");
Console.WriteLine();

Console.Write("Enter Length in feet: ");
float length = float.Parse(Console.ReadLine());

Console.Write("Enter Width in feet: ");
float width = float.Parse(Console.ReadLine());

Console.Write("Enter Height in feet: ");
float height = float.Parse(Console.ReadLine());


float area = length * width;
float perimeter = (2 * length) + (2 * width);
float volume = length * width * height;
float surfaceArea = (2 * ((width * length) + (height * length) + (height * width)));

Console.WriteLine($"The area is: {area} square feet");
Console.WriteLine($"The perimeter is: {perimeter} feet");
Console.WriteLine($"The volume is: {volume} cubic feet");
Console.WriteLine($"The surfaceArea is: {surfaceArea} square feet");

if (area <= 250)
{
    Console.WriteLine("This room size is small.");
}
else if (area <= 650)
{ 
    Console.WriteLine("This room size is medium.");
}
else
{
    Console.WriteLine("This room size is large.");
}
Console.WriteLine(); 
Console.WriteLine("Thank you for using Maria Ragone's Room Detail Generator!");

