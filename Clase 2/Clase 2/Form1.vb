Public Class Form1

    Sub Calculadora()
        Dim n1, n2 As Integer
        Dim boton
        n1 = Val(txbN1.Text)
        n2 = Val(txbN2.Text)
        'IF= si condicional: ELSE= De lo contrario
        If rbSuma.Checked Then
            lblResultado.Text = Str(n1) + " + " + Str(n2) + " = " + Str(n1 + n2)
        ElseIf rbResta.Checked Then
            lblResultado.Text = Str(n1) + " - " + Str(n2) + " = " + Str(n1 - n2)
        ElseIf rbMultiplicacion.Checked Then
            lblResultado.Text = Str(n1) + " * " + Str(n2) + " = " + Str(n1 * n2)
        ElseIf rbDivision.Checked Then
            lblResultado.Text = Str(n1) + " / " + Str(n2) + " = " + Str(n1 / n2)
        ElseIf rbPotencia.Checked Then
            lblResultado.Text = Str(n1) + " ^ " + Str(n2) + " = " + Str(n1 ^ n2)
        ElseIf rbRaiz.Checked Then
            lblResultado.Text = Str(n1) + " + " + Str(n2) + " = " + Str(n1 ^ (1 / n2))
        Else
            boton = MsgBox("Error: Operadoor no detectado" & vbNewLine & "¿Desea volver a intentar?", MsgBoxStyle.Critical + vbYesNo, "Error")
            If boton = vbNo Then
                Me.Close()
            Else
                MsgBox("Seleccione una operacion")
            End If
        End If

    End Sub
    
    Private Sub txbN1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbN1.Click
        txbN1.Text = ""
    End Sub

    Private Sub txbN2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbN2.Click
        txbN2.Text = ""
    End Sub
    Private Sub txbN1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbN1.KeyPress
        Dim var As Boolean
        var = Char.IsDigit(e.KeyChar)

        If var Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txbN2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbN2.KeyPress
        Dim var As Boolean
        var = Char.IsDigit(e.KeyChar)

        If var Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Calculadora()
    End Sub
End Class
