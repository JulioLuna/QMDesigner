Public Class CodeEditorForm

    ' Executes the editor.
    Public Shared Function GetString(ByVal value As String) As String
        Dim instance As New CodeEditorForm()
        instance.TextBox1.Text = value
        If instance.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return instance.TextBox1.Text
        Else
            Return value
        End If
    End Function

End Class