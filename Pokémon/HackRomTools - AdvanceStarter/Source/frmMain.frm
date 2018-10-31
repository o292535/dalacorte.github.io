VERSION 5.00
Begin VB.Form frmMain 
   AutoRedraw      =   -1  'True
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Advance Starter"
   ClientHeight    =   8505
   ClientLeft      =   150
   ClientTop       =   540
   ClientWidth     =   8655
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   Picture         =   "frmMain.frx":000C
   ScaleHeight     =   8505
   ScaleWidth      =   8655
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame3 
      Caption         =   "Rival's Starter Pokémon"
      Height          =   2620
      Left            =   120
      TabIndex        =   35
      Tag             =   "1014"
      Top             =   5160
      Width           =   8415
      Begin VB.PictureBox Picture2 
         Appearance      =   0  'Flat
         BorderStyle     =   0  'None
         ForeColor       =   &H80000008&
         Height          =   2295
         Left            =   120
         ScaleHeight     =   2295
         ScaleWidth      =   8175
         TabIndex        =   36
         Top             =   240
         Width           =   8175
         Begin VB.OptionButton optMale 
            Caption         =   "Male (Brendan)"
            Enabled         =   0   'False
            Height          =   255
            Left            =   4320
            TabIndex        =   6
            Tag             =   "1015"
            Top             =   40
            Width           =   1935
         End
         Begin VB.OptionButton optFemale 
            Caption         =   "Female (May)"
            Enabled         =   0   'False
            Height          =   255
            Left            =   6360
            TabIndex        =   7
            Tag             =   "1016"
            Top             =   40
            Value           =   -1  'True
            Width           =   1695
         End
         Begin VB.Frame fraRival1 
            Caption         =   "1st Pokémon"
            Height          =   1740
            Left            =   0
            TabIndex        =   39
            Tag             =   "1032"
            Top             =   480
            Width           =   2655
            Begin VB.TextBox txtRivalLevel 
               Enabled         =   0   'False
               Height          =   285
               Index           =   0
               Left            =   840
               MaxLength       =   3
               TabIndex        =   9
               Text            =   "0"
               Top             =   840
               Width           =   495
            End
            Begin VB.ComboBox cboRivalItem 
               Enabled         =   0   'False
               Height          =   315
               Index           =   0
               ItemData        =   "frmMain.frx":AAAB
               Left            =   840
               List            =   "frmMain.frx":AF14
               TabIndex        =   10
               Text            =   "--------"
               Top             =   1200
               Width           =   1575
            End
            Begin VB.ComboBox cboList 
               Enabled         =   0   'False
               Height          =   315
               Index           =   3
               ItemData        =   "frmMain.frx":BEBB
               Left            =   240
               List            =   "frmMain.frx":C390
               TabIndex        =   8
               Text            =   "No Pokémon"
               Top             =   360
               Width           =   2175
            End
            Begin VB.Label Label5 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Item"
               Enabled         =   0   'False
               Height          =   195
               Left            =   240
               TabIndex        =   41
               Tag             =   "1027"
               Top             =   1245
               Width           =   300
            End
            Begin VB.Label Label4 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Level"
               Enabled         =   0   'False
               Height          =   195
               Left            =   240
               TabIndex        =   40
               Tag             =   "1026"
               Top             =   885
               Width           =   390
            End
         End
         Begin VB.Frame fraRival2 
            Caption         =   "2nd Pokémon"
            Height          =   1740
            Left            =   2760
            TabIndex        =   38
            Tag             =   "1033"
            Top             =   480
            Width           =   2655
            Begin VB.ComboBox cboRivalItem 
               Enabled         =   0   'False
               Height          =   315
               Index           =   1
               ItemData        =   "frmMain.frx":D20D
               Left            =   840
               List            =   "frmMain.frx":D676
               TabIndex        =   13
               Text            =   "--------"
               Top             =   1200
               Width           =   1575
            End
            Begin VB.TextBox txtRivalLevel 
               Enabled         =   0   'False
               Height          =   285
               Index           =   1
               Left            =   840
               MaxLength       =   3
               TabIndex        =   12
               Text            =   "0"
               Top             =   840
               Width           =   495
            End
            Begin VB.ComboBox cboList 
               Enabled         =   0   'False
               Height          =   315
               Index           =   4
               ItemData        =   "frmMain.frx":E61D
               Left            =   240
               List            =   "frmMain.frx":EAF2
               TabIndex        =   11
               Text            =   "No Pokémon"
               Top             =   360
               Width           =   2175
            End
            Begin VB.Label Label8 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Level"
               Enabled         =   0   'False
               Height          =   195
               Left            =   240
               TabIndex        =   43
               Tag             =   "1026"
               Top             =   885
               Width           =   390
            End
            Begin VB.Label Label7 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Item"
               Enabled         =   0   'False
               Height          =   195
               Left            =   240
               TabIndex        =   42
               Tag             =   "1027"
               Top             =   1245
               Width           =   300
            End
         End
         Begin VB.Frame fraRival3 
            Caption         =   "3rd Pokémon"
            Height          =   1740
            Left            =   5520
            TabIndex        =   37
            Tag             =   "1034"
            Top             =   480
            Width           =   2655
            Begin VB.ComboBox cboRivalItem 
               Enabled         =   0   'False
               Height          =   315
               Index           =   2
               ItemData        =   "frmMain.frx":F96F
               Left            =   840
               List            =   "frmMain.frx":FDD8
               TabIndex        =   16
               Text            =   "--------"
               Top             =   1200
               Width           =   1575
            End
            Begin VB.TextBox txtRivalLevel 
               Enabled         =   0   'False
               Height          =   285
               Index           =   2
               Left            =   840
               MaxLength       =   3
               TabIndex        =   15
               Text            =   "0"
               Top             =   840
               Width           =   495
            End
            Begin VB.ComboBox cboList 
               Enabled         =   0   'False
               Height          =   315
               Index           =   5
               ItemData        =   "frmMain.frx":10D7F
               Left            =   240
               List            =   "frmMain.frx":11254
               TabIndex        =   14
               Text            =   "No Pokémon"
               Top             =   360
               Width           =   2175
            End
            Begin VB.Label Label10 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Level"
               Enabled         =   0   'False
               Height          =   195
               Left            =   240
               TabIndex        =   45
               Tag             =   "1026"
               Top             =   885
               Width           =   390
            End
            Begin VB.Label Label9 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Item"
               Enabled         =   0   'False
               Height          =   195
               Left            =   240
               TabIndex        =   44
               Tag             =   "1027"
               Top             =   1245
               Width           =   300
            End
         End
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Your Starter Pokémon"
      Height          =   2340
      Left            =   120
      TabIndex        =   27
      Tag             =   "1013"
      Top             =   2700
      Width           =   8415
      Begin VB.PictureBox Picture1 
         Appearance      =   0  'Flat
         BorderStyle     =   0  'None
         ForeColor       =   &H80000008&
         Height          =   1815
         Left            =   120
         ScaleHeight     =   1815
         ScaleWidth      =   8175
         TabIndex        =   28
         Top             =   360
         Width           =   8175
         Begin VB.CommandButton cmdDefault 
            Caption         =   "Default"
            Enabled         =   0   'False
            Height          =   375
            Left            =   6640
            TabIndex        =   5
            Tag             =   "1028"
            Top             =   1240
            Width           =   1335
         End
         Begin VB.Frame fraPokeball1 
            Caption         =   "1st Pokéball"
            Height          =   900
            Left            =   0
            TabIndex        =   34
            Tag             =   "1029"
            Top             =   0
            Width           =   2655
            Begin VB.ComboBox cboList 
               Enabled         =   0   'False
               Height          =   315
               Index           =   0
               ItemData        =   "frmMain.frx":120D1
               Left            =   240
               List            =   "frmMain.frx":125A6
               TabIndex        =   0
               Text            =   "No Pokémon"
               Top             =   360
               Width           =   2175
            End
         End
         Begin VB.Frame fraPokeball2 
            Caption         =   "2nd Pokéball"
            Height          =   900
            Left            =   2760
            TabIndex        =   33
            Tag             =   "1030"
            Top             =   0
            Width           =   2655
            Begin VB.ComboBox cboList 
               Enabled         =   0   'False
               Height          =   315
               Index           =   1
               ItemData        =   "frmMain.frx":13423
               Left            =   240
               List            =   "frmMain.frx":138F8
               TabIndex        =   1
               Text            =   "No Pokémon"
               Top             =   360
               Width           =   2175
            End
         End
         Begin VB.Frame fraPokeball3 
            Caption         =   "3rd Pokéball"
            Height          =   900
            Left            =   5520
            TabIndex        =   32
            Tag             =   "1031"
            Top             =   0
            Width           =   2655
            Begin VB.ComboBox cboList 
               Enabled         =   0   'False
               Height          =   315
               Index           =   2
               ItemData        =   "frmMain.frx":14775
               Left            =   240
               List            =   "frmMain.frx":14C4A
               TabIndex        =   2
               Text            =   "No Pokémon"
               Top             =   360
               Width           =   2175
            End
         End
         Begin VB.Frame Frame1 
            Caption         =   "Level/Item"
            Height          =   855
            Left            =   1680
            TabIndex        =   29
            Tag             =   "1025"
            Top             =   960
            Width           =   4695
            Begin VB.ComboBox cboHeldItem 
               Enabled         =   0   'False
               Height          =   315
               ItemData        =   "frmMain.frx":15AC7
               Left            =   2520
               List            =   "frmMain.frx":15F30
               TabIndex        =   4
               Text            =   "--------"
               Top             =   360
               Width           =   1695
            End
            Begin VB.TextBox txtStarterLevel 
               Enabled         =   0   'False
               Height          =   285
               Left            =   1080
               MaxLength       =   3
               TabIndex        =   3
               Text            =   "0"
               Top             =   360
               Width           =   495
            End
            Begin VB.Label Label3 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Item"
               Enabled         =   0   'False
               Height          =   195
               Left            =   1920
               TabIndex        =   31
               Tag             =   "1027"
               Top             =   405
               Width           =   300
            End
            Begin VB.Label Label2 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Level"
               Enabled         =   0   'False
               Height          =   195
               Left            =   480
               TabIndex        =   30
               Tag             =   "1026"
               Top             =   405
               Width           =   390
            End
         End
      End
   End
   Begin VB.Frame Frame4 
      Height          =   495
      Left            =   120
      TabIndex        =   25
      Top             =   7920
      Width           =   8415
      Begin VB.Label Label12 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Copyright © 2006-2007 HackMew"
         Enabled         =   0   'False
         Height          =   195
         Left            =   3000
         TabIndex        =   26
         Top             =   195
         Width           =   2445
      End
   End
   Begin VB.Frame fraROMInfo 
      Caption         =   "ROM Information"
      Height          =   855
      Left            =   120
      TabIndex        =   17
      Tag             =   "1009"
      Top             =   1680
      Width           =   8415
      Begin VB.Label lblROMLang 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "???"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   7080
         TabIndex        =   23
         Tag             =   "0"
         Top             =   360
         Width           =   315
      End
      Begin VB.Label Label21 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Code:"
         Height          =   195
         Left            =   3480
         TabIndex        =   20
         Tag             =   "1011"
         Top             =   360
         Width           =   420
      End
      Begin VB.Label lblROMCode 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "???"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   4200
         TabIndex        =   21
         Tag             =   "0"
         Top             =   360
         Width           =   315
      End
      Begin VB.Label Label6 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Language:"
         BeginProperty Font 
            Name            =   "Microsoft Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   5640
         TabIndex        =   22
         Tag             =   "1012"
         Top             =   360
         Width           =   765
      End
      Begin VB.Label lblROMName 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "???"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   960
         TabIndex        =   19
         Tag             =   "0"
         Top             =   360
         Width           =   330
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Name:"
         Height          =   195
         Left            =   240
         TabIndex        =   18
         Tag             =   "1010"
         Top             =   360
         Width           =   465
      End
   End
   Begin VB.Label Label20 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Height          =   195
      Left            =   105
      TabIndex        =   24
      Top             =   5400
      Width           =   45
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      HelpContextID   =   1000
      Begin VB.Menu mnuOpenROM 
         Caption         =   "Open ROM..."
         HelpContextID   =   1001
         Shortcut        =   ^O
      End
      Begin VB.Menu mnuReLoadROM 
         Caption         =   "Reload ROM"
         Enabled         =   0   'False
         HelpContextID   =   1002
         Shortcut        =   {F5}
      End
      Begin VB.Menu mnuSaveROM 
         Caption         =   "Save ROM"
         Enabled         =   0   'False
         HelpContextID   =   1003
         Shortcut        =   ^S
      End
      Begin VB.Menu h 
         Caption         =   "-"
      End
      Begin VB.Menu mnuExit 
         Caption         =   "Exit"
         HelpContextID   =   1004
         Shortcut        =   ^Q
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "&Help"
      HelpContextID   =   1005
      Begin VB.Menu mnuReadme 
         Caption         =   "Readme"
         HelpContextID   =   1006
         Shortcut        =   {F1}
      End
      Begin VB.Menu mnuInfo 
         Caption         =   "About"
         HelpContextID   =   1007
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam As String) As Long

