using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
  /*
Write code using an array to store 7-day average temperatures of a city.
1.	For 7 days of the week:
•	Get the average temperature as input in Celsius.
•	Store in an array called Celsius.
•	Convert temperature to Fahrenheit.
The conversion from Celsius to Fahrenheit is given below:
F = (C * 9/5) + 32
•	Store in another array called Fahrenheit.
2.	Sort the Fahrenheit array in descending order.
3.	Then using a foreach loop, display the Fahrenheit array values.
4.	Calculate the sum of the fahrenheit array 
5.	Calculate the average average temperature in fahrenheit.
*/

//Declare temperature array in celsius
double[] temperatureCelsius = new double[7];

//Declare temperature array in fahrenheit
double[] temperatureFahrenheit = new double[7];


//Begin for loop to populate temperature array in celsius, and //then calculate and populate the temperature array in Fahrenheit
//Finally, add to the sum in Fahrenheit

for (int i = 0; i < temperatureCelsius.Length; i++) 
{
  Console.WriteLine("Enter temperature in Celsius:");
  temperatureCelsius[i] = Convert.ToDouble(Console.ReadLine());
  // Calculate temperature in Fahrenheit
  temperatureFahrenheit[i] = (temperatureCelsius[i] * 9/5) + 32;

}

//Sort Fahrenheit array
Array.Sort(temperatureFahrenheit);

//Display Fahrenheit array using foreach
foreach (double j in temperatureFahrenheit)
{
  Console.WriteLine(j);
}

// Display sum of Fahrenheit array
Console.WriteLine("The sum of the temperatures for the week in fahrenheit is " + temperatureFahrenheit.Sum());

// Display the average of the fahrenheit array
Console.WriteLine ("Average weekly temperature is " + (temperatureFahrenheit.Sum()/temperatureFahrenheit.Length) + " degrees fahrenheit.");


  }
}