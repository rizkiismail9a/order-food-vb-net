<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        foodInput = New ComboBox()
        Label1 = New Label()
        foodPrice = New Label()
        drinkPrice = New Label()
        Label3 = New Label()
        inputDrink = New ComboBox()
        addDrink = New CheckBox()
        GroupBox1 = New GroupBox()
        errorDrinkPortion = New Label()
        errorFoodAmountLabel = New Label()
        totalPrice = New Label()
        Label7 = New Label()
        Label6 = New Label()
        drinkAmount = New TextBox()
        Label5 = New Label()
        foodAmount = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' foodInput
        ' 
        foodInput.DropDownStyle = ComboBoxStyle.DropDownList
        foodInput.FormattingEnabled = True
        foodInput.Items.AddRange(New Object() {"Nasi Uduk", "Ayam Goreng", "Lotek"})
        foodInput.Location = New Point(81, 66)
        foodInput.Name = "foodInput"
        foodInput.Size = New Size(242, 40)
        foodInput.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(430, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 32)
        Label1.TabIndex = 1
        Label1.Text = "Harga"
        ' 
        ' foodPrice
        ' 
        foodPrice.AutoSize = True
        foodPrice.Location = New Point(622, 74)
        foodPrice.Name = "foodPrice"
        foodPrice.Size = New Size(93, 32)
        foodPrice.TabIndex = 2
        foodPrice.Text = "Rp 0,00"
        ' 
        ' drinkPrice
        ' 
        drinkPrice.AutoSize = True
        drinkPrice.Location = New Point(622, 228)
        drinkPrice.Name = "drinkPrice"
        drinkPrice.Size = New Size(93, 32)
        drinkPrice.TabIndex = 5
        drinkPrice.Text = "Rp 0,00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(430, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 32)
        Label3.TabIndex = 4
        Label3.Text = "Harga"
        ' 
        ' inputDrink
        ' 
        inputDrink.DropDownStyle = ComboBoxStyle.DropDownList
        inputDrink.Enabled = False
        inputDrink.FormattingEnabled = True
        inputDrink.Items.AddRange(New Object() {"Es Teh Manis", "Jus Jeruk", "Kopi Hitam"})
        inputDrink.Location = New Point(81, 220)
        inputDrink.Name = "inputDrink"
        inputDrink.Size = New Size(242, 40)
        inputDrink.TabIndex = 3
        ' 
        ' addDrink
        ' 
        addDrink.AutoSize = True
        addDrink.Location = New Point(81, 142)
        addDrink.Name = "addDrink"
        addDrink.Size = New Size(239, 36)
        addDrink.TabIndex = 6
        addDrink.Text = "Tambah Minuman"
        addDrink.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(errorDrinkPortion)
        GroupBox1.Controls.Add(errorFoodAmountLabel)
        GroupBox1.Controls.Add(totalPrice)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(drinkAmount)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(foodAmount)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(32, 305)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(706, 284)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pesanan"
        ' 
        ' errorDrinkPortion
        ' 
        errorDrinkPortion.AutoSize = True
        errorDrinkPortion.Font = New Font("Segoe UI", 7F)
        errorDrinkPortion.ForeColor = Color.Red
        errorDrinkPortion.Location = New Point(292, 188)
        errorDrinkPortion.Name = "errorDrinkPortion"
        errorDrinkPortion.Size = New Size(223, 25)
        errorDrinkPortion.TabIndex = 9
        errorDrinkPortion.Text = "Masukan nilai angka saja"
        errorDrinkPortion.Visible = False
        ' 
        ' errorFoodAmountLabel
        ' 
        errorFoodAmountLabel.AutoSize = True
        errorFoodAmountLabel.Font = New Font("Segoe UI", 7F)
        errorFoodAmountLabel.ForeColor = Color.Red
        errorFoodAmountLabel.Location = New Point(292, 84)
        errorFoodAmountLabel.Name = "errorFoodAmountLabel"
        errorFoodAmountLabel.Size = New Size(223, 25)
        errorFoodAmountLabel.TabIndex = 8
        errorFoodAmountLabel.Text = "Masukan nilai angka saja"
        errorFoodAmountLabel.Visible = False
        ' 
        ' totalPrice
        ' 
        totalPrice.AutoSize = True
        totalPrice.Location = New Point(292, 232)
        totalPrice.Name = "totalPrice"
        totalPrice.Size = New Size(93, 32)
        totalPrice.TabIndex = 7
        totalPrice.Text = "Rp 0,00"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(49, 222)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 32)
        Label7.TabIndex = 6
        Label7.Text = "Total"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(593, 139)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 32)
        Label6.TabIndex = 5
        Label6.Text = "Porsi"
        ' 
        ' drinkAmount
        ' 
        drinkAmount.Enabled = False
        drinkAmount.Location = New Point(292, 132)
        drinkAmount.Name = "drinkAmount"
        drinkAmount.Size = New Size(295, 39)
        drinkAmount.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(593, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 32)
        Label5.TabIndex = 3
        Label5.Text = "Porsi"
        ' 
        ' foodAmount
        ' 
        foodAmount.Location = New Point(292, 42)
        foodAmount.Name = "foodAmount"
        foodAmount.Size = New Size(295, 39)
        foodAmount.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(200, 32)
        Label4.TabIndex = 1
        Label4.Text = "Jumlah Minuman"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 32)
        Label2.TabIndex = 0
        Label2.Text = "Jumlah Makanan"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(828, 624)
        Controls.Add(GroupBox1)
        Controls.Add(addDrink)
        Controls.Add(drinkPrice)
        Controls.Add(Label3)
        Controls.Add(inputDrink)
        Controls.Add(foodPrice)
        Controls.Add(Label1)
        Controls.Add(foodInput)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Order Makanan"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents foodInput As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents foodPrice As Label
    Friend WithEvents drinkPrice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents inputDrink As ComboBox
    Friend WithEvents addDrink As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents drinkAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents foodAmount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents totalPrice As Label
    Friend WithEvents errorFoodAmountLabel As Label
    Friend WithEvents errorDrinkPortion As Label

End Class
