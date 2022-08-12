Module Matematica

    Public Function Sumar(a As Double, b As Double) As Double
        Dim resultado As Double
        resultado = a + b
        Return resultado


    End Function

    Public Function Multiplicar(a As Double, b As Double) As Double
        Dim resultado As Double
        resultado = a * b
        Return resultado
    End Function

    Public Function Restar(a As Double, b As Double) As Double
        Dim resultado As Double
        resultado = a - b
        Return resultado
    End Function
    Public Function Dividir(a As Double, b As Double) As Double
        Dim resultado As Double
        If (b = 0) Then
            Return 0
        Else
            resultado = a / b
            Return resultado
        End If


    End Function

    Public Function Potenciar(a As Double, b As Double) As Double
        Dim resultado As Double
        resultado = a ^ b
        Return resultado


    End Function
End Module
