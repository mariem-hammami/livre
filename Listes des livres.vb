Public Class Listes_des_livres
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Listes_des_livres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher_livre(lst_isbn, lst_titre, lst_auteur)
    End Sub
End Class