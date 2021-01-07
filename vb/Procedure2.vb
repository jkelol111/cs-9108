Option Strict On

Module Module3
	Dim a As Byte = 2
	
	Sub Main()
		Dim b As Byte = 3
		Console.WriteLine("Inside Main Block")
		Console.WriteLine(a)
		Console.WriteLine(b)
		SimpleProcedure()
		Console.ReadLine()
	End Sub

	Sub SimpleProcedure
		Console.WriteLine("Inside Procedure")
		Console.WriteLine(a)
	End Sub
End Module
