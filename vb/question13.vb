' Question 13 in Worksheet:

' 13. According to Plato, a man should marry a woman whose age is half his age plus seven years. Write a program that requests a man’s age as input and gives the ideal age of his wife.

Module Question13
	Sub Main()
		Dim ageman As Integer
		Dim agewoman As Integer

		Console.WriteLine(“What is your age?: ”)
		ageman = Console.ReadLine()
	 
		agewoman = (ageman / 2) + 7
		Console.WriteLine(“ The ideal age of your wife should be {0}”, agewoman)
		Console.ReadLine()
	End Sub
End Module
