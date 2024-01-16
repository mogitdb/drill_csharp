# Table of Contents

1. [Directives](#directives)
2. [SpecialCharacters](#specialcharacters)
3. [OutputtingToConsole](#outputtingtoconsole)
4. [VariablesAndAssignmentStatement](#variablesandassignmentstatement)
5. [Literals](#literals)
6. [Identifiers](#identifiers)
7. [MultiWordVariables](#multiwordvariables)
8. [DataTypes](#datatypes)
9. [IntegralLiterals](#integralliterals)
10. [FloatingPointDataTypes](#floatingpointdatatypes)
11. [CharDataType](#chardatatype)
12. [StringLiterals](#stringliterals)
13. [StringVsCharacter](#stringvscharacter)
14. [BoolDataType](#booldatatype)
15. [SizeOfDataType](#sizeofdatatype)
16. [MoreOnVariableAssignmentsAndInitialization](#moreonvariableassignmentsandinitialization)
17. [VariableAssignmentVsInitialization](#variableassignmentvsinitialization)
18. [Scope](#scope)
19. [ArithmeticOperators](#arithmeticoperators)
20. [BinaryArithmeticOperators](#binaryarithmeticoperators)
21. [DivisionOperator](#divisionoperator)
22. [ModulusOperator](#modulusoperator)
23. [Comments](#comments)
24. [ProgrammingStyle](#programmingstyle)

# Directives

Directives in C# are used to make namespaces and types defined in other assemblies available within a file. This section goes over the use of `using` directives.

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    void Update()
    {   
        // Code goes here
    }

    int MyFunction()
    {
        Debug.Log("In MyFunction.");
        return 0;
    }
}
```
# SpecialCharacters

Explainer: Special characters in C# have specific uses, such as demarcating comments, beginning preprocessor directives, defining the start and end of blocks of code, and terminating statements. Remembering their functions is crucial for writing syntactically correct code.

```csharp
// Double Slash - used to begin a comment
# // Pound Sign - Begins a preprocessor directive
() // Open, Close Parentheses // Used when naming a function
{} // Open, Close Braces - Encloses a group of statements
" " // Open, Close Double Quote Marks - Encloses a string of characters
; // Semicolon - Ends a programming statement
CASE SENSITIVE // - c# is case-sensitive remember!
```
# OutputtingToConsole

Explainer: Outputting to the console is a fundamental way of displaying messages, debugging information, or values of variables during the execution of a program. `Debug.Log()` is used in Unity to print out to the console window.

```
Debug.Log("Text:" + myText.text);
```
# VariablesAndAssignmentStatement

Explainer: Variables are named storage locations capable of holding data, and the assignment statement sets and changes the value of a variable. It is an essential aspect of programming that allows data to be stored and manipulated throughout the lifecycle of a program.

```csharp
int age;
age = 17; // Assigns 17 to age
cout << age; // Displays 17
age = 18; // Now age is 18
cout << age; // Displays 18
```
# Literals

Explainer: Literals are fixed values that are directly inserted into the code. They represent values such as characters, strings, and numbers, and are treated by the compiler as constants.

```csharp
'A' // character literal
"Hello" // string literal
12 // integer literal
"12" // string literal
3.14 // floating-point literal
```
# Identifiers

Explainer: Identifiers are the user-defined names given to elements of a program like variables, classes, and functions. They are essential for referencing and manipulating data throughout a program.

```
int example_likethisOrThis;
```
# MultiWordVariables

Explainer: When naming variables that consist of multiple words, it is important to adopt a consistent naming convention for readability and maintainability of code. C# commonly uses camelCase for variable names.


```csharp
int quantityOnOrder, totalSales;
int quantity_on_order, total_sales;
```
# DataTypes

Data types specify the different sizes and values that can be stored in the variable. In C#, data types are categorized into value types (such as int, float, bool) and reference types (such as string). Understanding the range and functionality of each data type is crucial for effective programming and memory management.

```csharp
### int 4 bytes: 
*Stores whole numbers from -2,147,483,648 to 2,147,483,647*
### long 8 bytes: 
*Stores whole numbers from -9,223,372,036,854,775,808 to -9,223,372,036,854,775,807*
### float 4 bytes: 
*Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits*
### double 8 bytes: 
*Stores fractional numbers. Sufficient for storing 15 decimal digits*
### bool 1 bit: 
*Stores true or false values*
### char 2 bytes: 
*Stores a single character/letter, surrounded by 'single quotes'*
### string 2 bytes per character: 
*Stores a sequence of characters, surrounded by "double quotes"*
```
# IntegralLiterals

Integral literals are whole number values without fractional parts. Learn about their use and representation in C#.

```csharp
long rooms = 234L; // to store an integer literal in a long memory location
rooms = 075; // Literals that begin with 0 are octal or base 8
rooms = 0x75A; //Literals that begin with 0x are hexadecimal or base 16
```

# FloatingPointDataTypes

Learn about floating-point data types in C#, which are used to represent numbers that have a fractional part.

```csharp

Designed to hold Real Numbers

float example = 12.45 // Can be declared with the variable
example = 12.45f // Can beforced into a float by adding f after
example = 3.14159E1 // Can also be used for e-notation
```

# CharDataType

The `char` data type is used to store single characters. Understand how it functions in C#.

 ```csharp
 
 char letter = 'C'; // Uses bytes, represents the character with a numeric code in memory
 ```

# StringLiterals

String literals are sequences of characters. Find out how they are used and stored in C#.

 ```csharp
 
 string example = "Hello"  // The end of a string has an extra \0 (Null terminator)
 Debug.Log("My name is: " + example); // String concatination stitches the string + string togethor

 // Remember this when counting string lengths
 ```

# StringvsCharacter

Understand the difference between a single character (`char`) and a string (`string`) in C#.

``` csharp
If you use a single character but wrap it in "double quotes" it's actually a string

'c' = char = // (c) is all that is stored
"c" = string = // (c)(\0) is what is actually stored remember!
```
# boolDataType

The `bool` data type is used to represent Boolean values: true or false. Learn about its use in C#.

```csharp
// Represents values that are true or false
// bool values are stored as integers
// false is represented by 0, true by 1

bool allDone = true;
bool finished = false;
```

# SizeofDataType

Examine how to determine the size of different data types in C# using the `sizeof` operator.


```csharp
// sizeof operator gives the size in number of bytes of any data type or variable

double amount;
Debug.Log(sizeof(float));
Debug.Log("Variable amount is stored in " + sizeof(amount));


```

# MoreonVariableAssignmentsandInitialization

Dive deeper into variable assignments and the initialization process in C# programming.

```csharp
// Assigning a value to a variable

int size;
size = 5+2; // legal, Assigns a value to a previously created variable
5 = size; // not legal, a single variable name must appear on left side of the = symbol

```


# VariableassignmentvsInitialization

Learn the difference between assigning a value to an already declared variable and initializing a variable upon declaration in C#.

```csharp
// Initializing a variable

int length = 12; // Gives an initial value to a variable at the time it is defined
int width = 7, height = 5, area; // some or all the variables being defined can be initialized
```

# Scope

Understand the concept of scope in C#, which defines where variables or functions are accessible within the code.

```csharp

int num = 5;
Debug.Log(num1); // legal, the variable is used after declaration
Debug.Log(num2); // illegal, a variable cannnot be used before it is defined
int num2 = 12; 

```

# ArithmeticOperators

Arithmetic operators are used to perform common mathematical operations. Get to know how they work in C#.

```csharp
//unary
-5 
//binary
13 -7
//ternary operators
exp1 ? exp2 : exp3

```

# BinaryArithmeticOperators

Binary arithmetic operators perform addition, subtraction, multiplication, and other arithmetic operations between two operands in C#.

```csharp

ans = 7 + 3; // + addition = ans = 10
ans = 7 - 3; // - subtraction = ans = 4
ans = 7 * 3; // * multiplication = ans = 21
ans = 7 / 3; // / division = ans = 2
ans = 7 % 3; // % modulus = ans = 1
```

# DivisionOperator

The division operator is used to divide numbers. Learn how it behaves with different operand types in C#

```csharp

// C# division operator (/) performs integer division if both operands are integers

Debug.Log(13/5); //displays 2
Debug.Log(2/4); //displays 0

// If either operand is floating-point, the result is floating-point

Debug.Log(13/5.0); // displays 2.6
Debug.Log(2.0/4); // displays 0.5

```

# ModulusOperator

The Modulus Operator section covers the use of the modulus operator (%) in C#. It explains that this operator computes the remainder from integer division and shows examples with integer operands. The section also notes the error that occurs when trying to use a floating-point number with the modulus operator.

```csharp
// C# modulus operator (%) computes the remainder resulting from integer division

Debug.Log(9%2); // displays 1

// requires integers for both operands

Debug.Log(9%2.0); // error
```

# Comments


The Comments section outlines how to use comments in C#. It distinguishes between single-line comments, which start with '//' and multi-line comments, which are enclosed between '/*' and '* /' (without the space).

```csharp
// Single Line comments begin with a //

/* Multi line comments begin and end with respectively */
```