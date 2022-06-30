<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txbN1 = New System.Windows.Forms.TextBox()
        Me.txbN2 = New System.Windows.Forms.TextBox()
        Me.rbSuma = New System.Windows.Forms.RadioButton()
        Me.rbResta = New System.Windows.Forms.RadioButton()
        Me.rbMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.rbDivision = New System.Windows.Forms.RadioButton()
        Me.rbPotencia = New System.Windows.Forms.RadioButton()
        Me.rbRaiz = New System.Windows.Forms.RadioButton()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbN1
        '
        Me.txbN1.Location = New System.Drawing.Point(27, 28)
        Me.txbN1.Name = "txbN1"
        Me.txbN1.Size = New System.Drawing.Size(100, 20)
        Me.txbN1.TabIndex = 0
        Me.txbN1.Text = "N1"
        '
        'txbN2
        '
        Me.txbN2.Location = New System.Drawing.Point(27, 54)
        Me.txbN2.Name = "txbN2"
        Me.txbN2.Size = New System.Drawing.Size(100, 20)
        Me.txbN2.TabIndex = 1
        Me.txbN2.Text = "N2"
        '
        'rbSuma
        '
        Me.rbSuma.AutoSize = True
        Me.rbSuma.Location = New System.Drawing.Point(6, 27)
        Me.rbSuma.Name = "rbSuma"
        Me.rbSuma.Size = New System.Drawing.Size(31, 17)
        Me.rbSuma.TabIndex = 2
        Me.rbSuma.TabStop = True
        Me.rbSuma.Text = "+"
        Me.rbSuma.UseVisualStyleBackColor = True
        '
        'rbResta
        '
        Me.rbResta.AutoSize = True
        Me.rbResta.Location = New System.Drawing.Point(6, 50)
        Me.rbResta.Name = "rbResta"
        Me.rbResta.Size = New System.Drawing.Size(28, 17)
        Me.rbResta.TabIndex = 3
        Me.rbResta.TabStop = True
        Me.rbResta.Text = "-"
        Me.rbResta.UseVisualStyleBackColor = True
        '
        'rbMultiplicacion
        '
        Me.rbMultiplicacion.AutoSize = True
        Me.rbMultiplicacion.Location = New System.Drawing.Point(6, 73)
        Me.rbMultiplicacion.Name = "rbMultiplicacion"
        Me.rbMultiplicacion.Size = New System.Drawing.Size(32, 17)
        Me.rbMultiplicacion.TabIndex = 4
        Me.rbMultiplicacion.TabStop = True
        Me.rbMultiplicacion.Text = "X"
        Me.rbMultiplicacion.UseVisualStyleBackColor = True
        '
        'rbDivision
        '
        Me.rbDivision.AutoSize = True
        Me.rbDivision.Location = New System.Drawing.Point(6, 96)
        Me.rbDivision.Name = "rbDivision"
        Me.rbDivision.Size = New System.Drawing.Size(30, 17)
        Me.rbDivision.TabIndex = 5
        Me.rbDivision.TabStop = True
        Me.rbDivision.Text = "/"
        Me.rbDivision.UseVisualStyleBackColor = True
        '
        'rbPotencia
        '
        Me.rbPotencia.AutoSize = True
        Me.rbPotencia.Location = New System.Drawing.Point(6, 119)
        Me.rbPotencia.Name = "rbPotencia"
        Me.rbPotencia.Size = New System.Drawing.Size(31, 17)
        Me.rbPotencia.TabIndex = 6
        Me.rbPotencia.TabStop = True
        Me.rbPotencia.Text = "^"
        Me.rbPotencia.UseVisualStyleBackColor = True
        '
        'rbRaiz
        '
        Me.rbRaiz.AutoSize = True
        Me.rbRaiz.Location = New System.Drawing.Point(6, 142)
        Me.rbRaiz.Name = "rbRaiz"
        Me.rbRaiz.Size = New System.Drawing.Size(45, 17)
        Me.rbRaiz.TabIndex = 7
        Me.rbRaiz.TabStop = True
        Me.rbRaiz.Text = "sqr()"
        Me.rbRaiz.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(155, 267)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(39, 13)
        Me.lblResultado.TabIndex = 8
        Me.lblResultado.Text = "Label1"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(146, 340)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 9
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.rbRaiz)
        Me.GroupBox1.Controls.Add(Me.rbPotencia)
        Me.GroupBox1.Controls.Add(Me.rbDivision)
        Me.GroupBox1.Controls.Add(Me.rbMultiplicacion)
        Me.GroupBox1.Controls.Add(Me.rbResta)
        Me.GroupBox1.Controls.Add(Me.rbSuma)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 165)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 376)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txbN2)
        Me.Controls.Add(Me.txbN1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbN1 As System.Windows.Forms.TextBox
    Friend WithEvents txbN2 As System.Windows.Forms.TextBox
    Friend WithEvents rbSuma As System.Windows.Forms.RadioButton
    Friend WithEvents rbResta As System.Windows.Forms.RadioButton
    Friend WithEvents rbMultiplicacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbDivision As System.Windows.Forms.RadioButton
    Friend WithEvents rbPotencia As System.Windows.Forms.RadioButton
    Friend WithEvents rbRaiz As System.Windows.Forms.RadioButton
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
