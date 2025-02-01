
var name = "Juan";
var lastname = "Perez";

//Console.Write("Mi Nombre Completo es: ");  
//Console.Write(name);  
//Console.Write(" "); 
//Console.Write(lastname); 

//var name = "Juan";
//var lastname = "Perez";
//var fullname = name + " " + lastname;

//using System.Text; 
//StringBuilder fullname = new StringBuilder();
//fullname.Append(name);
//fullname.Append(" ");
//fullname.Append(lastname);

//var fullname = string.Format("Mi Nombre es: {1} {0}", name,   lastname);  
/*
var fullname = $"Mi Nombre es: {name} {lastname}" ;  
Console.Write(fullname);
*/

// () ^ /*% +-

int iAmAnIntValue = 10;
 
int iAcceptOnlyIntValues22 = Convert.ToInt32("5");
 
 
  
var num1 = 10;
var num2 = 2;
var num3 = 2;
var num4 = 2;
var num5 = 2;


var result8 = ((num1 + ((num2 *  num3) * (num4 ^ num5))) + (num2 - (num5 * (num4 % num5))));
var result9 = ((num1 +  (num2 *  num3 * (num4 ^ num5))) + (num2 - (num5 * (num4 % num5))));
var result10 = (num1 +  (num2 *  num3) * (num4 ^ num5) + (num2 - num5) * (num4 % num5));
var result11 = (num1 +   num2) * num3 * (num4 ^ num5) + (num2 - num5 * (num4 % num5));

Console.WriteLine($"  {result8}   {result9}    {result10}     {result11}");
