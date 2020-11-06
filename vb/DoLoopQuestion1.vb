Module DoLoopQuestion1
    Sub Main()
        Dim num As Byte = 19
        Do 
            num += 1
            Console.WriteLine(num)
        Loop Until num = 35
        Console.ReadKey()
    End Sub
End Module