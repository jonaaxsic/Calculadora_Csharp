
Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Dim valor1 As Double = 0
    Dim valor2 As Double = 0
    Dim operacion As String = ""
    Dim operacionEnCurso As Boolean = False

    Private Sub btnNumero_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        If txtDisplay.Text = "0" Or operacionEnCurso Then
            txtDisplay.Text = ""
            operacionEnCurso = False
        End If
        txtDisplay.Text &= CType(sender, Button).Text
    End Sub

    Private Sub btnOperacion_Click(sender As Object, e As EventArgs) Handles btnSuma.Click, btnResta.Click, btnMultiplicacion.Click, btnDivision.Click
        valor1 = Val(txtDisplay.Text)
        operacion = CType(sender, Button).Text
        operacionEnCurso = True
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        valor2 = Val(txtDisplay.Text)
        Dim resultado As Double = 0
        Try
            Select Case operacion
                Case "+"
                    resultado = valor1 + valor2
                Case "-"
                    resultado = valor1 - valor2
                Case "X"
                    resultado = valor1 * valor2
                Case "/"
                    If valor2 = 0 Then
                        MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtDisplay.Text = "0"
                        Exit Sub
                    End If
                    resultado = valor1 / valor2
            End Select
            txtDisplay.Text = resultado.ToString()
        Catch ex As Exception
            MessageBox.Show("Error en el cálculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDisplay.Text = "0"
        End Try
        operacionEnCurso = True
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtDisplay.Text = "0"
        valor1 = 0
        valor2 = 0
        operacion = ""
        operacionEnCurso = False
    End Sub

End Class