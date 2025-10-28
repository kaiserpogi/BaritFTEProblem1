Public Class Form1


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim Title As New List(Of String)
        Title.Add(txtTitle.Text)

        Dim Name As New List(Of String)
        Name.Add(txtName.Text)

        Dim Price As New List(Of Decimal)
        Price.Add(Convert.ToDecimal(txtPrice.Text))

        dgv.Rows.Add(txtTitle.Text, txtName.Text, cmbCategory.Text, txtPrice.Text)
        dgv.AutoResizeRows()

    End Sub

    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click


    End Sub
End Class
