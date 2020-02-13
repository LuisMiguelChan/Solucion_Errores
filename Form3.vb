Public Class Form3
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f2 As New Form4
        f2.Show()
        Me.Hide()
        Dim valor As Integer = Form4.TextBox1.Text

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f2 As New Form4
        f2.Show()
        Me.Hide()
        Dim valor As Integer = Form4.TextBox1.Text 
        TextBox5.Visible = True
        TextBox5.Text = Math.Round(Convert.ToDouble(TextBox7.Text), valor)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f2 As New Form4
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim f2 As New Form4
        f2.Show()
        Me.Hide()
        Dim valor As Integer = Form4.TextBox1.Text
        TextBox6.Visible = True
        TextBox6.Text = Math.Round(Convert.ToDouble(TextBox6.Text), valor)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox7.Visible = True
        TextBox7.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As String
        res = Val(TextBox1.Text) - Val(TextBox2.Text)
        TextBox8.Text = res / TextBox2.Text
        TextBox8.Visible = True
    End Sub
End Class