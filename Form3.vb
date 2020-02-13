Public Class Form3
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim valor As Integer = NumericUpDown1.Value
        Dim resultado As String
        Label9.Visible = True
        resultado = FormatNumber(TextBox7.Text, valor)
        Label9.Text = resultado
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox7.Text = Text) Then Button3.Visible = True
        Dim valor As Integer = NumericUpDown2.Value
        Label10.Visible = True
        Label10.Text = Math.Round(Convert.ToDouble(TextBox7.Text), valor)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim valor As Integer = NumericUpDown3.Value
        Dim nuevo As Integer
        For i = 1 To valor Step 1
            nuevo *= 10
        Next i
        Label11.Visible = True
        Label11.Text = Math.Truncate(Convert.ToDouble(TextBox8.Text * nuevo))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim valor As Integer = NumericUpDown4.Value
        Label12.Visible = True
        Label12.Text = Math.Round(Convert.ToDouble(TextBox8.Text), valor)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox7.Visible = True
        TextBox7.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        NumericUpDown3.Value = 0
        NumericUpDown4.Value = 0
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As String
        res = Val(TextBox1.Text) - Val(TextBox2.Text)
        TextBox8.Text = res / TextBox2.Text
        TextBox8.Visible = True
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If (TextBox7.Text = "") Then
            Button3.Enabled = False
            Button5.Enabled = False
        ElseIf (Not (TextBox7.Text = "")) Then
            Button3.Enabled = True
            Button5.Enabled = True
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If (TextBox8.Text = "") Then
            Button4.Enabled = False
            Button6.Enabled = False
        ElseIf (Not (TextBox8.Text = "")) Then
            Button4.Enabled = True
            Button6.Enabled = True
        End If
    End Sub
End Class