Private Const CB_SELECTSTRING As Long = &H14D
Private Const vbComma As String = ","

Dim sResult As String, FileNum As Integer
Dim strOffset1 As String, strOffset2 As String, strOffset3 As String
Dim strROMPath As String, strROMVersion As String, strMode As String
Dim blnROMCode As Boolean, blnROMName As Boolean

Private Sub cboHeldItem_Click()
    If Len(strMode) = 3 Then
        If cboHeldItem.ListIndex > 347 Then cboHeldItem.ListIndex = 346
    End If
End Sub

Private Sub cboHeldItem_LostFocus()
    If LenB(cboHeldItem.Text) > 0 Then
        SendMessage cboHeldItem.hWnd, CB_SELECTSTRING, -1, cboHeldItem.Text & vbNullChar
    Else
        cboHeldItem.ListIndex = 0
    End If
End Sub

Private Sub cboList_LostFocus(Index As Integer)
    If LenB(cboList(Index).Text) > 0 Then
        SendMessage cboList(Index).hWnd, CB_SELECTSTRING, -1, cboList(Index).Text & vbNullChar
    Else
        cboList(Index).ListIndex = 0
    End If
End Sub

Private Sub cboRivalItem_Click(Index As Integer)
    If Len(strMode) = 3 Then
        If cboRivalItem(Index).ListIndex > 347 Then cboRivalItem(Index).ListIndex = 346
    End If
