using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int originalTemp = 0;
        int originalToCelsius = 0;
        int celsiusToFahrenheit = 0;

        print("Original Temp: " + originalTemp);

        originalToCelsius = originalTemp - 32;
        originalToCelsius = originalToCelsius / 9;
        originalToCelsius = originalToCelsius * 5;

        print("Converted to Celsius: " + originalToCelsius);

        celsiusToFahrenheit = originalToCelsius * 9;
        celsiusToFahrenheit = celsiusToFahrenheit / 5;
        celsiusToFahrenheit = celsiusToFahrenheit + 32;

        print("Converted Back to Fahrenheit: " + celsiusToFahrenheit);

        originalTemp = 32;

        print("Original Temp: " + originalTemp);

        originalToCelsius = originalTemp - 32;
        originalToCelsius = originalToCelsius / 9;
        originalToCelsius = originalToCelsius * 5;

        print("Converted to Celsius: " + originalToCelsius);

        celsiusToFahrenheit = originalToCelsius * 9;
        celsiusToFahrenheit = celsiusToFahrenheit / 5;
        celsiusToFahrenheit = celsiusToFahrenheit + 32;

        print("Converted Back to Fahrenheit: " + celsiusToFahrenheit);

        originalTemp = 212;

        print("Original Temp: " + originalTemp);

        originalToCelsius = originalTemp - 32;
        originalToCelsius = originalToCelsius / 9;
        originalToCelsius = originalToCelsius * 5;

        print("Converted to Celsius: " + originalToCelsius);

        celsiusToFahrenheit = originalToCelsius * 9;
        celsiusToFahrenheit = celsiusToFahrenheit / 5;
        celsiusToFahrenheit = celsiusToFahrenheit + 32;

        print("Converted Back to Fahrenheit: " + celsiusToFahrenheit);

        float newFloatTemp = 0;
        float newToCelsius = 0;
        float celsiusToNew = 0;

        print("Original Float Temp: " + newFloatTemp);

        newToCelsius = newFloatTemp - 32;
        newToCelsius = newToCelsius / 9;
        newToCelsius = newToCelsius * 5;

        print("Converted to Celsius: " + newToCelsius);

        celsiusToNew = newToCelsius * 9;
        celsiusToNew = celsiusToNew / 5;
        celsiusToNew = celsiusToNew + 32;

        print("Converted Back to Fahrenheit: " + celsiusToNew);

        double newDoubleTemp = 0;
        double dubToCelsius = 0;
        double celsiusToDub = 0;

        print("Original Float Temp: " + newDoubleTemp);

        dubToCelsius = newDoubleTemp - 32;
        dubToCelsius = dubToCelsius / 9;
        dubToCelsius = dubToCelsius * 5;

        print("Converted to Celsius: " + dubToCelsius);

        celsiusToDub = dubToCelsius * 9;
        celsiusToDub = celsiusToDub / 5;
        celsiusToDub = celsiusToDub + 32;

        print("Converted Back to Fahrenheit: " + celsiusToDub);

    }
}
