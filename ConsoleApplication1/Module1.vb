Module Module1

    Sub Main()
        Console.WriteLine("請輸入數值=")
        Dim size As Integer = Val(Console.ReadLine())
        Dim a As Integer = 0
        Dim numberarray(size) As Integer

        Do
            numberarray(a) = Val(Console.ReadLine())
            a = a + 1
        Loop While (a < size)

        Console.WriteLine("max={0}", getmax(numberarray))
        Console.WriteLine("min={0}", getmin(numberarray))

        For i As Integer = 0 To UBound(numberarray)
            Console.Write(numberarray(i).ToString() + " ")
        Next
        For j As Integer = 1 To LBound(numberarray)
            Console.Write(numberarray(j).ToString() + " ")

        Next
        Console.ReadLine()
    End Sub
    Function getmax(ByVal ParamArray x() As Integer) As Integer
        Dim max As Integer
        max = x(1)
        For i As Integer = 0 To UBound(x)
            If (x(i) > max) Then
                max = x(i)
            End If
        Next
        Return max
    End Function

    Function getmin(ByVal ParamArray X() As Integer) As Integer
        Dim min As Integer
        min = X(1)
        For j As Integer = 1 To LBound(X)
            If (x(j) < min) Then
                min = x(j)
            End If
        Next
        Return min
    End Function

End Module