End Sub

Private Sub cboRivalItem_LostFocus(Index As Integer)
    If LenB(cboRivalItem(Index).Text) > 0 Then
        SendMessage cboRivalItem(Index).hWnd, CB_SELECTSTRING, -1, cboRivalItem(Index).Text & vbNullChar
    Else
        cboRivalItem(Index).ListIndex = 0
    End If
End Sub

Private Sub cboRivalItem_Scroll(Index As Integer)
    If Len(strMode) = 3 Then
        If cboRivalItem(Index).ListIndex > 347 Then cboRivalItem(Index).ListIndex = 346
    End If
End Sub

Private Sub cmdDefault_Click()
Dim i As Integer
    
    If Len(strMode) = 3 Then
        cboList(0).ListIndex = 276
        cboList(1).ListIndex = 279
        cboList(2).ListIndex = 282
        cboList(3).ListIndex = 279
        cboList(4).ListIndex = 282
        cboList(5).ListIndex = 276
    Else
        cboList(0).ListIndex = 1
        cboList(1).ListIndex = 7
        cboList(2).ListIndex = 4
        txtStarterLevel.Text = 5
        cboHeldItem.ListIndex = 0
        cboList(3).ListIndex = 4
        cboList(4).ListIndex = 1
        cboList(5).ListIndex = 7
    End If
    
    For i = txtRivalLevel.LBound To txtRivalLevel.UBound
        txtRivalLevel(i).Text = 5
        cboRivalItem(i).ListIndex = 0
    Next
    
End Sub

Private Sub Form_Load()
    SetIcon Me.hWnd, "AAA"
    LoadResStrings Me
End Sub

Private Sub mnuOpenROM_Click()
FileNum = FreeFile

Dim oOpenDialog As clsCommonDialog
Set oOpenDialog = New clsCommonDialog

sResult = oOpenDialog.ShowOpen(Me.hWnd, LoadResString(1100), , "GameBoy Advance ROMs (*.gba, *.agb, *.bin)|*.gba;*.agb;*.bin|", FILEMUSTEXIST Or PATHMUSTEXIST Or HIDEREADONLY)

mnuReLoadROM.Enabled = False
mnuSaveROM.Enabled = False

Call ToggleAll

If LenB(sResult) > 0 Then
    Call OpenFile
End If
   
End Sub

Private Sub mnuReloadROM_Click()
    If Not blnROMCode Or Not blnROMName Then Exit Sub
    Call OpenFile
End Sub

Private Sub mnuSaveROM_Click()
Dim i As Integer

    For i = cboList.LBound To cboList.UBound
        Call cboList_LostFocus(i)
    Next
    
    For i = txtRivalLevel.LBound To txtRivalLevel.UBound
        Call txtRivalLevel_LostFocus(i)
        Call cboRivalItem_LostFocus(i)
    Next
    
    Call txtStarterLevel_LostFocus
    Call cboHeldItem_LostFocus
    
    Call SaveData
    
