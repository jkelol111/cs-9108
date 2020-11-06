Module NumericMan9
	Sub Main()
		Console.WriteLine(Format(8345679315.4, "$##,##0.00"))
		Console.WriteLine(Format(8315.4, "##,##0.00"))
		Console.WriteLine(Format(8315.467678, "##,#00.00"))
		Console.WriteLine(Format(8315.4, "000000.000"))
		Console.ReadKey()
	End Sub
End Module
