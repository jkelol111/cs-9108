Module ModularProg6
	Sub Main()
		Dim total As Single
		Call ExplainPurpose()
		total = AddNums(2, 3)
		Call PrintNums(2, 3, total)
		Console.ReadLine()
	End Sub

	Sub ExplainPurpose()
		Console.WriteLine("This program displays a sentence indentifying ")
		Console.WriteLine("two numbers and their sum")
		Console.WriteLine()
	End Sub

	Sub PrintNums(ByVal num1 As Single, ByVal num2 As Single, ByVal theTotal As Single)
		Console.WriteLine("The sum of " & num1 & " and " & num2 & " is " & theTotal)
	End Sub

	Function AddNums(numA As Single, numB As Single) As Single
		Dim theTotalValue As Single
		theTotalValue = numA + numB
		Return theTotalValue
	End Function
End Module
