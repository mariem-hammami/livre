<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Livre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_isbn = New TextBox()
        txt_titre = New TextBox()
        txt_auteur = New TextBox()
        btn_ajouter = New Button()
        btn_afficher = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(251), CByte(192), CByte(45))
        Label1.Font = New Font("Segoe UI", 9.8F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        Label1.Location = New Point(95, 76)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 23)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(251), CByte(192), CByte(45))
        Label2.Font = New Font("Segoe UI", 9.8F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        Label2.Location = New Point(95, 152)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 23)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(251), CByte(192), CByte(45))
        Label3.Font = New Font("Segoe UI", 9.8F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        Label3.Location = New Point(95, 226)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 23)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' txt_isbn
        ' 
        txt_isbn.BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(118))
        txt_isbn.Location = New Point(309, 74)
        txt_isbn.Margin = New Padding(4, 3, 4, 3)
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(155, 29)
        txt_isbn.TabIndex = 3
        ' 
        ' txt_titre
        ' 
        txt_titre.BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(118))
        txt_titre.Location = New Point(309, 152)
        txt_titre.Margin = New Padding(4, 3, 4, 3)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(155, 29)
        txt_titre.TabIndex = 4
        ' 
        ' txt_auteur
        ' 
        txt_auteur.BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(118))
        txt_auteur.Location = New Point(309, 226)
        txt_auteur.Margin = New Padding(4, 3, 4, 3)
        txt_auteur.Name = "txt_auteur"
        txt_auteur.Size = New Size(155, 29)
        txt_auteur.TabIndex = 5
        ' 
        ' btn_ajouter
        ' 
        btn_ajouter.BackColor = Color.FromArgb(CByte(253), CByte(216), CByte(53))
        btn_ajouter.Font = New Font("Segoe UI", 9.8F, FontStyle.Bold)
        btn_ajouter.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        btn_ajouter.Location = New Point(173, 341)
        btn_ajouter.Margin = New Padding(4, 3, 4, 3)
        btn_ajouter.Name = "btn_ajouter"
        btn_ajouter.Size = New Size(117, 30)
        btn_ajouter.TabIndex = 6
        btn_ajouter.Text = "Ajouter"
        btn_ajouter.UseVisualStyleBackColor = False
        ' 
        ' btn_afficher
        ' 
        btn_afficher.BackColor = Color.FromArgb(CByte(253), CByte(216), CByte(53))
        btn_afficher.Font = New Font("Segoe UI", 9.8F, FontStyle.Bold)
        btn_afficher.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        btn_afficher.Location = New Point(447, 341)
        btn_afficher.Margin = New Padding(4, 3, 4, 3)
        btn_afficher.Name = "btn_afficher"
        btn_afficher.Size = New Size(117, 30)
        btn_afficher.TabIndex = 7
        btn_afficher.Text = "Afficher"
        btn_afficher.UseVisualStyleBackColor = False
        ' 
        ' Livre
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(196))
        ClientSize = New Size(704, 452)
        Controls.Add(btn_afficher)
        Controls.Add(btn_ajouter)
        Controls.Add(txt_auteur)
        Controls.Add(txt_titre)
        Controls.Add(txt_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9.8F, FontStyle.Bold)
        ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Livre"
        Text = "Livre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents txt_auteur As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button

End Class
