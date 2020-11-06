Module DoLoopQuestion3
    Sub Main()
        Dim sum As Integer
        Dim num As Integer
        Do 
            Console.Write("Input list of number (-99 to exit): ")
            num = Console.ReadLine()
            If num <> -99 Then
                sum += num
            End If
        Loop Until num = -99
        Console.WriteLine("Sum = {0}", sum)
        Console.ReadKey()
    End Sub
End Module