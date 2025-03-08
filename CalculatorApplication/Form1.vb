Public Class Form1
    Private currentInput As String = ""
    Private firstNumber As Double = 0
    Private secondNumber As Double = 0
    Private operation As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Dim button As Button = CType(sender, Button)
        currentInput &= button.Text
        TextBoxDisplay.Text = currentInput
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        SetOperation("+")
    End Sub

    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        SetOperation("-")
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        SetOperation("*")
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        SetOperation("/")
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        currentInput = ""
        firstNumber = 0
        secondNumber = 0
        operation = ""
        TextBoxDisplay.Text = ""
    End Sub

    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        If Double.TryParse(currentInput, secondNumber) Then
            Select Case operation
                Case "+"
                    TextBoxDisplay.Text = (firstNumber + secondNumber).ToString()
                Case "-"
                    TextBoxDisplay.Text = (firstNumber - secondNumber).ToString()
                Case "*"
                    TextBoxDisplay.Text = (firstNumber * secondNumber).ToString()
                Case "/"
                    If secondNumber <> 0 Then
                        TextBoxDisplay.Text = (firstNumber / secondNumber).ToString()
                    Else
                        MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select
            currentInput = TextBoxDisplay.Text
        End If
    End Sub

    Private Sub SetOperation(op As String)
        If Double.TryParse(currentInput, firstNumber) Then
            operation = op
            currentInput = ""
        End If
    End Sub
End Class
