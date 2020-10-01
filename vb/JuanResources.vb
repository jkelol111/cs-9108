Module JuanResources
	Sub Main()
		Console.Write("Input resource ID: ")
		Dim id As Integer = Console.ReadLine()
		Dim cabinet As Integer
		Dim drawer As Integer
		If id < 1001 Then
			cabinet = 1
		ElseIf id > 1001 And id < 3000 Then
			cabinet = 2
			Dim check As Integer = id Mod 2
			If check = 0 Then
				drawer = 1
			Else
				drawer = 2
			End If
		ElseIf id > 3001 And id < 5000 Then
			cabinet = 3

		End If
		Console.WriteLine("Cabinet {0} and Drawer {1}", cabinet, drawer)
		Console.ReadKey()
	End Sub
End Module
