﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.42000
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings 自動保存機能"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.2.194\SQLEXPRESS;Initial Catalog=PhoneNumDB;Persist Security "& _ 
            "Info=True;User ID=sa;Password=mstech2016")>  _
        Public ReadOnly Property PhoneNumDBConnectionString() As String
            Get
                Return CType(Me("PhoneNumDBConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("6")>  _
        Public Property grdMain_phonenum_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_phonenum_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_phonenum_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("7")>  _
        Public Property grdMain_branch_name_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_branch_name_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_branch_name_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property grdMain_staff_name_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_staff_name_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_staff_name_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property grdMain_carnum1_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_carnum1_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_carnum1_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property grdMain_musen_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_musen_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_musen_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4")>  _
        Public Property grdMain_ton_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_ton_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_ton_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property grdMain_car_branch_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_car_branch_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_car_branch_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("8")>  _
        Public Property grdMain_max_load_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_max_load_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_max_load_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("9")>  _
        Public Property grdMain_limit_menkyo_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_limit_menkyo_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_limit_menkyo_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property grdMain_limit_syaken_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_limit_syaken_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_limit_syaken_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("12")>  _
        Public Property frmMain_Top() As Integer
            Get
                Return CType(Me("frmMain_Top"),Integer)
            End Get
            Set
                Me("frmMain_Top") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("593")>  _
        Public Property frmMain_Left() As Integer
            Get
                Return CType(Me("frmMain_Left"),Integer)
            End Get
            Set
                Me("frmMain_Left") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1138")>  _
        Public Property frmMain_Width() As Integer
            Get
                Return CType(Me("frmMain_Width"),Integer)
            End Get
            Set
                Me("frmMain_Width") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("655")>  _
        Public Property frmMain_Height() As Integer
            Get
                Return CType(Me("frmMain_Height"),Integer)
            End Get
            Set
                Me("frmMain_Height") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("11")>  _
        Public Property grdMain_car_length_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_car_length_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_car_length_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("12")>  _
        Public Property grdMain_car_width_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_car_width_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_car_width_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("13")>  _
        Public Property grdMain_car_height_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_car_height_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_car_height_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("14")>  _
        Public Property grdMain_bed_length_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_bed_length_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_bed_length_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("15")>  _
        Public Property grdMain_bed_width_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_bed_width_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_bed_width_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("16")>  _
        Public Property grdMain_bed_height_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_bed_height_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_bed_height_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("17")>  _
        Public Property grdMain_maker_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_maker_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_maker_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("18")>  _
        Public Property grdMain_car_type_DisplayIndex() As Integer
            Get
                Return CType(Me("grdMain_car_type_DisplayIndex"),Integer)
            End Get
            Set
                Me("grdMain_car_type_DisplayIndex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\\192.168.8.190\minorsys\MPP\menkyo")>  _
        Public Property FileServerPath_Menkyo() As String
            Get
                Return CType(Me("FileServerPath_Menkyo"),String)
            End Get
            Set
                Me("FileServerPath_Menkyo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\\192.168.8.190\minorsys\MPP\syaken")>  _
        Public Property FIleServerPath_Syaken() As String
            Get
                Return CType(Me("FIleServerPath_Syaken"),String)
            End Get
            Set
                Me("FIleServerPath_Syaken") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\\192.168.8.190\minorsys\MPP\jibai")>  _
        Public Property FileServerPath_Jibai() As String
            Get
                Return CType(Me("FileServerPath_Jibai"),String)
            End Get
            Set
                Me("FileServerPath_Jibai") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\\192.168.8.190\minorsys\MPP\crane")>  _
        Public Property FileSeverPath_Crane() As String
            Get
                Return CType(Me("FileSeverPath_Crane"),String)
            End Get
            Set
                Me("FileSeverPath_Crane") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\\192.168.8.190\minorsys\MPP\other")>  _
        Public Property FileServerPath_Other() As String
            Get
                Return CType(Me("FileServerPath_Other"),String)
            End Get
            Set
                Me("FileServerPath_Other") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.MPP.My.MySettings
            Get
                Return Global.MPP.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