End Sub

Private Sub mnuExit_Click()
    Unload Me
End Sub

Private Sub mnuReadme_Click()
    Shell "notepad.exe " & App.Path & "\Readme.txt", vbNormalFocus
End Sub

Private Sub mnuInfo_Click()
    frmAbout.Show vbModal, frmMain
End Sub

Private Sub optMale_Click()
    If Not blnROMCode Or Not blnROMName Then Exit Sub
    Call OpenFile
End Sub

Private Sub optFemale_Click()
    If Not blnROMCode Or Not blnROMName Then Exit Sub
    Call OpenFile
End Sub

Private Sub RSEMode()
    strMode = "RSE"
    optMale.Enabled = True
    optFemale.Enabled = True
End Sub

Private Sub FRLGMode()
    strMode = "FRLG"
    optMale.Enabled = False
    optFemale.Enabled = False
End Sub

Private Sub CorruptionCheck()
Dim i As Integer

If blnROMCode And blnROMName Then
    For i = cboList.LBound To cboList.UBound
        If cboList(i).ListIndex < 0 Then
            MsgBox LoadResString(1017), vbExclamation
            Exit For
        End If
    Next
End If

End Sub

Private Sub NotSupported()
    blnROMCode = False
    blnROMName = False
End Sub

Private Sub ToggleAll()
    
    Dim i As Integer
    
    For i = cboList.LBound To cboList.UBound
        cboList(i).Enabled = False
        cboList(i).ListIndex = 0
    Next
        
    cmdDefault.Enabled = False
        
    txtStarterLevel.Enabled = False
    cboHeldItem.Enabled = False
    Label2.Enabled = False
    Label3.Enabled = False
        
    txtStarterLevel.Text = 0
    cboHeldItem.ListIndex = 0

    optFemale.Value = True
    optMale.Enabled = False
    optFemale.Enabled = False
        
    Label4.Enabled = False
    Label5.Enabled = False
    Label7.Enabled = False
    Label8.Enabled = False
    Label9.Enabled = False
    Label10.Enabled = False
        
    For i = txtRivalLevel.LBound To txtRivalLevel.UBound
        txtRivalLevel(i).Enabled = False
        txtRivalLevel(i).Text = 0
        cboRivalItem(i).Enabled = False
        cboRivalItem(i).ListIndex = 0
    Next

End Sub

