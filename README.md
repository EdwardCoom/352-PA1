# PA1: Programming Assignment 1

Name: Zach Coomer

Date: 01/23/2023

## Description

This assignment is my first C# assignment coming from C++. In this assignment we are creating an Abstract Animal Class and a few different Concrete Classes that override the Animal Class. All of these Classes will be accessed in a World Class which is the main driver for the program. 

## Notes

* Design Decisions: 
	- 	I decided to add individual files for each class, this keeps the main driver nice and concise. This allows easy access to each class without having to sift through convoluted code.
	-	During research I saw that you can use properties to simplify getters and setters and also still have private members. 

* Things I Found Interesting:
	-	I found a way to code in the actual class name in the printInfo method and I was able to add a .ToLower() to that code to seamlessly integrate the name of the class into the printInfo message. This allowed me to reuse the same code in all of the Derived classes.
	-	I found properties to be a very efficient and clean way to write getters and setters, unfortunately I found out about them midway through writing my program.

* Things I Found Difficult: 
	-	Adding a README.md was not explicitly obvious, I wanted to avoid adding it through Github and then pulling so I could do it all from Visual Studios. After a little research and trials it is pretty simple now. 
	-	Learning how to interact between the Abstract Animal Base/Parent class and the Derived/Children classes. I had quite a few hair pulling moments until I learned how to use the getter and setter methods properly. The syntax is much more simple in C# than in C++ and while this is great coming from C++ may lead one to overthink certain aspects.

* Limitations:
	-	This program is just breaking the ice on C# and is likely plagued with many limitations and does not have much functionality but that is the intention. 