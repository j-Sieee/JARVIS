Public Class UserInfo

    Private Sub UserInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NameTextBox.Text = System.IO.File.ReadAllText("UserInfo.txt")



    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SaveeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveeButton.Click

        System.IO.File.WriteAllText("UserInfo.txt", NameTextBox.Text)




    End Sub
End Class