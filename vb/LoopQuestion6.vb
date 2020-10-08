Module LoopQuestion6
	Sub Main()
		For c As Integer = 5 To -10 Step -1
			Dim f As Single = 1.8 * c + 32
			Console.WriteLine("C: {0} -> F: {1}", c, f)
		Next
		Console.ReadKey()
	End Sub
End Module
