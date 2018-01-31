Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'for McCabe-Thiele
        Dim graphmin As Double = 0
        Dim graphmax As Double = 1.2
        Dim graphinterval As Double = 0.1


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kaka As String
        kaka = DataGridView1.CurrentCell.Value
        Dim milan As Char
        For i = 0 To kaka.Length - 1
            Dim correct As String
            milan = kaka.Chars(i)
            If IsNumeric(milan) = False Then

                'MsgBox("remove letter")
            Else
                Dim italy As String
                italy = milan
                correct = correct + italy
                DataGridView1.CurrentCell.Value = correct
            End If
        Next
        Dim n As String = DataGridView1.CurrentCell.Value
        Label9.Text = n.Length
        ' MsgBox(kaka)
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim kaka As String
        kaka = DataGridView1.CurrentCell.Value
        Dim milan As Char
        For i = 0 To kaka.Length - 1
            milan = kaka.Chars(i)
            If IsNumeric(milan) = False And milan <> "." Then
                AlphaText = kaka
                ' MsgBox("Remove Letter")
                Exit Sub
            End If
        Next
    End Sub

  

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
