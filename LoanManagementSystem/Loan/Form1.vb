Imports System.Security.Principal

Public Class Form1
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TXTALOAN.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TXTLRN2.TextChanged

    End Sub
    Dim code As Integer = 1
    Private Sub BTNCLEAR_Click(sender As Object, e As EventArgs) Handles BTNCLEAR.Click
        code += 1
        TXTLRN.Text = code.ToString("0000")
        TXTACCNUM.Text = " "
        TXTNAME.Text = " "
        TXTADD.Text = " "
        TXTALOAN.Text = " "
        TXTINRATE.Text = " "
        TXTYTPAY.Text = " "
        TXTLRN2.Text = code.ToString("0000")
        TXTACCNUM2.Text = " "
        TXTNAME2.Text = " "
        TXTADD2.Text = " "
        TXTALOAN2.Text = " "
        TXTINRATE2.Text = " "
        TXTYTPAY2.Text = " "
        TXTMONPAY.Text = "0.00"
        TOTALIN.Text = "0.00"
        TOTALANNUALPAYMENT.Text = "0.00"
        TOTALLOANPAYMENT.Text = "0.00"
    End Sub

    Private Sub BTNCOM_Click(sender As Object, e As EventArgs) Handles BTNCOM.Click
        Try
            Dim ACCNUM As Integer = TXTACCNUM.Text
            Dim NAME As String = TXTNAME.Text
            Dim ADD As String = TXTADD.Text
            Dim AMLOAN As Integer = TXTALOAN.Text
            Dim INT As Double = TXTINRATE.Text
            Dim YEARS As Integer = TXTYTPAY.Text
            TXTACCNUM2.Text = ACCNUM
            TXTNAME2.Text = NAME
            TXTADD2.Text = ADD
            TXTALOAN2.Text = AMLOAN
            TXTINRATE2.Text = +INT
            TXTYTPAY2.Text = YEARS
            Dim RATE = INT / 100
            Dim TIME = YEARS * 12
            Dim TOTIN = (AMLOAN * RATE) * YEARS
            Dim TOTLOAN = AMLOAN + TOTIN
            Dim TNP = TOTLOAN / YEARS
            Dim MP = TNP / 12

            TXTMONPAY.Text = Format(MP, "₱#,###.00")
            TOTALIN.Text = Format(TOTIN, "₱#,###.00")
            TOTALLOANPAYMENT.Text = Format(TNP, "₱#,###.00")
            TOTALLOANPAYMENT.Text = Format(TOTLOAN, "₱#,###.00")
        Catch ex As Exception
            MsgBox("Input a valid number!")
        End Try
    End Sub

    Private Sub TOTALIN_TextChanged(sender As Object, e As EventArgs) Handles TOTALIN.TextChanged

    End Sub
End Class
