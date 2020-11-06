Module Homework
	Sub Main()
		Dim Amount, TenDollar, TwentyDollar, FiftyDollar, Temp As Integer
		Console.Write("Input amount: $")
		Amount = Console.ReadLine()
		If Amount <= 500 And Amount Mod 10 = 0 Then
			Temp = Amount \ 50
			If Temp > 0 Then
				FiftyDollar = Temp
				Amount -= 50 * Temp
			End If
			Temp = Amount \ 20
			If Temp > 0 Then
				TwentyDollar = Temp
				Amount -= 20 * Temp
			End If
			Temp = Amount \ 10
			If Temp > 0 Then
				TenDollar = Temp
				Amount -= 10 * Temp
			End If
			Console.WriteLine("$10: {0}", TenDollar)
			Console.WriteLine("$20: {0}", TwentyDollar)
			Console.WriteLine("$50: {0}", FiftyDollar)
			Console.WriteLine("Change: {0}", Amount)
		Else
			Console.WriteLine("Amount exceeded maximum/isn't multiple of 10, not doing anything.")
		End If
	End Sub
End Module
