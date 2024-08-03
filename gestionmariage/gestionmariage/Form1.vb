
Imports System.Data.OleDb
Public Class Form1
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gestionmariage.accdb;Persist Security Info=False"
    Private Sub TextBox5_TextChanged(snder As Object, e As EventArgs) Handles commune.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub modifier_Click(sender As Object, e As EventArgs) Handles modifier.Click
        Dim epoux As String = Me.epoux.Text
        Dim epouse As String = Me.epouse.Text
        Dim pere As String = Me.temMarier.Text
        Dim comm As String = Me.commune.Text
        Dim [date] As String = Me.dateMariage.Value.ToString("yyyy-MM-dd")
        Dim off As String = Me.officier.Text
        Dim ref As String = Me.reference.Text
        Dim mar As String = Me.temMariee.Text

        If ref = "" Or epoux = "" Or off = "" Or mar = "" Or pere = "" Or epouse = "" Or comm = "" Or ref = "" Then
            MessageBox.Show("Veuillez remplir tous les champs à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                'variable representant la base de donnée 
                Dim con_data As New OleDbConnection(Me.Provider)
                'ouverture de la connection et envoi des informations vers la base de données 
                con_data.Open()
                'MessageBox.Show("Success Connection...!")
                Dim requete As String = "UPDATE mariage SET epoux= '" & epoux & "', epouse='" & epouse & "', commune='" & comm & "', DateMariage='" & [date] & "', temMarier='" & pere & "', temMariee='" & mar & "', officier='" & off & "' WHERE reference='" & ref & "' "



                Dim command As New OleDbCommand(requete, con_data)
                If command.ExecuteNonQuery > 0 Then
                    MessageBox.Show("Modification éffectuée")
                Else
                    MessageBox.Show("Erreur lors de l'execution de la modification")
                End If
                con_data.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub supprimer_Click(sender As Object, e As EventArgs) Handles supprimer.Click
        Dim ref As String = Me.reference.Text
        Dim epoux As String = Me.epoux.Text
        Dim epouse As String = Me.epouse.Text
        Dim pere As String = Me.temMarier.Text
        Dim comm As String = Me.commune.Text
        Dim [date] As String = Me.dateMariage.Value.ToString("yyyy-MM-dd")
        Dim off As String = Me.officier.Text
        Dim mar As String = Me.temMariee.Text
        If ref = "" Or epoux = "" Or off = "" Or mar = "" Or pere = "" Or epouse = "" Or comm = "" Or ref = "" Then
            MessageBox.Show("Veuillez saisir le numéro de référence à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                'variable representant la base de donnée 
                Dim con_data As New OleDbConnection(Me.Provider)
                'ouverture de la connection et envoi des informations vers la base de données 
                con_data.Open()
                'MessageBox.Show("Success Connection...!")
                Dim requete As String = "Delete from mariage  WHERE reference='" & ref & "' "
                Dim command As New OleDbCommand(requete, con_data)
                If command.ExecuteNonQuery > 0 Then
                    MessageBox.Show("La suppression éffectué")

                Else
                    MessageBox.Show("Erreur lors de l'execution de la suppression")
                End If
                con_data.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub quitter_Click(sender As Object, e As EventArgs) Handles quitter.Click
        Me.Close()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim epoux As String = Me.epoux.Text
        Dim epouse As String = Me.epouse.Text
        Dim pere As String = Me.temMarier.Text
        Dim comm As String = Me.commune.Text
        Dim [date] As String = Me.dateMariage.Value.ToString("yyyy-MM-dd")
        Dim off As String = Me.officier.Text
        Dim ref As String = Me.reference.Text
        Dim mar As String = Me.temMariee.Text

        If epoux = "" Or off = "" Or mar = "" Or pere = "" Or epouse = "" Or comm = "" Or ref = "" Then
            MessageBox.Show("Veuillez remplir tous les champs de saisie!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Try

                'variable representant la base de donnée 
                Dim con_data As New OleDbConnection(Me.Provider)

                'ouverture de la connection et envoi des informations vers la base de données 
                con_data.Open()
                'MessageBox.Show("Success Connection...!")
                Dim requete As String = "INSERT INTO mariage(reference, epoux, epouse, commune, DateMariage, temMarier, temMariee, officier) values('" & ref & "','" & epoux & "','" & epouse & "','" & comm & "','" & [date] & "','" & pere & "','" & mar & "','" & off & "')"
                Dim command As New OleDbCommand(requete, con_data)
                If command.ExecuteNonQuery > 0 Then
                    MessageBox.Show("Les données ont été ajouté avec succès dans la base de donnée!!")
                Else
                    MessageBox.Show("Base de donnée non trouvée ! Erreur de connection!")
                End If
                con_data.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
End Class
