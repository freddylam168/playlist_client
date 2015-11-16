Public Class PlaylistApp
    Private Sub btnSearchUsername_Click(sender As Object, e As EventArgs) Handles btnSearchUsername.Click
        SearchUser.Show()
    End Sub

    Private Sub btnSearchPlaylist_Click(sender As Object, e As EventArgs) Handles btnSearchPlaylist.Click
        SearchPlaylist.Show()
    End Sub

    Private Sub btnSearchTrack_Click(sender As Object, e As EventArgs) Handles btnSearchTrack.Click
        SearchTrack.Show()
    End Sub

    Private Sub btnAddPlaylist_Click(sender As Object, e As EventArgs) Handles btnAddPlaylist.Click
        AddPlaylist.Show()
    End Sub
End Class