Module Plato
	Sub Main()
		Console.Write("Man's age: ")
		Dim manAge as Integer = Console.ReadLine()
		
		Dim womanAge As Integer = (manAge / 2) + 7
		
		Console.WriteLine("Woman's age: {0}", womanAge)
	End Sub
End Module
