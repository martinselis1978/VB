Module Module1

    Sub Main()

        Dim resultado As Integer = Sumar(20, 15)

        Console.WriteLine(Sumar(2, 2))

    End Sub

    Function Sumar(num1 As Integer, num2 As Integer) As Integer

        'Return num1 + num2 esta es una forma

        'eta es ontra forma
        Dim resultado As Integer ' se podria simplificar Dim resultado as Integer = num1 + num2

        resultado = num1 + num2

        Return resultado


    End Function

End Module
