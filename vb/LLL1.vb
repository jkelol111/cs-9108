Module LL1
	Sub Main()
		Dim total As Single
		Dim cost As Single
		While cost > -1
			total += cost
			Console.Write("Input cost (-1 to exit): ")
			cost = Console.ReadLine()
		End While
		If total > 100.0 Then
			cost += 0.5
		Else
			cost += 0.3
		End If
		Console.WriteLine("Total cost: {0}", total)
		Console.ReadKey()
	End Sub
End Module
