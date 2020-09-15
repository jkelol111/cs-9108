Module Module6
	Sub Main()
		Dim birthday As Date
		birthday = #7/27/1998#
		Console.WriteLine("Your birthday is on {0:MM/dd/yy}", birthday)
		Console.WriteLine("Your birthday is on {0:dd/MM/yy}", birthday)
		Console.WriteLine("Your birthday is on {0:yy/MM/dd}", birthday)
		Console.ReadKey()
	End Sub
End Module
