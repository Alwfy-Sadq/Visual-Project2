Public Class Form1
    Dim x, y, w, k As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'حول المشروع
        w = Chr(13) + Chr(10)
        x = " جامعة شبوة " + w
        x = x + " مركز التدريب وخدمة المجتمع " + w
        x = x + " بكالوريوس الحاسب الآلي " + w
        x = x + " إعداد الأستاذ حذيفة عبدالرحمن " + w
        x = x + " العام الدراسي 1447 "
        y = " حول المشروع "
        MsgBox(x, MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, y)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' خروج
        x = " هل تريد الخروج من المشروع؟ "
        y = " تحذير "
        k = MsgBox(x, MsgBoxStyle.YesNo + MsgBoxStyle.Critical +
        MsgBoxStyle.MsgBoxRight, y)
        If k = 6 Then End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' الألوان إدخال صندوق
        i = InputBox(("15 الرجا إدخال عدد بين الصفر و صندوق الإدخال "))
        'الإجراء من الخروج
        If i >= 0 And i <= 15 Then
            Me.BackColor = System.Drawing.ColorTranslator.FromOle(QBColor(Val(i)))
        Else
            MsgBox(" الادخال خاطئ ", , "تنبيه ")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'الألوان العشوائية
        Randomize()
        Me.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(Rnd() *
        255, Rnd() * 255, Rnd() * 255))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' الكتابة على عدة اسطر
        w = Chr(13) + Chr(10)
        TextBox1.Text = " الرحمن الرحيم " + w + " بسم الله "
        Label1.Text = " بسم الله  " + w + " الرحمن الرحيم "
    End Sub

    Dim i As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
