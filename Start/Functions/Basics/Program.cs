using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters
float milesToKm(float miles) {
    float km = miles * 1.6f;
    return km;
}

float tallet = 10.8f;
float forste = milesToKm(tallet);
Console.WriteLine($"{tallet} miles er {forste} km.");

// TODO: A function with no return value has a 'void' type
void PrintWithPrefix(string theStr) {
    Console.WriteLine($"::> {theStr}");
}



// TODO: Call first function
Console.WriteLine($"The result is {milesToKm(11f)} km.");
Console.WriteLine($"The result is {milesToKm(35.9f)}km.");


// TODO: Call second function
PrintWithPrefix("Jørund");