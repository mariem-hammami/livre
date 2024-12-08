<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listes_des_livres
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lst_isbn = New ListBox()
        lst_titre = New ListBox()
        lst_auteur = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(8))
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        Label1.Location = New Point(87, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 20)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(8))
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        Label2.Location = New Point(339, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 20)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(8))
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        Label3.Location = New Point(568, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 20)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' lst_isbn
        ' 
        lst_isbn.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(130))
        lst_isbn.FormattingEnabled = True
        lst_isbn.Location = New Point(47, 107)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(168, 264)
        lst_isbn.TabIndex = 3
        ' 
        ' lst_titre
        ' 
        lst_titre.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(130))
        lst_titre.FormattingEnabled = True
        lst_titre.Location = New Point(291, 107)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(168, 264)
        lst_titre.TabIndex = 4
        ' 
        ' lst_auteur
        ' 
        lst_auteur.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(130))
        lst_auteur.FormattingEnabled = True
        lst_auteur.Location = New Point(531, 107)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(168, 264)
        lst_auteur.TabIndex = 5
        ' 
        ' Listes_des_livres
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(245), CByte(157))
        ClientSize = New Size(753, 450)
        Controls.Add(lst_auteur)
        Controls.Add(lst_titre)
        Controls.Add(lst_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        Name = "Listes_des_livres"
        Text = "Listes_des_livres"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
End Class
