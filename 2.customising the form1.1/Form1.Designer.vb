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
		btnClose = New Button()
		Btn = New Button()
		SuspendLayout()
		' 
		' btnClose
		' 
		btnClose.Location = New Point(372, 322)
		btnClose.Name = "btnClose"
		btnClose.Size = New Size(112, 34)
		btnClose.TabIndex = 0
		btnClose.Text = "Close"
		btnClose.UseVisualStyleBackColor = True
		' 
		' Btn
		' 
		Btn.Location = New Point(208, 177)
		Btn.Name = "Btn"
		Btn.Size = New Size(359, 81)
		Btn.TabIndex = 2
		Btn.Text = "This is Dineo"
		Btn.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(Btn)
		Controls.Add(btnClose)
		Name = "Form1"
		Text = "Close"
		ResumeLayout(False)
	End Sub

	Friend WithEvents btnClose As Button
	Friend WithEvents Btn As Button
End Class