Private Sub OpenFile()
Dim i As Integer
    
    strROMPath = sResult
    Call ReadData(sResult)
    
    Dim code As String, lang As String
    code = Mid$(lblROMCode.Caption, 1, 3)
    lang = Mid$(lblROMCode.Caption, 4, 1)
    
    If code = "AXV" Or code = "AXP" Or code = "BPE" Or code = "BPR" Or code = "BPG" Then
        
        blnROMCode = True
        
    Select Case lang
    Case "J"
        lblROMLang.Caption = LoadResString(1018)
    Case "E"
        lblROMLang.Caption = LoadResString(1019)
    Case "I"
        lblROMLang.Caption = LoadResString(1020)
    Case "S"
        lblROMLang.Caption = LoadResString(1021)
    Case "F"
        lblROMLang.Caption = LoadResString(1022)
    Case "D"
        lblROMLang.Caption = LoadResString(1023)
    
    Case Else
        lblROMLang.Caption = "???"
        Call NotSupported
        
    End Select
    
    Else: Call NotSupported
    
    End If
    
    
    Select Case lblROMName.Caption
    
    Case "POKEMON RUBY"
    
    Call RSEMode
    blnROMName = True
    
    Select Case lang
    
    Case "J"
        strOffset1 = "4007368"
        strOffset3 = "520304"
    Case "E"
        Select Case strROMVersion
        Case "0"
            strOffset1 = "4159172"
            strOffset3 = "532904"
        Case "1", "2"
            strOffset1 = "4159200"
            strOffset3 = "532936"
        End Select
    Case "I"
        strOffset1 = "4163348"
        strOffset3 = "533884"
    Case "S"
        strOffset1 = "4175116"
        strOffset3 = "534116"
    Case "F"
        strOffset1 = "4191220"
        strOffset3 = "534212"
    Case "D"
        strOffset1 = "4209648"
        strOffset3 = "533980"
    
    End Select
    
    If optMale.Value = True Then
    
    Select Case lang
    
    Case "J"
        strOffset2 = "1850049"
    Case "E"
        Select Case strROMVersion
        Case "0"
            strOffset2 = "2028213"
        Case "1", "2"
            strOffset2 = "2028237"
        End Select
    Case "I"
        strOffset2 = "2035537"
    Case "S"
        strOffset2 = "2047957"
    Case "F"
        strOffset2 = "2062013"
    Case "D"
        strOffset2 = "2081329"
    
    End Select
    
    Else
    
    Select Case lang
    
    Case "J"
        strOffset2 = "1850217"
    Case "E"
        Select Case strROMVersion
        Case "0"
            strOffset2 = "2028381"
        Case "1", "2"
            strOffset2 = "2028405"
        End Select
    Case "I"
        strOffset2 = "2035705"
    Case "S"
        strOffset2 = "2048125"
    Case "F"
        strOffset2 = "2062181"
    Case "D"
        strOffset2 = "2081497"
    
    End Select
    End If
    
    
    Case "POKEMON SAPP"
    
    Call RSEMode
    blnROMName = True
    
    Select Case lang
    
    Case "J"
        strOffset1 = "4007340"
        strOffset3 = "520304"
    Case "E"
        Select Case strROMVersion
        Case "0"
            strOffset1 = "4159260"
            strOffset3 = "532904"
        Case "1", "2"
            strOffset1 = "4159292"
            strOffset3 = "532936"
        End Select
    Case "I"
        strOffset1 = "4162488"
        strOffset3 = "533884"
    Case "S"
        strOffset1 = "4174408"
        strOffset3 = "534116"
    Case "F"
        strOffset1 = "4189988"
        strOffset3 = "534212"
    Case "D"
        strOffset1 = "4209500"
        strOffset3 = "533980"
    
    End Select
    
    If optMale.Value = True Then
    Select Case lang
    
    Case "J"
        strOffset2 = "1849937"
    Case "E"
        Select Case strROMVersion
        Case "0"
            strOffset2 = "2028101"
        Case "1", "2"
            strOffset2 = "2028125"
        End Select
    Case "I"
        strOffset2 = "2035425"
    Case "S"
        strOffset2 = "2047845"
    Case "F"
        strOffset2 = "2061901"
    Case "D"
        strOffset2 = "2081221"
    
    End Select
    
    
    Else
    Select Case lang
    
    Case "J"
        strOffset2 = "1850105"
    Case "E"
        Select Case strROMVersion
        Case "0"
            strOffset2 = "2028269"
        Case "1", "2"
            strOffset2 = "2028293"
        End Select
    Case "I"
        strOffset2 = "2035593"
    Case "S"
        strOffset2 = "2048013"
    Case "F"
        strOffset2 = "2062069"
    Case "D"
        strOffset2 = "2081389"
    
    End Select
    End If
    
    
    Case "POKEMON EMER"
      
    Call RSEMode
    blnROMName = True
    
    Select Case lang
    
    Case "J"
        strOffset1 = "5835784"
        strOffset3 = "723556"
    Case "E"
        strOffset1 = "5971448"
        strOffset3 = "725368"
    Case "I"
        strOffset1 = "5958036"
        strOffset3 = "725388"
    Case "S"
        strOffset1 = "5982716"
        strOffset3 = "725388"
    Case "F"
        strOffset1 = "5989348"
        strOffset3 = "725388"
    Case "D"
        strOffset1 = "6041520"
        strOffset3 = "725396"
    
    End Select
    
    If optMale.Value = True Then
    Select Case lang
    
    Case "J"
        strOffset2 = "3019713"
    Case "E"
        strOffset2 = "3201841"
    Case "I"
        strOffset2 = "3200245"
    Case "S"
        strOffset2 = "3227029"
    Case "F"
        strOffset2 = "3233377"
    Case "D"
        strOffset2 = "3286177"
    
    End Select
    
    Else
    Select Case lang
    
    Case "J"
        strOffset2 = "3019881"
    Case "E"
        strOffset2 = "3202009"
    Case "I"
        strOffset2 = "3200413"
    Case "S"
        strOffset2 = "3227197"
    Case "F"
        strOffset2 = "3233545"
    Case "D"
        strOffset2 = "3286345"
    
    End Select
    End If
    
        
    Case "POKEMON FIRE"
    
    Call FRLGMode
    blnROMName = True
    
    Select Case lang
    
    Case "J"
        strOffset1 = "1561040"
        strOffset2 = "2076120"
    Case "E"
        Select Case strROMVersion
        Case "0"
            strOffset1 = "1481653"
            strOffset2 = "2340852"
        Case "1"
            strOffset1 = "1481773"
            strOffset2 = "2340964"
        End Select
    Case "I"
        strOffset1 = "1481568"
        strOffset2 = "2312344"
    Case "S"
        strOffset1 = "1481804"
        strOffset2 = "2322272"
    Case "F"
        strOffset1 = "1481692"
        strOffset2 = "2317312"
    Case "D"
        strOffset1 = "1481504"
        strOffset2 = "2340548"
   
    End Select
    
    
    Case "POKEMON LEAF"
    
    Call FRLGMode
    blnROMName = True
    
    Select Case lang
    
    Case "J"
        strOffset1 = "1561004"
        strOffset2 = "2076084"
    Case "E"
        Select Case strROMVersion
        Case "0"
            strOffset1 = "1481617"
            strOffset2 = "2340816"
        Case "1"
            strOffset1 = "1481737"
            strOffset2 = "2340928"
        End Select
    Case "I"
        strOffset1 = "1481532"
        strOffset2 = "2312308"
    Case "S"
        strOffset1 = "1481768"
        strOffset2 = "2322236"
    Case "F"
        strOffset1 = "1481656"
        strOffset2 = "2317276"
    Case "D"
        strOffset1 = "1481468"
        strOffset2 = "2340512"
        
    End Select
    
    Case Else
    Call NotSupported
      
    End Select
    
    If blnROMCode And blnROMName Then
        mnuSaveROM.Enabled = True
        mnuReLoadROM.Enabled = True
    ElseIf Not blnROMCode Or Not blnROMName Then
        Call NotSupported
        MsgBox LoadResString(1024) & vbCrLf & vbCrLf & LoadResString(1009) & ":" & vbCrLf & LoadResString(1010) & " " & lblROMName.Caption & vbCrLf & LoadResString(1011) & " " & lblROMCode.Caption, vbExclamation
        optMale.Enabled = False
        optFemale.Enabled = False
        
        Call ToggleAll
    
        mnuSaveROM.Enabled = False
        mnuReLoadROM.Enabled = False
        
        Exit Sub
    End If

    If blnROMCode And blnROMName Then
        
        Call LoadData(sResult)
        
        cmdDefault.Enabled = True
        
        Label4.Enabled = True
        Label5.Enabled = True
        Label7.Enabled = True
        Label8.Enabled = True
        Label9.Enabled = True
        Label10.Enabled = True
        
        For i = txtRivalLevel.LBound To txtRivalLevel.UBound
            txtRivalLevel(i).Enabled = True
            cboRivalItem(i).Enabled = True
        Next
        
        txtStarterLevel.Enabled = True
        cboHeldItem.Enabled = True
        Label2.Enabled = True
        Label3.Enabled = True
        
    End If
    
End Sub

Private Sub ReadData(strFile As String)
Dim ROMName As String * 12, ROMCode As String * 4
Dim Data As Byte, i As Integer

