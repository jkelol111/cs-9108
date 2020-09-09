Module TwoIntegers
	Sub Main()
		Dim int1 As Integer
		Dim int2 As Integer
		Console.Write("Integer 1: ")
		int1 = Console.ReadLine()
		Console.Write("Integer 2: ")
		int2 = Console.ReadLine()
		Console.WriteLine("Addition: {0}", int1+int2)
		Console.WriteLine("Substraction: {0}", int1-int2)
		Console.WriteLine("Multiplication: {0}", int1*int2)
		Console.WriteLine("Division: {0}", int1/int2)
		Console.ReadKey()
	End Sub
End Module
