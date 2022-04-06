# FB-Courier-Kata
A simple program to solve the courier kata.
## Table of contents
* [General info](#general-info)
* [Tasks](#tasks)
* [Setup](#setup)
* [Further Implementations](further-implementations)

## General info
A simple program to solve the courier kata using C#.
Packages used: Xunit.


## Tasks
I broke down the kata requirements into the following tasks and created a design plan before starting to code given the time constrain of 2 hrs. 

1. It calculates the dimension of the parcel based on its length, width, height and classifies the parcel into small, medium, large and XL parcel and returns costs associated with each size. 

eg: ```Small Parcel: $3. Total Cost: $3```

I have also added the weight as a parameter for then parcel dimension to account for the new parcel type: Heavy parcel.

2. It gives the option to add speedy shipping to the user, which doubles the cost of the entire order.
- listed as a separate output

3. It charges for extra weight. A $2/kg over weight limit for parcel size:
● Small parcel: 1kg
● Medium parcel: 3kg
● Large parcel: 6kg
● XL parcel: 10kg

4. As mentioned in Task 1, a new parcel type is introduced
```
Heavy parcel (limit 50kg), $50. +$1/kg over
```

5. Special discounts are introduced. Based on the number of parcels in the order:

● Small parcel mania! Every 4th small parcel in an order is free!
● Medium parcel mania! Every 3rd medium parcel in an order is free!
● Mixed parcel mania! Every 5th parcel in an order is free!

- it is important to keep track of the type of parcel and each number that is being added to the order so the discounts can be implemented. 

Data type:

1. order: double total costs, integer number of each parcel type, 
2. parcel: string type (small, medium, etc), double costs(eg: 4 dollars), double weight of parcel

## Setup
To run this project, open the FB-Courier-Kata.sln.

To run solution

```
$ dotnet run     
```
To run the tests:
```
$ dotnet test
```
##  Further Implementations

As I ran out of time my plan for further implementation is

1. Fix the syntax for the commented tests.
2. Add code for the failing tests.
3. Add function that calculates the extra weight for the parcel - to be used within the the calculateDimension functions where there would be a separate output for the extra weight and cost of the parcel will be updated. 
4. Add function that adds discount based on how many parcels are in the order object: I would be looking at an if statement that would evaluate the count of different parcels and return each special discount. 
5. I would improve on the user interface in the terminal: better phrasing and give user options to his/her answer (eg: yes/no, add, get total) and use case to account for each choice.