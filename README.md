# Calculator.Tests

This project contains unit tests for the `Calculator` library.

## Table of Contents

- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Running Tests](#running-tests)
  
## Introduction

The `Calculator.Tests` project is responsible for testing the functionality of the `Calculator` library, ensuring that all calculations are accurate and that the library behaves as expected.

## Prerequisites

Before running the tests, ensure that you have the following prerequisites installed:

- [.NET 7 SDK](https://dotnet.microsoft.com/download) (compatible with the project)
- [NUnit](https://nunit.org/) (if not included as a package reference)
- NUnit Console Runner 3.16.2: (https://github.com/nunit/nunit-console/releases) you can download the .zip, extract it and work

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/jucarmonam/CalculatorTestProject-Nunit.git

2. Navigate to the project directory:
   
   ```bash
   cd Calculator.Tests
   cd Calculator.Tests

3. Build the project:
    ```bash
   dotnet build

## Running Tests

1. You can run the unit tests using the following command, remember change "your-path":
   ```bash
    your-path\NUnit.Console-3.16.2\bin\nunit3-console.exe your-path\Calculator.Tests\Calculator.Tests\bin\Debug\net7.0\App.Tests.dll  --result="TestResult.html;transform=NUnitToHtml.xslt" --    
    work=your-path\Calculator.Tests\Calculator.Tests\testsResults
   
This command will discover and execute all unit tests in the project, providing test results and a html output (your-path\Calculator.Tests\Calculator.Tests\testsResults) where you can see the report of the tests.
