Public Class Form1
    Dim Title As New List(Of String)
    Dim artistName As New List(Of String)
    Dim Price As New List(Of Decimal)

    Dim painting As Integer
    Dim sculpture As Integer
    Dim digitalArt As Integer
    Dim photography As Integer
    Dim crafts As Integer

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtTitle.Text = "" Then
            MessageBox.Show("Please enter a valid title.")
            Return

            If txtName.Text = "" Then
                MessageBox.Show("Please input your name.")
                Return

                If txtPrice.Text = "" Then
                    MessageBox.Show("Please enter a valid price.")
                End If
            End If
        End If
        Title.Add(txtTitle.Text)
        artistName.Add(txtName.Text)
        Price.Add(Convert.ToDecimal(txtPrice.Text))

        dgv.Rows.Add(txtTitle.Text, txtName.Text, cmbCategory.Text, txtPrice.Text)
        dgv.AutoResizeRows()

        If cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a valid category.")
            Return

        ElseIf cmbCategory.SelectedIndex = 0 Then
            painting += 1
        ElseIf cmbCategory.SelectedIndex = 1 Then
            sculpture += 1
        ElseIf cmbCategory.SelectedIndex = 2 Then
            digitalArt += 1
        ElseIf cmbCategory.SelectedIndex = 3 Then
            photography += 1
        ElseIf cmbCategory.SelectedIndex = 4 Then
            crafts += 1
        End If

    End Sub

    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        Dim sumofArtwork = Title.Count
        Dim totalPrice = Price.Sum()
        Dim avgPrice = Price.Average()
        Dim maxPrice = Price.Max()
        Dim minPrice = Price.Min()

        MessageBox.Show("Total Artworks: " & sumofArtwork & vbCrLf &
                        "Total Price: " & totalPrice.ToString & vbCrLf &
                        "Average Price: " & avgPrice.ToString("F2") & vbCrLf &
                        "Maximum Price: " & maxPrice & vbCrLf &
                        "Minimum Price: " & minPrice & vbCrLf)

    End Sub
End Class
