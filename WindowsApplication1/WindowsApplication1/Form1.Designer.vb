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
        Me.cbxFigura = New System.Windows.Forms.ComboBox()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.lbLadoA = New System.Windows.Forms.Label()
        Me.lbLadoB = New System.Windows.Forms.Label()
        Me.txtLadoA = New System.Windows.Forms.TextBox()
        Me.txtLadoB = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbxFigura
        '
        Me.cbxFigura.FormattingEnabled = True
        Me.cbxFigura.Items.AddRange(New Object() {"Cuadrado", "Rectángulo", "Triángulo", "Paralelogramo"})
        Me.cbxFigura.Location = New System.Drawing.Point(62, 72)
        Me.cbxFigura.Name = "cbxFigura"
        Me.cbxFigura.Size = New System.Drawing.Size(121, 21)
        Me.cbxFigura.TabIndex = 0
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Location = New System.Drawing.Point(59, 35)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(155, 13)
        Me.lb1.TabIndex = 1
        Me.lb1.Text = "Seleccione la figura a calcular: "
        '
        'lbLadoA
        '
        Me.lbLadoA.AutoSize = True
        Me.lbLadoA.Location = New System.Drawing.Point(59, 118)
        Me.lbLadoA.Name = "lbLadoA"
        Me.lbLadoA.Size = New System.Drawing.Size(39, 13)
        Me.lbLadoA.TabIndex = 2
        Me.lbLadoA.Text = "Label2"
        Me.lbLadoA.Visible = False
        '
        'lbLadoB
        '
        Me.lbLadoB.AutoSize = True
        Me.lbLadoB.Location = New System.Drawing.Point(209, 118)
        Me.lbLadoB.Name = "lbLadoB"
        Me.lbLadoB.Size = New System.Drawing.Size(39, 13)
        Me.lbLadoB.TabIndex = 3
        Me.lbLadoB.Text = "Label3"
        Me.lbLadoB.Visible = False
        '
        'txtLadoA
        '
        Me.txtLadoA.Location = New System.Drawing.Point(58, 150)
        Me.txtLadoA.Name = "txtLadoA"
        Me.txtLadoA.Size = New System.Drawing.Size(71, 20)
        Me.txtLadoA.TabIndex = 4
        Me.txtLadoA.Visible = False
        '
        'txtLadoB
        '
        Me.txtLadoB.Location = New System.Drawing.Point(212, 150)
        Me.txtLadoB.Name = "txtLadoB"
        Me.txtLadoB.Size = New System.Drawing.Size(65, 20)
        Me.txtLadoB.TabIndex = 5
        Me.txtLadoB.Visible = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(58, 200)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(58, 245)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(234, 20)
        Me.txtResultado.TabIndex = 7
        Me.txtResultado.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 293)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtLadoB)
        Me.Controls.Add(Me.txtLadoA)
        Me.Controls.Add(Me.lbLadoB)
        Me.Controls.Add(Me.lbLadoA)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.cbxFigura)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxFigura As ComboBox
    Friend WithEvents lb1 As Label
    Friend WithEvents lbLadoA As Label
    Friend WithEvents lbLadoB As Label
    Friend WithEvents txtLadoA As TextBox
    Friend WithEvents txtLadoB As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtResultado As TextBox
End Class
