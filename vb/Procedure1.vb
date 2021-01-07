Option Strict On

Module Module2
	Sub Main()
		Dim x As Integer = 55
		Dim y As Integer = 32
		
		Console.WriteLine(x)
		Console.WriteLine(y)
		
		Call Addition(x, y)
		Console.WriteLine(x)
		Console.WriteLine(y)
		
		Console.ReadLine()
	End Sub

	Sub Addition(ByVal k As Integer, ByVal l As Integer)
		Console.WriteLine(k + 1)
		k = 9
		l = 4
		Console.WriteLine(k)
		Console.WriteLine(l)
	End Sub
End Module
