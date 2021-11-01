Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'declare variables
        Dim str1 As String = TextBox1.Text
        Dim str2 As String = TextBox2.Text

        'convert string to char array
        Dim str1_array As Char() = str1.ToCharArray()
        Dim str2_array As Char() = str2.ToCharArray()

        'sort char array alphabetically
        Array.Sort(str1_array)
        Array.Sort(str2_array)

        'make char array to string to compare
        Dim new_word1 As New String(str1_array)
        Dim new_word2 As New String(str2_array)


        If new_word1 = new_word2 Then
            MsgBox(str1 & " and " & str2 & " are anagram.")
        Else
            MsgBox(str1 & " and " & str2 & " are not anagram.")
        End If

    End Sub


End Class
