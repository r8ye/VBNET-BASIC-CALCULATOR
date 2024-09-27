Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtRersult.Text = txtRersult.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtRersult.Text = txtRersult.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtRersult.Text = txtRersult.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtRersult.Text = txtRersult.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtRersult.Text = txtRersult.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtRersult.Text = txtRersult.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtRersult.Text = txtRersult.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtRersult.Text = txtRersult.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtRersult.Text = txtRersult.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtRersult.Text = txtRersult.Text + "0"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblNumerator.Text = txtRersult.Text
        lblOperator.Text = "+"
        txtRersult.Text = ""
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        lblNumerator.Text = txtRersult.Text
        lblOperator.Text = "-"
        txtRersult.Text = ""
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        lblNumerator.Text = txtRersult.Text
        lblOperator.Text = "*"
        txtRersult.Text = ""
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        lblNumerator.Text = txtRersult.Text
        lblOperator.Text = "\"
        txtRersult.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        txtRersult.Text = ""
        lblNumerator.Text = ""
        lblOperator.Text = ""
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If lblOperator.Text = "+" Then
            txtRersult.Text = Val(lblNumerator.Text) + (txtRersult.Text)
            lblNumerator.Text = ""
            lblOperator.Text = "="
        End If

        If lblOperator.Text = "-" Then
            txtRersult.Text = Val(lblNumerator.Text) - Val(txtRersult.Text)
            lblNumerator.Text = ""
            lblOperator.Text = "="
        End If

        If lblOperator.Text = "*" Then
            txtRersult.Text = Val(lblNumerator.Text) * Val(txtRersult.Text)
            lblNumerator.Text = ""
            lblOperator.Text = "="
        End If

        If lblOperator.Text = "\" Then
            txtRersult.Text = Val(lblNumerator.Text) \ Val(txtRersult.Text)
            lblNumerator.Text = ""
            lblOperator.Text = "="
        End If


    End Sub
End Class
