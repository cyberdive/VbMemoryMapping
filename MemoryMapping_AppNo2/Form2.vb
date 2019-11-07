Imports System
Imports System.IO
Imports System.IO.MemoryMappedFiles

''' <summary>
''' Example of Sharing memory across different running applications (Application No2)
''' Demo Form2
''' </summary>
''' <remarks>
''' By David Rathbone
''' Many Thanks to Microsoft
'''</remarks>
Public Class Form2

    ''' <summary>
    ''' Write Memory
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MakeMemoryMappedFile()

        Dim File = MemoryMappedFile.CreateOrOpen("MemoryFile", 26)
        Dim bytes = New Byte(25) {}
        For i As Integer = 0 To bytes.Length - 1
            'Make some data different here so that you can see it e.g. this form adds 10
            bytes(i) = i + 10
        Next

        Using writer = File.CreateViewAccessor(0, bytes.Length)
            writer.WriteArray(Of Byte)(0, bytes, 0, bytes.Length)
        End Using


    End Sub

    ''' <summary>
    ''' Read Memory
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadMemoryMappedFile()

        Try
            Using file = MemoryMappedFile.OpenExisting("MemoryFile")
                Using reader = file.CreateViewAccessor(0, 26)
                    Dim bytes = New Byte(25) {}
                    reader.ReadArray(Of Byte)(0, bytes, 0, bytes.Length)

                    TextBox1.Text = ""
                    For i As Integer = 0 To bytes.Length - 1
                        TextBox1.AppendText(CStr(bytes(i)) + " ")
                    Next


                End Using
            End Using
        Catch noFile As FileNotFoundException

            TextBox1.Text = "Memory-mapped file does not exist."
        Catch Ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' Button Make File Click Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Btn_Make_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Make.Click
        MakeMemoryMappedFile()
    End Sub

    ''' <summary>
    ''' Button Read File Click Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Btn_Read_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Read.Click
        ReadMemoryMappedFile()
    End Sub
End Class


