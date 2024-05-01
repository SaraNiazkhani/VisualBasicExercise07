Public Class Form1
    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click

        Dim outerLoopCount As Integer = 0 ' تعداد حلقه‌های بیرونی
        Dim innerLoopCount As Integer = 0 ' تعداد حلقه‌های داخلی


        ' حلقه بیرونی برای متغیر i
        For i As Integer = 1 To 5
            outerLoopCount += 1 ' افزودن یک به تعداد حلقه‌های بیرونی

            ' حلقه داخلی برای متغیر j
            For j As Integer = 1 To 3
                innerLoopCount += 1 ' افزودن یک به تعداد حلقه‌های داخلی
            Next
        Next
        ' نمایش تعداد حلقه‌های بیرونی و داخلی

        OutputLabel.Text = ("تعداد حلقه‌های بیرونی: " & outerLoopCount.ToString() & vbCrLf & "تعداد حلقه‌های داخلی: " & innerLoopCount.ToString())
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub
End Class

