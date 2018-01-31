Public Class AlphaInCell

    Private Sub AlphaInCell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = AlphaText
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim correct As String = TextBox1.Text
        Form1.DataGridView1.CurrentCell.Value = correct
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim kaka As String
        kaka = TextBox1.Text
        Dim milan As Char
        For i = 0 To kaka.Length - 1
            milan = kaka.Chars(i)
            If IsNumeric(milan) = False And milan <> "." Then
                Label2.Show()
                Label3.Show()
            Else
                Label2.Hide()
                Label3.Hide()
                ButtonOK.Show()
            End If
        Next
    End Sub
End Class