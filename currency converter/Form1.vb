Public Class Form1
    'items declared in combo box 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        from_Currency.Items.Add("USD")
        from_Currency.Items.Add("EUR")
        from_Currency.Items.Add("GBP")
        from_Currency.Items.Add("AED")

        to_Currency.Items.Add("USD")
        to_Currency.Items.Add("EUR")
        to_Currency.Items.Add("GBP")
        to_Currency.Items.Add("AED")
    End Sub
    ' the conversion is calculated and output 
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim conversionRate As Double = Convert.ToDouble(Conversion.Text)

        Dim totalAmount As Double = Convert.ToDouble(amount.Text)

        Dim convertTotal As Double = conversionRate * totalAmount

        showResult.Text = " From " & from_Currency.Text & " at " & conversionRate & " to " & to_Currency.Text & " Total is " & convertTotal
    End Sub
    'checks if the from and to currencies are the SAME
    Private Sub From_currency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles from_Currency.SelectedIndexChanged
        If from_Currency.SelectedItem IsNot Nothing AndAlso to_Currency.SelectedItem IsNot Nothing Then
            If from_Currency.SelectedItem.ToString().Equals(to_Currency.SelectedItem.ToString()) Then
                MessageBox.Show("You cannot select the same item as in ComboBox 1 ")
                from_Currency.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub to_Currency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles to_Currency.SelectedIndexChanged
        If to_Currency.SelectedItem IsNot Nothing AndAlso to_Currency.SelectedItem IsNot Nothing Then
            If from_Currency.SelectedItem.ToString().Equals(to_Currency.SelectedItem.ToString()) Then
                MessageBox.Show("You cannot select the same item as in ComboBox 2 ")
                from_Currency.SelectedIndex = -1
            End If
        End If
    End Sub
    ' shows the help page 
    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        Dim help As New help()
        help.Show()
    End Sub

End Class