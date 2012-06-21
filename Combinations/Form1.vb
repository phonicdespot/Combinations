Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim intNums() As Integer = New Integer() {0, 0, 0, 0, 0, 0}

        ap(intNums)

        For x = 1 To 4
            intNums(0) = 0
            intNums(1) = 0
            intNums(2) = 0
            intNums(3) = 0
            intNums(4) = 0
            intNums(5) = x

            Do Until intNums(0) = x
                For i = 0 To 5
                    Dim r As Integer
                    Dim l As Integer

                    If i = 5 Then
                        r = 5
                    Else
                        r = i + 1
                    End If

                    If i = 0 Then
                        l = 0
                    Else
                        l = i - 1
                    End If
                    'Debug.Print(i & " input:")
                    'ap(intNums)
                    'Debug.Print("i:" & intNums(i) & " l:" & intNums(l) & " r:" & intNums(r))
                    If intNums(i) < intNums(r) And intNums(l) = intNums(i) Then
                        intNums(i) = intNums(i) + 1
                        'Debug.Print("boom")
                        If intNums(i) > 1 Then
                            For m = 0 To (i - 1)
                                intNums(m) = 0
                            Next
                        End If
                        Exit For
                    End If
                    'Debug.Print(i & " result:")
                    'ap(intNums)
                Next

            Loop
        Next
    End Sub


    Private Sub ap(ByVal intNums As Integer())
        Dim strPrint As String
        Dim strOut As String

        strOut = ""

        For i = 0 To 5
            strPrint = intNums(i)
            strOut = strOut & strPrint
        Next

        Debug.Print(strOut)
    End Sub

End Class