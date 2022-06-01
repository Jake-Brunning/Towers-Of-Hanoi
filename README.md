# Towers-Of-Hanoi
Program which solves the Towers Of Hanoi problem using recursion. It then draws this to the screen.

--
->What are the Towers of Hanoi? It a mathematical problem. In short, picture 3 towers, and put n amount of rings on the leftmost tower. Each ring should have a 
seperate weight / size. The smallest of the rings should be at the top, the largest at the bottom. Your goal is to move all the rings to the Tower on the right.
You cant move more than 1 ring at once and you cant put a larger ring on a smaller one.
--

The program declares 3 'towers' as Stack types (Stack class in this instance is written by myslef, not using inbuilt version)
The user declares how much rings there are and the amount of pause time to see each ring on the screen
The program then solves the problem, drawing its steps to the screen. This solution is recursive and the most efficient way to solve the towers of hanoi problem
(It does it in the least amount of moves possible)
