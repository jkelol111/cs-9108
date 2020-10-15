Module RevisionQuestion1
  	Sub Main()
	    Dim r, sum As Integer
	    Dim n As Integer = 0
	    While n <= 5
	    	Console.Write("Enter number {0}: ", n)
	        r = CInt(Console.ReadLine())
	        sum += r
	        n += 1
	    End While
	    Console.WriteLine("Sum = {0}", sum)
	    Console.ReadKey()
	End Sub
End Module