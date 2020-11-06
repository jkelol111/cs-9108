Module NumericMan1
	Sub Main()
		Dim sumNumber As Integer
		' + Operator
		sumNumber = 2 + 2
		Console.WriteLine(sumNumber)
		sumNumber = 4257.04 + 98112
		Console.WriteLine(sumNumber)
		
		' - Operator
		Dim binaryResult As Double
		Dim unaryResult As Double
		binaryResult = 459.35 - 334.9
		Console.WriteLine(binaryResult)
		unaryResult = -334.9
		Console.WriteLine(unaryResult)
		
		' * Operator
		Dim testValue As Double
		testValue = 2 * 2
		Console.WriteLine(testValue)
		testValue = 459.35 * 334.9
		Console.WriteLine(testValue)
		
		' / Operator
		Dim divideValue As Double
		divideValue = 10/4
		Console.WriteLine(divideValue)
		divideValue = 10/3
		Console.WriteLine(divideValue)
		
		' \ Operator
		Dim resultValue As Integer
		resultValue = 11 \ 4
		Console.WriteLine(resultValue)
		resultValue = 9 \ 3
		Console.WriteLine(resultValue)
		resultValue = 100 \ 3
		Console.WriteLine(resultValue)
		resultValue = 67 \ -3
		Console.WriteLine(resultValue)
		
		Console.ReadKey()
	End Sub
End Module
