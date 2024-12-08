Module gestion_Livre
    Public Structure Livre
        Dim ISBN As Integer
        Dim titre As String
        Dim auteur As String
    End Structure
    Public biblio(100) As Livre
    Dim nb As Integer = 0

    Function ajoutLivre(l As Livre) As Boolean
        If nb < biblio.Length Then
            biblio(nb) = l
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function
    Sub afficher_livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For i As Integer = 0 To nb - 1
            l1.Items.Add(biblio(i).ISBN)
            l2.Items.Add(biblio(i).titre)
            l3.Items.Add(biblio(i).auteur)
        Next
    End Sub
    Sub afficher2_livre(dgv_Livre As DataGridView)
        For i As Integer = 0 To nb - 1
            Dim livre As Livre = biblio(i)
            dgv_Livre.Rows.Add(livre.ISBN, livre.titre, livre.auteur)
        Next
    End Sub
End Module
