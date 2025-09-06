
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtDisplay = New TextBox()
        btn0 = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btnSuma = New Button()
        btnResta = New Button()
        btnMultiplicacion = New Button()
        btnDivision = New Button()
        btnIgual = New Button()
        btnC = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Font = New Font("Microsoft Sans Serif", 16.0F)
        txtDisplay.Location = New Point(14, 90)
        txtDisplay.Margin = New Padding(4, 3, 4, 3)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.Size = New Size(303, 32)
        txtDisplay.TabIndex = 1
        txtDisplay.Text = "0"
        txtDisplay.TextAlign = HorizontalAlignment.Right
        ' 
        ' btn0
        ' 
        btn0.Font = New Font("Microsoft Sans Serif", 12.0F)
        btn0.Location = New Point(14, 346)
        btn0.Margin = New Padding(4, 3, 4, 3)
        btn0.Name = "btn0"
        btn0.Size = New Size(224, 46)
        btn0.TabIndex = 17
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Microsoft Sans Serif", 12.0F)
        btn1.Location = New Point(14, 293)
        btn1.Margin = New Padding(4, 3, 4, 3)
        btn1.Name = "btn1"
        btn1.Size = New Size(70, 46)
        btn1.TabIndex = 13
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Font = New Font("Microsoft Sans Serif", 12.0F)
        btn2.Location = New Point(91, 293)
        btn2.Margin = New Padding(4, 3, 4, 3)
        btn2.Name = "btn2"
        btn2.Size = New Size(70, 46)
        btn2.TabIndex = 14
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Font = New Font("Microsoft Sans Serif", 12.0F)
        btn3.Location = New Point(168, 293)
        btn3.Margin = New Padding(4, 3, 4, 3)
        btn3.Name = "btn3"
        btn3.Size = New Size(70, 46)
        btn3.TabIndex = 15
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Font = New Font("Microsoft Sans Serif", 12.0F)
        btn4.Location = New Point(14, 240)
        btn4.Margin = New Padding(4, 3, 4, 3)
        btn4.Name = "btn4"
        btn4.Size = New Size(70, 46)
        btn4.TabIndex = 9
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Font = New Font("Microsoft Sans Serif", 12.0F)
        btn5.Location = New Point(91, 240)
        btn5.Margin = New Padding(4, 3, 4, 3)
        btn5.Name = "btn5"
        btn5.Size = New Size(70, 46)
        btn5.TabIndex = 10
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Font = New Font("Microsoft Sans Serif", 12.0F)
        btn6.Location = New Point(168, 240)
        btn6.Margin = New Padding(4, 3, 4, 3)
        btn6.Name = "btn6"
        btn6.Size = New Size(70, 46)
        btn6.TabIndex = 11
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Font = New Font("Microsoft Sans Serif", 12.0F)
        btn7.Location = New Point(14, 187)
        btn7.Margin = New Padding(4, 3, 4, 3)
        btn7.Name = "btn7"
        btn7.Size = New Size(70, 46)
        btn7.TabIndex = 5
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Font = New Font("Microsoft Sans Serif", 12.0F)
        btn8.Location = New Point(91, 187)
        btn8.Margin = New Padding(4, 3, 4, 3)
        btn8.Name = "btn8"
        btn8.Size = New Size(70, 46)
        btn8.TabIndex = 6
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Font = New Font("Microsoft Sans Serif", 12.0F)
        btn9.Location = New Point(168, 187)
        btn9.Margin = New Padding(4, 3, 4, 3)
        btn9.Name = "btn9"
        btn9.Size = New Size(70, 46)
        btn9.TabIndex = 7
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btnSuma
        ' 
        btnSuma.Font = New Font("Microsoft Sans Serif", 12.0F)
        btnSuma.Location = New Point(245, 240)
        btnSuma.Margin = New Padding(4, 3, 4, 3)
        btnSuma.Name = "btnSuma"
        btnSuma.Size = New Size(70, 46)
        btnSuma.TabIndex = 12
        btnSuma.Text = "+"
        btnSuma.UseVisualStyleBackColor = True
        ' 
        ' btnResta
        ' 
        btnResta.Font = New Font("Microsoft Sans Serif", 12.0F)
        btnResta.Location = New Point(245, 187)
        btnResta.Margin = New Padding(4, 3, 4, 3)
        btnResta.Name = "btnResta"
        btnResta.Size = New Size(70, 46)
        btnResta.TabIndex = 8
        btnResta.Text = "-"
        btnResta.UseVisualStyleBackColor = True
        ' 
        ' btnMultiplicacion
        ' 
        btnMultiplicacion.Font = New Font("Microsoft Sans Serif", 12.0F)
        btnMultiplicacion.Location = New Point(248, 134)
        btnMultiplicacion.Margin = New Padding(4, 3, 4, 3)
        btnMultiplicacion.Name = "btnMultiplicacion"
        btnMultiplicacion.Size = New Size(70, 46)
        btnMultiplicacion.TabIndex = 4
        btnMultiplicacion.Text = "X"
        btnMultiplicacion.UseVisualStyleBackColor = True
        ' 
        ' btnDivision
        ' 
        btnDivision.Font = New Font("Microsoft Sans Serif", 12.0F)
        btnDivision.Location = New Point(172, 134)
        btnDivision.Margin = New Padding(4, 3, 4, 3)
        btnDivision.Name = "btnDivision"
        btnDivision.Size = New Size(70, 46)
        btnDivision.TabIndex = 3
        btnDivision.Text = "/"
        btnDivision.UseVisualStyleBackColor = True
        ' 
        ' btnIgual
        ' 
        btnIgual.Font = New Font("Microsoft Sans Serif", 12.0F)
        btnIgual.Location = New Point(245, 293)
        btnIgual.Margin = New Padding(4, 3, 4, 3)
        btnIgual.Name = "btnIgual"
        btnIgual.Size = New Size(70, 99)
        btnIgual.TabIndex = 16
        btnIgual.Text = "="
        btnIgual.UseVisualStyleBackColor = True
        ' 
        ' btnC
        ' 
        btnC.Font = New Font("Microsoft Sans Serif", 12.0F)
        btnC.Location = New Point(14, 134)
        btnC.Margin = New Padding(4, 3, 4, 3)
        btnC.Name = "btnC"
        btnC.Size = New Size(146, 46)
        btnC.TabIndex = 2
        btnC.Text = "Borrar"
        btnC.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LOGO_FONDO_BLANCO_JPG
        PictureBox1.Location = New Point(54, 15)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(226, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(331, 406)
        Controls.Add(btn0)
        Controls.Add(btnIgual)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btnSuma)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btnResta)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btnMultiplicacion)
        Controls.Add(btnDivision)
        Controls.Add(btnC)
        Controls.Add(txtDisplay)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Eva1 J. Rodriguez Y.Herrera"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btn0 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnC As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class