lblROMName.Caption = vbNullString
lblROMCode.Caption = vbNullString
strROMVersion = vbNullString

For i = cboList.LBound To cboList.UBound
    cboList(i).Enabled = True
Next

Open strFile For Binary As #FileNum
    Get #FileNum, &HA1, ROMName
    lblROMName.Caption = ROMName
    
    Get #FileNum, &HAD, ROMCode
    lblROMCode.Caption = ROMCode
    
    Get #FileNum, &HBD, Data
    strROMVersion = Data
Close #FileNum
            
End Sub

Private Sub LoadIntValue(cboComboBox As ComboBox, bytTest As Byte, bytValue As Byte, Optional bytAdjust As Byte = 0)
    If bytTest < 1 Then
        cboComboBox.ListIndex = bytValue
    Else
        cboComboBox.ListIndex = bytValue + 255 + bytAdjust
    End If
End Sub

Private Sub LoadData(strFile As String)

Dim Data As Byte, Data2 As Byte, i As Integer
FileNum = FreeFile
    
Open strFile For Binary As #FileNum
    
    If Len(strMode) = 3 Then
    
    'Load Pokes
    
        Get #FileNum, strOffset1 + 1, Data
        Get #FileNum, strOffset1 + 2, Data2
        Call LoadIntValue(cboList(0), Data2, Data)
    
        Get #FileNum, strOffset1 + 3, Data
        Get #FileNum, strOffset1 + 4, Data2
        Call LoadIntValue(cboList(1), Data2, Data)
    
        Get #FileNum, strOffset1 + 5, Data
        Get #FileNum, strOffset1 + 6, Data2
        Call LoadIntValue(cboList(2), Data2, Data)
        
    
        Get #FileNum, strOffset2 + 56, Data
        Get #FileNum, strOffset2 + 57, Data2
        Call LoadIntValue(cboList(3), Data2, Data)
        
        Get #FileNum, strOffset3 + 1, Data
        txtStarterLevel.Text = Data
        
        Get #FileNum, strOffset3 + 3, Data
        Get #FileNum, strOffset3 + 5, Data2
        If Data2 = 0 Then
            Call LoadIntValue(cboHeldItem, Data2, Data, 1)
        Else
            cboHeldItem.ListIndex = Data2 + 255
        End If
        
        
        Get #FileNum, strOffset2 + 54, Data
        txtRivalLevel(0).Text = Data
        
        Get #FileNum, strOffset2 + 58, Data
        Get #FileNum, strOffset2 + 59, Data2
        Call LoadIntValue(cboRivalItem(0), Data2, Data, 1)
        
    
        Get #FileNum, strOffset2 + 112, Data
        Get #FileNum, strOffset2 + 113, Data2
        Call LoadIntValue(cboList(4), Data2, Data)
        
        Get #FileNum, strOffset2 + 110, Data
        txtRivalLevel(1).Text = Data
        
        Get #FileNum, strOffset2 + 114, Data
        Get #FileNum, strOffset2 + 115, Data2
        Call LoadIntValue(cboRivalItem(1), Data2, Data, 1)
    
    
        Get #FileNum, strOffset2 + 0, Data
        Get #FileNum, strOffset2 + 1, Data2
        Call LoadIntValue(cboList(5), Data2, Data)
        
        Get #FileNum, strOffset2 - 2, Data
        txtRivalLevel(2).Text = Data
        
        Get #FileNum, strOffset2 + 2, Data
        Get #FileNum, strOffset2 + 3, Data2
        Call LoadIntValue(cboRivalItem(2), Data2, Data, 1)
       
    ElseIf Len(strMode) = 4 Then
  
    'Load Pokes
        
        Get #FileNum, strOffset1 + 1, Data
        Get #FileNum, strOffset1 + 2, Data2
        Call LoadIntValue(cboList(0), Data2, Data)
    
        Get #FileNum, strOffset1 + 462, Data
        Get #FileNum, strOffset1 + 463, Data2
        Call LoadIntValue(cboList(1), Data2, Data)
    
        Get #FileNum, strOffset1 + 516, Data
        Get #FileNum, strOffset1 + 517, Data2
        Call LoadIntValue(cboList(2), Data2, Data)
    
    
        Get #FileNum, strOffset1 + 218, Data
        txtStarterLevel.Text = Data
    
        Get #FileNum, strOffset1 + 219, Data
        Get #FileNum, strOffset1 + 220, Data2
        Call LoadIntValue(cboHeldItem, Data2, Data, 1)
    
    
    'Load Rival
    
        Get #FileNum, strOffset1 + 6, Data
        Get #FileNum, strOffset1 + 7, Data2
        Call LoadIntValue(cboList(3), Data2, Data)
        
        Get #FileNum, strOffset2 + 15, Data
        txtRivalLevel(0).Text = Data
        
        Get #FileNum, strOffset2 + 19, Data
        Get #FileNum, strOffset2 + 20, Data2
        Call LoadIntValue(cboRivalItem(0), Data2, Data, 1)
        
        
        Get #FileNum, strOffset1 + 467, Data
        Get #FileNum, strOffset1 + 468, Data2
        Call LoadIntValue(cboList(4), Data2, Data)
        
        Get #FileNum, strOffset2 + 7, Data
        txtRivalLevel(1).Text = Data
        
        Get #FileNum, strOffset2 + 11, Data
        Get #FileNum, strOffset2 + 12, Data2
        Call LoadIntValue(cboRivalItem(1), Data2, Data, 1)
        
    
        Get #FileNum, strOffset1 + 521, Data
        Get #FileNum, strOffset1 + 522, Data2
        Call LoadIntValue(cboList(5), Data2, Data)
        
        Get #FileNum, strOffset2 - 1, Data
        txtRivalLevel(2).Text = Data
        
        Get #FileNum, strOffset2 + 3, Data
        Get #FileNum, strOffset2 + 4, Data2
        Call LoadIntValue(cboRivalItem(2), Data2, Data, 1)
       
    End If

