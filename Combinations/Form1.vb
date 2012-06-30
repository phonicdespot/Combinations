

Public Class Combinations
    'Given wider scope for the benefit of ap(),
    'the array printing subroutine.
    Dim intCols As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Sets the number of columns. Zero indexed :P
        intCols = Me.Cols.Value - 1

        Dim intNums(intCols) As Integer

        For x = Me.Min.Value To Me.Max.Value
            'Resets all but the rightmost array value to 0
            For o = 0 To (intCols - 1)
                intNums(o) = 0
            Next
            'Increments the rightmost value by 1
            intNums(intCols) = x

            'Do loop iterates until leftmost value equals rightmost value
            'i.e. all rows involving x have been exhausted.
            Do Until intNums(0) = x
                'Outputs array before modification so that first row is
                'present (first row is initial input)
                ap(intNums)

                '  For loop "Scans" across a row of numbers, comparing the
                'current value, intNums(i), with those either side:
                'intNums(left) and intNums(right).
                '  Increasing any number breaks out of the loop to ensure
                'that all unique "rows" are output.
                For i = 0 To intCols
                    Dim right As Integer
                    Dim left As Integer

                    'If statements ensure that left and right counters
                    'do not become negative at the far ends of each row.
                    If i = intCols Then
                        right = intCols
                    Else
                        right = i + 1
                    End If

                    If i = 0 Then
                        left = 0
                    Else
                        left = i - 1
                    End If

                    'Increases current number by one if: right hand number is greater
                    If intNums(i) < intNums(right) And intNums(left) = intNums(i) Then
                        intNums(i) = intNums(i) + 1
                        'If the current number is increased to a value above 1, all
                        'numbers to the left are reset to 0
                        If intNums(i) > 1 Then
                            For m = 0 To (i - 1)
                                intNums(m) = 0
                            Next
                        End If
                        Exit For
                    End If
                Next
            Loop
            'Outputs array after final iteration of for loop to make
            'up for the result being output before processing (see above)
            ap(intNums)
        Next
    End Sub

    'ap(<Array>) prints an array to the immediate window.
    Private Sub ap(ByVal intNums As Integer())
        Dim strPrint As String
        strPrint = ""
        For i = 0 To intNums.Length - 1
            strPrint &= intNums(i) & " "
        Next
        Debug.Print(strPrint)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Dim intPattern(6) As Integer
        Dim intPattern() = New Integer() {0, 0, 0, 0, 0, 1}
        ap(intPattern)
        shift(intPattern)
        ap(intPattern)
    End Sub

    'Performs a left hand circular 'digit shift' (i.e. digit pattern wraps back round)
    Private Sub shift(ByRef intPattern() As Integer)
        Dim intPatternIn() As Integer
        intPatternIn = intPattern
        For i = 0 To intPattern.Length - 1
            intPattern(i) = intPatternIn((i + 1) Mod intPattern.Length)
        Next
    End Sub

End Class