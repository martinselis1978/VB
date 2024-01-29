Module Module1

    Sub Main()

        Console.Write("Ingrese el valor del artículo: ")
        Dim valorArticulo As Double = Console.ReadLine

        Console.Write("Ingrese el descuento que se va a aplicar: ")
        Dim descuento As Double = Console.ReadLine

        Try

            compruebaDescuento(valorArticulo, descuento)

        Catch ex As OverflowException

            Console.WriteLine(ex.Message)

        Finally

            Console.WriteLine("El valor del articulo es: " & valorArticulo)

        End Try


    End Sub

    Sub compruebaDescuento(valor As Double, descuento As Double)

        Dim totalDescuento As Double = (valor * descuento) / 100

        If totalDescuento > 400 Then

            Throw New OverflowException

        Else

            Console.WriteLine("El descuento es de: " & totalDescuento)

        End If

    End Sub

End Module