Close #FileNum

Call CorruptionCheck
cboList(cboList.LBound).SetFocus

End Sub

Private Sub SaveData()

FileNum = FreeFile
SetAttr sResult, vbNormal

cboList(cboList.LBound).SetFocus

Open sResult For Binary As #FileNum
    
    If Len(strMode) = 3 Then
        
    'Pokes
    
        If cboList(0).ListIndex < 256 Then
            Put #FileNum, strOffset1 + 1, CByte(cboList(0).ListIndex)
            Put #FileNum, strOffset1 + 2, CByte(0)
        Else
            Put #FileNum, strOffset1 + 1, CByte(cboList(0).ListIndex - 255)
            Put #FileNum, strOffset1 + 2, CByte(1)
        End If
    
        If cboList(1).ListIndex < 256 Then
            Put #FileNum, strOffset1 + 3, CByte(cboList(1).ListIndex)
            Put #FileNum, strOffset1 + 4, CByte(0)
        Else
            Put #FileNum, strOffset1 + 3, CByte(cboList(1).ListIndex - 255)
            Put #FileNum, strOffset1 + 4, CByte(1)
        End If
    
        If cboList(2).ListIndex < 256 Then
            Put #FileNum, strOffset1 + 5, CByte(cboList(2).ListIndex)
            Put #FileNum, strOffset1 + 6, CByte(0)
        Else
            Put #FileNum, strOffset1 + 5, CByte(cboList(2).ListIndex - 255)
            Put #FileNum, strOffset1 + 6, CByte(1)
        End If
        
        Put #FileNum, strOffset3 + 1, CByte(txtStarterLevel.Text)
        
        If cboHeldItem.ListIndex < 256 Then
            Put #FileNum, strOffset3 + 3, CByte(cboHeldItem.ListIndex)
            Put #FileNum, strOffset3 + 5, CByte(0)
            Put #FileNum, strOffset3 + 6, CByte(&H32)
        Else
            Put #FileNum, strOffset3 + 3, CByte(&HFF)
            Put #FileNum, strOffset3 + 5, CByte(cboHeldItem.ListIndex - 255)
            Put #FileNum, strOffset3 + 6, CByte(&H32)
        End If
    
    
    'Rival
    
        If cboList(3).ListIndex < 256 Then
            Put #FileNum, strOffset2 + 56, CByte(cboList(3).ListIndex)
            Put #FileNum, strOffset2 + 57, CByte(0)
        Else
            Put #FileNum, strOffset2 + 56, CByte(cboList(3).ListIndex - 255)
            Put #FileNum, strOffset2 + 57, CByte(1)
        End If
        
        Put #FileNum, strOffset2 + 54, CByte(txtRivalLevel(0).Text)
        
        If cboRivalItem(0).ListIndex < 256 Then
            Put #FileNum, strOffset2 + 58, CByte(cboRivalItem(0).ListIndex)
            Put #FileNum, strOffset2 + 59, CByte(0)
        Else
            Put #FileNum, strOffset2 + 58, CByte(cboRivalItem(0).ListIndex - 256)
            Put #FileNum, strOffset2 + 59, CByte(1)
        End If
                
    
        If cboList(4).ListIndex < 256 Then
            Put #FileNum, strOffset2 + 112, CByte(cboList(4).ListIndex)
            Put #FileNum, strOffset2 + 113, CByte(0)
        Else
            Put #FileNum, strOffset2 + 112, CByte(cboList(4).ListIndex - 255)
            Put #FileNum, strOffset2 + 113, CByte(1)
        End If
        
        Put #FileNum, strOffset2 + 110, CByte(txtRivalLevel(1).Text)
        
        If cboRivalItem(1).ListIndex < 256 Then
            Put #FileNum, strOffset2 + 114, CByte(cboRivalItem(1).ListIndex)
            Put #FileNum, strOffset2 + 115, CByte(0)
        Else
            Put #FileNum, strOffset2 + 114, CByte(cboRivalItem(1).ListIndex - 256)
            Put #FileNum, strOffset2 + 115, CByte(1)
        End If
                
        
        If cboList(5).ListIndex < 256 Then
            Put #FileNum, strOffset2 + 0, CByte(cboList(5).ListIndex)
            Put #FileNum, strOffset2 + 1, CByte(0)
        Else
            Put #FileNum, strOffset2 + 0, CByte(cboList(5).ListIndex - 255)
            Put #FileNum, strOffset2 + 1, CByte(1)
        End If
        
        Put #FileNum, strOffset2 - 2, CByte(txtRivalLevel(2).Text)
        
        If cboRivalItem(2).ListIndex < 256 Then
            Put #FileNum, strOffset2 + 2, CByte(cboRivalItem(2).ListIndex)
            Put #FileNum, strOffset2 + 3, CByte(0)
        Else
            Put #FileNum, strOffset2 + 2, CByte(cboRivalItem(2).ListIndex - 256)
            Put #FileNum, strOffset2 + 3, CByte(1)
        End If


    ElseIf Len(strMode) = 4 Then
   
    'Pokes
        
        If cboList(0).ListIndex < 256 Then
            Put #FileNum, strOffset1 + 1, CByte(cboList(0).ListIndex)
            Put #FileNum, strOffset1 + 2, CByte(0)
        Else
            Put #FileNum, strOffset1 + 1, CByte(cboList(0).ListIndex - 255)
            Put #FileNum, strOffset1 + 2, CByte(1)
        End If
    
        If cboList(1).ListIndex < 256 Then
            Put #FileNum, strOffset1 + 462, CByte(cboList(1).ListIndex)
            Put #FileNum, strOffset1 + 463, CByte(0)
        Else
            Put #FileNum, strOffset1 + 462, CByte(cboList(1).ListIndex - 255)
            Put #FileNum, strOffset1 + 463, CByte(1)
        End If

        If cboList(2).ListIndex < 256 Then
            Put #FileNum, strOffset1 + 516, CByte(cboList(2).ListIndex)
            Put #FileNum, strOffset1 + 517, CByte(0)
        Else
            Put #FileNum, strOffset1 + 516, CByte(cboList(2).ListIndex - 255)
            Put #FileNum, strOffset1 + 517, CByte(1)
        End If
        
        Put #FileNum, strOffset1 + 218, CByte(txtStarterLevel.Text)
       
        If cboHeldItem.ListIndex < 256 Then
            Put #FileNum, strOffset1 + 219, CByte(cboHeldItem.ListIndex)
            Put #FileNum, strOffset1 + 220, CByte(0)
        Else
            Put #FileNum, strOffset1 + 219, CByte(cboHeldItem.ListIndex - 256)
            Put #FileNum, strOffset1 + 220, CByte(1)
        End If
    
    'Rival
    
        If cboList(3).ListIndex < 256 Then
            Put #FileNum, strOffset1 + 6, CByte(cboList(3).ListIndex)
            Put #FileNum, strOffset1 + 7, CByte(0)
            Put #FileNum, strOffset2 + 17, CByte(cboList(3).ListIndex)
            Put #FileNum, strOffset2 + 18, CByte(0)
        Else
            Put #FileNum, strOffset1 + 6, CByte(cboList(3).ListIndex - 255)
            Put #FileNum, strOffset1 + 7, CByte(1)
            Put #FileNum, strOffset2 + 17, CByte(cboList(3).ListIndex - 255)
            Put #FileNum, strOffset2 + 18, CByte(1)
        End If
        
        Put #FileNum, strOffset2 + 15, CByte(txtRivalLevel(0).Text)
        
        If cboRivalItem(0).ListIndex < 256 Then
            Put #FileNum, strOffset2 + 19, CByte(cboRivalItem(0).ListIndex)
            Put #FileNum, strOffset2 + 20, CByte(0)
        Else
            Put #FileNum, strOffset2 + 19, CByte(cboRivalItem(0).ListIndex - 256)
            Put #FileNum, strOffset2 + 20, CByte(1)
        End If
            
            
        If cboList(4).ListIndex < 256 Then
            Put #FileNum, strOffset1 + 467, CByte(cboList(4).ListIndex)
            Put #FileNum, strOffset1 + 468, CByte(0)
            Put #FileNum, strOffset2 + 9, CByte(cboList(4).ListIndex)
            Put #FileNum, strOffset2 + 10, 0
        Else
            Put #FileNum, strOffset1 + 467, CByte(cboList(4).ListIndex - 255)
            Put #FileNum, strOffset1 + 468, CByte(1)
            Put #FileNum, strOffset2 + 9, CByte(cboList(4).ListIndex - 255)
            Put #FileNum, strOffset2 + 10, CByte(1)
        End If
        
        Put #FileNum, strOffset2 + 7, CByte(txtRivalLevel(1).Text)
        
        If cboRivalItem(1).ListIndex < 256 Then
            Put #FileNum, strOffset2 + 11, CByte(cboRivalItem(1).ListIndex)
            Put #FileNum, strOffset2 + 12, CByte(0)
        Else
            Put #FileNum, strOffset2 + 11, CByte(cboRivalItem(1).ListIndex - 256)
            Put #FileNum, strOffset2 + 12, CByte(1)
        End If
        
    
        If cboList(5).ListIndex < 256 Then
            Put #FileNum, strOffset1 + 521, CByte(cboList(5).ListIndex)
            Put #FileNum, strOffset1 + 522, CByte(0)
            Put #FileNum, strOffset2 + 1, CByte(cboList(5).ListIndex)
            Put #FileNum, strOffset2 + 2, CByte(0)
        Else
            Put #FileNum, strOffset1 + 521, CByte(cboList(5).ListIndex - 255)
            Put #FileNum, strOffset1 + 522, CByte(1)
            Put #FileNum, strOffset2 + 1, CByte(cboList(5).ListIndex - 255)
            Put #FileNum, strOffset2 + 2, CByte(1)
        End If
        
        If LenB(txtRivalLevel(2).Text) = 0 Then txtRivalLevel(2).Text = 0
        Put #FileNum, strOffset2 - 1, CByte(txtRivalLevel(2).Text)
        
        If cboRivalItem(2).ListIndex < 256 Then
            Put #FileNum, strOffset2 + 3, CByte(cboRivalItem(2).ListIndex)
            Put #FileNum, strOffset2 + 4, CByte(0)
        Else
            Put #FileNum, strOffset2 + 3, CByte(cboRivalItem(2).ListIndex - 256)
            Put #FileNum, strOffset2 + 4, CByte(1)
        End If
                    
    End If
    
Close #FileNum
    
End Sub

Private Sub txtRivalLevel_Change(Index As Integer)
    If Val(txtRivalLevel(Index).Text) > 100 Then txtRivalLevel(Index).Text = 100
End Sub

Private Sub txtRivalLevel_KeyPress(Index As Integer, KeyCode As Integer)
    Call txtStarterLevel_KeyPress(KeyCode)
End Sub

Private Sub txtRivalLevel_LostFocus(Index As Integer)
    If LenB(txtRivalLevel(Index).Text) = 0 Then txtRivalLevel(Index).Text = 0
End Sub

Private Sub txtStarterLevel_Change()
    If Val(txtStarterLevel.Text) > 100 Then txtStarterLevel = 100
End Sub

Private Sub txtStarterLevel_KeyPress(KeyCode As Integer)
    If Not IsNumeric(Chr$(KeyCode)) And KeyCode <> vbKeyBack Then
        KeyCode = 0
    End If
End Sub

Private Sub txtStarterLevel_LostFocus()
    If LenB(txtStarterLevel.Text) = 0 Then txtStarterLevel.Text = 0
End Sub
