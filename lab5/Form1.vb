﻿Option Strict On
Imports System.IO

Public Class textEditorForm
    Private Sub textEditorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Application.Exit()

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        'use the OpenFileDialog to allow the user to select the file'

        'use FileStream object instantiated using full path, FileMode.Open and FileAccess.Read in constructor'



        Dim openDialog As New OpenFileDialog
        Dim file As String
        openDialog.ShowDialog()
        file = openDialog.FileName
        ' instantiate a StreamReader using instantiated fileStream object in its constructor to designate file reading from'
        Dim streamRead As New IO.StreamReader(file)
        'new StreamReader object should use ReadToEnd() to load data from file to text editor text box
        tbTextInput.Text = streamRead.ReadToEnd()
        'StreamReader closed (.Closed) to release resource
        streamRead.Close()


    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        ' In a file path not know say file dialogue used to allow user to browse and select the path were file will be saved
        ' path is known no need to display save file dialogue
        ' single save method/some to be reused from different parts of the form
        '   method should take one parameter
        '   full file path
        '   file stream object instantiated using full file path, file mode.create and file access.right
        '   file stream object should use instantiated right stream object, in right stream constructor, to designate the file it will be saving to
        '   the method should use the right stream object to get the text from the text editor text box to write And the close




        'want to say if file exists overwrite not sure how


        Dim saveDialog As New SaveFileDialog
            Dim saveFile As String
            Dim streamWrite As New IO.StreamWriter(saveFile)
            streamWrite.Write(tbTextInput.Text)
            streamWrite.Close()



    End Sub

    Private Function saveFile() As Stream
        Throw New NotImplementedException()
    End Function

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        ' Similar to safe, always display save file dialog
        ' method created for save can be reused. 

        Dim saveDialog As New SaveFileDialog
        Dim saveFile As String
        Dim streamWrite As New IO.StreamWriter(saveFile)
        streamWrite.Write(tbTextInput.Text)
        streamWrite.Close()

    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        ' Remove selected text
        ' put selected text into my.computer.clipboard.set text( text selected)
        My.Computer.Clipboard.SetText(tbTextInput.SelectedText)
        tbTextInput.SelectedText = ""

    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        ' put selected text into my.computer.clipboard.set text( text selected)
        My.Computer.Clipboard.SetText(tbTextInput.SelectedText)
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        ' Inserts text  my.computer.clipboard.Gettext( )Into spot user selected

        tbTextInput.SelectedText = My.Computer.Clipboard.GetText()

    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click

        MessageBox.Show("NETD-2202" & vbCrLf & "Lab #5" & vbCrLf & "J. Lopez", "About", MessageBoxButtons.OK)

    End Sub

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        'Should clear screen for variables to default. Example the file path, no filename, etc.

    End Sub
End Class
