Module DoLoopQuestion2
    Sub Main()
        Dim sum As Integer
        Dim num As Integer = 4
        Do
            num += 1
            sum += num
        Loop Until num = 20
        Console.WriteLine("Sum = {0}", sum)
        Console.ReadKey()
    End Sub
End Module