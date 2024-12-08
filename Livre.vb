Public Class Livre
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim l As gestion_Livre.Livre
        l.ISBN = txt_isbn.Text
        l.titre = txt_titre.Text
        l.auteur = txt_auteur.Text
        If String.IsNullOrWhiteSpace(l.ISBN) Then
            MessageBox.Show("Le champ pour l'entier est vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not Integer.TryParse(l.ISBN, Nothing) Then
            MessageBox.Show("Veuillez entrer un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(l.titre) Then
            MessageBox.Show("Le titre est vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Vérifie si TextBoxString2 est vide
        If String.IsNullOrWhiteSpace(l.auteur) Then
            MessageBox.Show("L'auteur est vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ajoutLivre(l) Then
            MessageBox.Show("ajout du livre avec succes")
        Else
            MessageBox.Show("le tableau bibliotheque est saturé")
        End If
    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        Listes_des_livres.Show()
        frm_afficher2.Show()
    End Sub

    Private Sub Livre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_isbn.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Erreur:entrer seulement des chiffres")
        End If
    End Sub
End Class
