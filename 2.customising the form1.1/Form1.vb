Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Me.Text = "My first App in 2023"
		Me.BackColor = Color.Red
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Size = New Size(800, 400)
		Me.Opacity = 0.3  'makes it a bit transport
		Me.CenterToParent() 'centers the execution box

	End Sub

	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Close()
	End Sub



	Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click


		MsgBox("This is Dineo",, "Greeting") ' this is to make the lil box have Hello instead of default words


	End Sub
End Class


