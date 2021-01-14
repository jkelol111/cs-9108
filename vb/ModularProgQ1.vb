Module ModularProgQ1
	Function Average(ByVal num1 As Single, ByVal num2 As Single, ByVal num3 As Single) As Single
		Return (num1 + num2 + num3) / 3.0
	End Function
	
	Sub Main()
		Console.Write("Input num1: ")
		Dim num1 As Single = Console.ReadLine()
		Console.Write("Input num2: ")
		Dim num2 As Single = Console.ReadLine()
		Console.Write("Input num3: ")
		Dim num3 As Single = Console.ReadLine()
		Console.WriteLine("Average: {0}", Average(num1, num2, num3))
		Console.ReadKey()
	End Sub
End Module	
		
