Public Class Form1
    Dim turn As String = "X"
    Dim score1 As Integer
    Dim score2 As Integer
    Sub reset()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Label1.Text = score1
        Label2.Text = score2
        Me.BackColor = Color.White
    End Sub
    Sub pick(B As Button)
        B.Text = turn
        If turn = "X" Then
            turn = "O"
        Else
            turn = "X"
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        pick(sender)
        If iswinner() Then Me.BackColor = Color.Green
    End Sub
    Function iswinner() As Boolean
        If Button1.Text = Button2.Text And Button2.Text = Button3.Text And Button1.Text <> "" Then Return True
        If Button4.Text = Button5.Text And Button5.Text = Button6.Text And Button4.Text <> "" Then Return True
        If Button7.Text = Button8.Text And Button8.Text = Button9.Text And Button7.Text <> "" Then Return True
        If Button1.Text = Button4.Text And Button4.Text = Button7.Text And Button1.Text <> "" Then Return True
        If Button2.Text = Button5.Text And Button5.Text = Button8.Text And Button2.Text <> "" Then Return True
        If Button3.Text = Button6.Text And Button6.Text = Button9.Text And Button3.Text <> "" Then Return True
        If Button1.Text = Button5.Text And Button5.Text = Button9.Text And Button1.Text <> "" Then Return True
        If Button3.Text = Button5.Text And Button5.Text = Button7.Text And Button3.Text <> "" Then Return True
        Return False
        If turn = "O" Then
            score1 = score1 + 1
        Else
            score2 = score2 + 2
        End If

        MsgBox("Winner")
        reset()
    End Function
    Private Sub ButtonR_Click(sender As Object, e As EventArgs) Handles ButtonR.Click
        reset()
    End Sub
End Class