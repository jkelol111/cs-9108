Module JuanResources
	Sub Main()
		Console.Write("Input resource ID: ")
		Dim id As Integer = Console.ReadLine()
		Dim cabinet As Integer
		Dim drawer As Integer

		Select Case id
			Case Is < 1001
				cabinet = 1
			Case Is < 3000
				cabinet = 2
				If id Mod 2 = 0 Then
					drawer = 1
				Else
					drawer = 2
				End If
			Case Is < 5000
				cabinet = 3
		End Select
		Console.WriteLine("Cabinet {0} and Drawer {1}", cabinet, drawer)
		Console.ReadKey()
	End Sub
End Module
