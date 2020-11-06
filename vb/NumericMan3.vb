Module NumberMan3
	Sub Main()
		Dim exp1, exp2, exp3, exp4, exp5, exp6 As Double
		exp1 = 2 ^ 2
		Console.WriteLine(exp1)
		exp2 = 3 ^ 3 ^ 3
		Console.WriteLine(exp2)
		exp3 = (-5) ^ 3
		Console.WriteLine(exp3)
		exp4 = (-5) ^ 4
		Console.WriteLine(exp4)
		exp5 = 8 ^ (1.0 / 3.0)
		Console.WriteLine(exp5)
		exp6 = 8 ^ (-1.0 / 3.0)
		Console.WriteLine(exp6)
		Dim var1 As Integer
		Dim var2 As Integer
		var1 ^= var2
		Console.WriteLine(var1)
		Console.ReadKey()
	End Sub
End Module
