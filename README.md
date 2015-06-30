#Solution developed for a test

The growth rate formula is changed slightly to make it make simpler at  run time. 
	growth rate = y/(1250*firstNumber)

If first number is x0 and g is the growth rate a number in a series is calculated using the following formula: 

x0 = x0

x1 = g 

x2 = g * x0

x3 = x2 * x0

Assumptions:

1. If x0 == 1 && (x0*g==1 || x0*g==-1) the series cannot be generated and InvalidOperationException is thrown

2. If x0 and g are both greater than 1 then the series is ascending and there is no need for sorting

3. If x0 or g are less than 1 then the series is descending. The series can be calculated from end to start

