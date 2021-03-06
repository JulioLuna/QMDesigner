﻿Imports BO
Public Class CtlInformation
    Public Sub PopulateInformation(ByVal Tag As BO.Information)
        'Valid if the data are empty or Null

        If (Tag.Name = Nothing) Then
            Me.TxtName.Text = String.Empty
        Else
            Me.TxtName.Text = Tag.Name.ToString()
        End If

        If (Tag.MainText = Nothing) Then
            Me.TxtMainText.Text = String.Empty
        Else
            Me.TxtMainText.Text = Tag.MainText.ToString()
        End If

        If (Tag.Comment = Nothing) Then
            Me.TxtComment.Text = String.Empty
        Else
            Me.TxtComment.Text = Tag.Comment.ToString()
        End If

        If (Tag.OnLoad = Nothing) Then
            Me.TxtOnLoad.Text = String.Empty
        Else
            Me.TxtOnLoad.Text = Tag.OnLoad.ToString()
        End If

        If (Tag.OnUnload = Nothing) Then
            Me.TxtOnUnload.Text = String.Empty
        Else
            Me.TxtOnUnload.Text = Tag.OnUnload.ToString()
        End If


        If (Tag.QuestionnaireID = Nothing) Then
            Me.LblQuesID.Text = 0
        Else
            Me.LblQuesID.Text = Tag.QuestionnaireID.ToString()
        End If

        If (Tag.QuestionnaireSetID = Nothing) Then
            Me.LblQuesSetID.Text = 0
        Else
            Me.LblQuesSetID.Text = Tag.QuestionnaireSetID.ToString()
        End If

        If (Tag.SectionID = Nothing) Then
            Me.LblSectionID.Text = 0
        Else
            Me.LblSectionID.Text = Tag.SectionID.ToString()
        End If

        If (Tag.Guid = Nothing) Then
            Me.LblUniqueID.Text = 0
        Else
            Me.LblUniqueID.Text = Tag.Guid.ToString()
        End If

        Me.CmbHideBack.Text = Tag.HideBack.ToString()
        Me.CmbHideNext.Text = Tag.HideNext.ToString()
        Me.CmbVisible.Text = Tag.Visible.ToString()

    End Sub

    Private Sub BtnName_Click(sender As System.Object, e As System.EventArgs) Handles BtnName.Click
        TxtName.Text = CodeEditorForm.GetString(TxtName.Text)
    End Sub

    Private Sub BtnMainText_Click(sender As System.Object, e As System.EventArgs) Handles BtnMainText.Click
        TxtMainText.Text = CodeEditorForm.GetString(TxtMainText.Text)
    End Sub

    Private Sub BtnComment_Click(sender As System.Object, e As System.EventArgs) Handles BtnComment.Click
        TxtComment.Text = CodeEditorForm.GetString(TxtComment.Text)
    End Sub

    Private Sub BtnOnLoad_Click(sender As System.Object, e As System.EventArgs) Handles BtnOnLoad.Click
        TxtOnLoad.Text = CodeEditorForm.GetString(TxtOnLoad.Text)
    End Sub

    Private Sub BtnOnUnload_Click(sender As System.Object, e As System.EventArgs) Handles BtnOnUnload.Click
        TxtOnUnload.Text = CodeEditorForm.GetString(TxtOnUnload.Text)
    End Sub
End Class
