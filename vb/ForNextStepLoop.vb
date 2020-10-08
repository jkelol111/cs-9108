Module ForNextStepLoop
	Sub Main()
		Dim Counter As Byte
		' for loop execution
		For Counter = 10 To 20 Step 5
			Console.WriteLine("value of a: {0}", Counter)
		Next
		Console.ReadKey()
	End Sub
End Module
