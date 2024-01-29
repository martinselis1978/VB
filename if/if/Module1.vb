Imports System.Diagnostics.Eventing.Reader

Module Module1

    Sub Main()

        Console.Write("Ingrese el valor de la compra --> ")
        Dim valorCompra As Double = Console.ReadLine()
        Dim descuento As Double = 0

        If valorCompra >= 50 And valorCompra <= 100 Then

            descuento = valorCompra * 0.05

        ElseIf valorCompra > 100 And valorCompra <= 150 Then

            descuento = valorCompra * 0.1

        ElseIf valorCompra > 150 Then

            descuento = valorCompra * 0.15

        End If

        Console.WriteLine("El valor de la compra es de: " & valorCompra)
        Console.WriteLine("El descuento aplicado es de: " & descuento)
        Console.WriteLine("El total a pagar es: " & valorCompra - descuento)

        Console.ReadKey()

    End Sub

End Module