Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lb1.Click

    End Sub

    Private Sub cbxFigura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFigura.SelectedIndexChanged
        Dim figura As Integer
        figura = cbxFigura.SelectedIndex

        Select Case figura
            Case 0
                lbLadoA.Visible = True
                lbLadoA.Text = "Lado"
                txtLadoA.Visible = True
                txtLadoA.Text = "0"
                lbLadoB.Visible = False
                txtLadoB.Visible = False
            Case 1
                lbLadoA.Visible = True
                lbLadoA.Text = "Largo"
                txtLadoA.Visible = True
                txtLadoA.Text = "0"
                lbLadoB.Text = "Ancho"
                lbLadoB.Visible = True
                txtLadoB.Text = "0"
                txtLadoB.Visible = True


            Case 2
                lbLadoA.Visible = True
                lbLadoA.Text = "Base"
                txtLadoA.Visible = True
                txtLadoA.Text = "0"
                lbLadoB.Visible = True
                lbLadoB.Text = "Altura"
                txtLadoB.Visible = True
                txtLadoB.Text = "0"

            Case 3
                lbLadoA.Visible = True
                lbLadoA.Text = "Base"
                txtLadoA.Visible = True
                txtLadoA.Text = "0"
                lbLadoB.Visible = True
                lbLadoB.Text = "Altura"
                txtLadoB.Visible = True
                txtLadoB.Text = "0"

        End Select

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim calcular As Integer
        calcular = cbxFigura.SelectedIndex()
        Dim area As Integer

        Select Case calcular
            Case 0
                area = Int(txtLadoA.Text) * Int(txtLadoA.Text)

            Case 1
                area = Int(txtLadoA.Text) * Int(txtLadoB.Text)

            Case 2
                area = (Int(txtLadoA.Text) * Int(txtLadoB.Text)) / 2

            Case 3
                area = Int(txtLadoA.Text) * Int(txtLadoB.Text)

        End Select

        txtResultado.Visible = True
        txtResultado.Text = "El resultado es: " & area
    End Sub
End Class
