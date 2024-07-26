Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer
        Dim txtNum1, txtNum2 As Integer
        Try
            result = txtNum1 / txtNum2
        Catch ex As DivideByZeroException
            Console.WriteLine("Exception caught: {0}", ex)
        Catch ex As OverflowException
            MessageBox.Show(ex.Message)
        Finally
            Console.WriteLine("Result: {0}", result)
        End Try
    End Sub
End Class
