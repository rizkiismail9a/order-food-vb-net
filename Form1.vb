Public Class Form1
    Dim foodBill As Integer = 0
    Dim drinkBill As Integer = 0
    Dim foodPortion As Integer
    Dim drinkPortion As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add placeholder
        foodInput.Text = "Nasi Uduk"
        foodPrice.Text = "Rp 10000,00"
        inputDrink.Text = "Es Teh Manis"
        drinkPrice.Text = "Rp 5000,00"
        totalPrice.Text = "Rp 10000,00"
        foodAmount.Text = 1
        drinkAmount.Text = 0

        foodPortion = Integer.Parse(foodAmount.Text)
        drinkPortion = Integer.Parse(drinkAmount.Text)
    End Sub

    Private Sub addDrink_CheckedChanged(sender As Object, e As EventArgs) Handles addDrink.CheckedChanged
        inputDrink.Enabled = addDrink.Checked
        drinkAmount.Enabled = addDrink.Checked

        ' If the addDrink is unchecked, remove the counting of total amount
        If addDrink.Checked = False Then
            drinkAmount.Text = 0
            drinkPortion = 0
            totalPrice.Text = "Rp " & (foodBill * foodPortion) + (drinkBill * drinkPortion) & ",00"
        Else
            drinkAmount.Text = 1
            drinkPortion = 1
            totalPrice.Text = "Rp " & (foodBill * foodPortion) + (drinkBill * drinkPortion) & ",00"
        End If
    End Sub

    Private Sub foodInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles foodInput.SelectedIndexChanged
        Select Case foodInput.Text
            Case "Nasi Uduk"
                foodPrice.Text = "Rp 10000,00"
                foodBill = 10000
            Case "Ayam Goreng"
                foodPrice.Text = "Rp 12000,00"
                foodBill = 12000
            Case "Lotek"
                foodPrice.Text = "Rp 8000,00"
                foodBill = 8000
        End Select

        ' Calculate the total price

        ' Coba konversi input menjadi Integer
        totalPrice.Text = "Rp " & (foodBill * foodPortion) + (drinkBill * drinkPortion) & ",00"

    End Sub

    Private Sub foodAmount_TextChanged(sender As Object, e As EventArgs) Handles foodAmount.TextChanged
        If Integer.TryParse(foodAmount.Text, foodPortion) Then
            errorFoodAmountLabel.Visible = False
        Else
            errorFoodAmountLabel.Visible = True
            Exit Sub
        End If

        foodPortion = Integer.Parse(foodAmount.Text)
        totalPrice.Text = "Rp " & (foodBill * foodPortion) + (drinkBill * drinkPortion) & ",00"
    End Sub

    Private Sub inputDrink_SelectedIndexChanged(sender As Object, e As EventArgs) Handles inputDrink.SelectedIndexChanged
        Select Case inputDrink.Text
            Case "Es Teh Manis"
                drinkPrice.Text = "Rp 5000,00"
                drinkBill = 5000
            Case "Jus Jerk"
                drinkPrice.Text = "Rp 8000,00"
                foodBill = 8000
            Case "Kopi Hitam"
                drinkPrice.Text = "Rp 8000,00"
                drinkBill = 8000
        End Select


        totalPrice.Text = "Rp " & (foodBill * foodPortion) + (drinkBill * drinkPortion) & ",00"
    End Sub

    Private Sub drinkAmount_TextChanged(sender As Object, e As EventArgs) Handles drinkAmount.TextChanged
        If Integer.TryParse(drinkAmount.Text, drinkPortion) Then
            errorDrinkPortion.Visible = False
        Else
            errorDrinkPortion.Visible = True
            Exit Sub
        End If

        drinkPortion = Integer.Parse(drinkAmount.Text)
        totalPrice.Text = "Rp " & (foodBill * foodPortion) + (drinkBill * drinkPortion) & ",00"
    End Sub
End Class
