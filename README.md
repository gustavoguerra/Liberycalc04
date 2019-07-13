# Liberycalc04
Biblioteca de operações matemática 

Status of Build

[![Build status](https://ci.appveyor.com/api/projects/status/ofq8dbe1n9estfw7/branch/master?svg=true)](https://ci.appveyor.com/project/gustavoguerra/liberycalc04/branch/master)

![Nuget](https://img.shields.io/nuget/dt/Liberycalc04.svg)

## How to install
Install-Package LibraryCalc04 -Version 1.0.2

## How to use
```cs

    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();

            var result = calculadora.Soma(10, 50, 10);

            Console.WriteLine(result);
        }
    }
```
