Public Class Form1
    Dim Title As New List(Of String)
    Dim artistName As New List(Of String)
    Dim Price As New List(Of Decimal)


    Dim categoryCount(4) As Integer ' 0=Painting, 1=Sculpture, 2=DigitalArt, 3=Photography, 4=Crafts
    Dim categoryNames() As String = {"Painting", "Sculpture", "Digital Art", "Photography", "Crafts"}

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim inputs() As Control = {txtTitle, txtName, txtPrice}
        Dim messages() As String = {"Please enter a valid title.", "Please input your name.", "Please enter a valid price."}

        For i As Integer = 0 To inputs.Length - 1
            If CType(inputs(i), TextBox).Text = "" Then
                MessageBox.Show(messages(i))
                Return
            End If
        Next

        If cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a valid category.")
            Return
        End If


        Title.Add(txtTitle.Text)
        artistName.Add(txtName.Text)
        Price.Add(Convert.ToDecimal(txtPrice.Text))


        categoryCount(cmbCategory.SelectedIndex) += 1


        dgv.Rows.Add(txtTitle.Text, txtName.Text, cmbCategory.Text, txtPrice.Text)
        dgv.AutoResizeRows()


        ClearInputs()
    End Sub

    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        If Title.Count = 0 Then
            MessageBox.Show("No artworks to analyze.")
            Return
        End If

        Dim sumofArtwork = Title.Count
        Dim totalPrice = Price.Sum()
        Dim avgPrice = Price.Average()
        Dim maxPrice = Price.Max()
        Dim minPrice = Price.Min()


        Dim analysisMessage As String = $"Total Artworks: {sumofArtwork}" & "Php" & vbCrLf &
                                       $"Total Price: {totalPrice}" & "Php" & vbCrLf &
                                       $"Average Price: {avgPrice:F2}" & "Php" & vbCrLf &
                                       $"Maximum Price: {maxPrice}" & "Php" & vbCrLf &
                                       $"Minimum Price: {minPrice}" & "Php" & vbCrLf & vbCrLf &
                                       "Category Breakdown:" & vbCrLf

        For i As Integer = 0 To categoryCount.Length - 1
            analysisMessage &= $"{categoryNames(i)}: {categoryCount(i)}" & vbCrLf
        Next

        MessageBox.Show(analysisMessage)
    End Sub

    Private Sub ClearInputs()

        For Each txtBox As TextBox In {txtTitle, txtName, txtPrice}
            txtBox.Clear()
        Next
        cmbCategory.SelectedIndex = -1
        txtTitle.Focus()
    End Sub


    Private Sub DisplayCategoryStats()
        Dim statsMessage As String = "Artworks by Category:" & vbCrLf & vbCrLf

        For i As Integer = 0 To categoryCount.Length - 1
            statsMessage &= $"{categoryNames(i)}: {categoryCount(i)} artwork(s)" & vbCrLf
        Next

        MessageBox.Show(statsMessage)
    End Sub
End Class