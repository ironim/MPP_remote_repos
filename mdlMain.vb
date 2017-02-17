
Imports System
Imports System.Globalization
Imports System.Text.RegularExpressions

Module mdlMain
    '管理者ログインフラグ
    'f=一般ユーザ　t=管理者
    Public UserIsAdmin As Boolean = False


    Function AD_to_Wareki(ByVal impoDate As Date) As String
        Dim culture As CultureInfo = New CultureInfo("ja-JP", True)
        culture.DateTimeFormat.Calendar = New JapaneseCalendar()

        Dim target As DateTime = impoDate
        Dim result As String = target.ToString("ggyy年M月d日", culture)
        'Console.WriteLine(result)
        ' 出力：平成15年7月1日
        Return result
    End Function

    Function Wareki_to_AD(ByVal impoDate As String) As DateTime
        Dim culture As CultureInfo = New CultureInfo("ja-JP", True)
        culture.DateTimeFormat.Calendar = New JapaneseCalendar()

        Dim target As String = impoDate
        Dim result As DateTime = DateTime.ParseExact(target, "ggyy年M月d日", culture)
        'Console.WriteLine(result.ToLongDateString())
        ' 出力：2003年7月1日

        Return result
    End Function

    '日付チェック-年
    Function CheckTxtYear(ByVal value As String)
        '0を除く、1桁または2桁の整数
        If Regex.IsMatch(value, "^[0]$") Then
            Return False
        ElseIf Regex.IsMatch(value, "^[0-9]{1,2}$") Then
            Return True
        Else
            Return False
        End If

    End Function

    '日付チェック-月
    Function CheckTxtMonth(ByVal value As String)
        '1から12まで
        If Regex.IsMatch(value, "^[1-9]$|^[1][0-2]$") Then
            Return True
        Else
            Return False
        End If

    End Function

    '日付チェック-日
    Function CheckTxtDate(ByVal value As String)
        '1から31まで
        If Regex.IsMatch(value, "^[1-9]$|^[1][0-9]$|^[2][0-9]$|^[3][0-1]$") Then
            Return True
        Else
            Return False
        End If

    End Function



End Module

