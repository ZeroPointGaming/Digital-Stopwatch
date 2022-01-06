Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        LabelSecond.Text = "00"
        LabelMinute.Text = "00"
        LabelHour.Text = "00"
        LabelDay.Text = "00"
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 5
        LabelSecond.Text = LabelSecond.Text + 1

        If LabelSecond.Text = 60 Then
            LabelSecond.Text = 0
            LabelMinute.text = labelminute.text + 1
            If LabelMinute.text = 60 Then
                LabelMinute.Text = 0
                LabelHour.Text = LabelHour.Text + 1
                If LabelHour.Text = 24 Then
                    LabelDay.Text = LabelDay.Text + 1
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click
        Process.Start("http://www.youtube.com/user/comfyseve")
    End Sub
End Class
