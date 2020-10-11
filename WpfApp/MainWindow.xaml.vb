Class MainWindow
    Private Sub radioButton1_Checked(sender As Object, e As RoutedEventArgs) Handles btnA.Checked

    End Sub

    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        If btnA.IsChecked = True Then
            MessageBox.Show("A checked")
        ElseIf btnB.IsChecked = True Then
            MessageBox.Show("B checked")


        End If
    End Sub

    Private Sub radioButton_Checked(sender As Object, e As RoutedEventArgs) Handles btnB.Checked

    End Sub
End Class
