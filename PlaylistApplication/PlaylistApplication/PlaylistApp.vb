Imports AxShockwaveFlashObjects

Public Class PlaylistApp
    Public Property AxShockwaveFlash1 As Object

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

    Private Sub btnEditPlaylist_Click(sender As Object, e As EventArgs) Handles btnEditPlaylist.Click
        EditPlaylist.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRank_Click(sender As Object, e As EventArgs) Handles btnRank.Click
        Rate.Show()
    End Sub

    Private Sub PlaylistApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class