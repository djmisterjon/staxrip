Imports StaxRip.UI

Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Globalization
Imports System.Threading.Tasks

Imports Microsoft.Win32
Imports System.ComponentModel

Public Class eac3toForm
    Inherits DialogBase

#Region " Designer "

    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents CommandLink1 As StaxRip.UI.CommandLink
    Friend WithEvents cbVideoOutput As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdlOptions As StaxRip.CommandLineControl
    Friend WithEvents bnBrowse As StaxRip.UI.ButtonEx
    Friend WithEvents tbTempDir As System.Windows.Forms.TextBox
    Friend WithEvents bnCancel As StaxRip.UI.ButtonEx
    Friend WithEvents bnOK As StaxRip.UI.ButtonEx
    Friend WithEvents lvAudio As ListViewEx
    Friend WithEvents lvSubtitles As StaxRip.UI.ListViewEx
    Friend WithEvents llAudioAll As System.Windows.Forms.LinkLabel
    Friend WithEvents llAudioNone As System.Windows.Forms.LinkLabel
    Friend WithEvents llSubtitlesAll As System.Windows.Forms.LinkLabel
    Friend WithEvents llSubtitlesNone As System.Windows.Forms.LinkLabel
    Friend WithEvents cbVideoStream As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents flpAudioLinks As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpSubtitleLinks As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tlp As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cbChapters As System.Windows.Forms.CheckBox
    Friend WithEvents llSubtitlesEnglish As System.Windows.Forms.LinkLabel
    Friend WithEvents llSubtitlesNative As System.Windows.Forms.LinkLabel
    Friend WithEvents llAudioEnglish As System.Windows.Forms.LinkLabel
    Friend WithEvents llAudioNative As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbAudio As System.Windows.Forms.GroupBox
    Friend WithEvents gbSubtitles As System.Windows.Forms.GroupBox
    Friend WithEvents cbAudioOutput As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bnMenu As StaxRip.UI.ButtonEx
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdlOptions = New StaxRip.CommandLineControl()
        Me.cbVideoOutput = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bnBrowse = New StaxRip.UI.ButtonEx()
        Me.tbTempDir = New System.Windows.Forms.TextBox()
        Me.bnCancel = New StaxRip.UI.ButtonEx()
        Me.bnOK = New StaxRip.UI.ButtonEx()
        Me.lvAudio = New StaxRip.UI.ListViewEx()
        Me.lvSubtitles = New StaxRip.UI.ListViewEx()
        Me.llAudioAll = New System.Windows.Forms.LinkLabel()
        Me.llAudioNone = New System.Windows.Forms.LinkLabel()
        Me.llSubtitlesAll = New System.Windows.Forms.LinkLabel()
        Me.llSubtitlesNone = New System.Windows.Forms.LinkLabel()
        Me.flpSubtitleLinks = New System.Windows.Forms.FlowLayoutPanel()
        Me.llSubtitlesEnglish = New System.Windows.Forms.LinkLabel()
        Me.llSubtitlesNative = New System.Windows.Forms.LinkLabel()
        Me.flpAudioLinks = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.llAudioEnglish = New System.Windows.Forms.LinkLabel()
        Me.llAudioNative = New System.Windows.Forms.LinkLabel()
        Me.cbVideoStream = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tlp = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bnMenu = New StaxRip.UI.ButtonEx()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cbChapters = New System.Windows.Forms.CheckBox()
        Me.gbAudio = New System.Windows.Forms.GroupBox()
        Me.cbAudioOutput = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbSubtitles = New System.Windows.Forms.GroupBox()
        Me.flpSubtitleLinks.SuspendLayout()
        Me.flpAudioLinks.SuspendLayout()
        Me.tlp.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbAudio.SuspendLayout()
        Me.gbSubtitles.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdlOptions
        '
        Me.cmdlOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdlOptions.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlOptions.Location = New System.Drawing.Point(304, 315)
        Me.cmdlOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdlOptions.Name = "cmdlOptions"
        Me.cmdlOptions.Size = New System.Drawing.Size(725, 36)
        Me.cmdlOptions.TabIndex = 5
        '
        'cbVideoOutput
        '
        Me.cbVideoOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVideoOutput.FormattingEnabled = True
        Me.cbVideoOutput.Location = New System.Drawing.Point(85, 13)
        Me.cbVideoOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.cbVideoOutput.Name = "cbVideoOutput"
        Me.cbVideoOutput.Size = New System.Drawing.Size(115, 33)
        Me.cbVideoOutput.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Video:"
        '
        'bnBrowse
        '
        Me.bnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bnBrowse.Location = New System.Drawing.Point(1009, 5)
        Me.bnBrowse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bnBrowse.Size = New System.Drawing.Size(36, 36)
        Me.bnBrowse.Text = "..."
        '
        'tbTempDir
        '
        Me.tbTempDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTempDir.Location = New System.Drawing.Point(152, 8)
        Me.tbTempDir.Name = "tbTempDir"
        Me.tbTempDir.Size = New System.Drawing.Size(850, 31)
        Me.tbTempDir.TabIndex = 0
        '
        'bnCancel
        '
        Me.bnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bnCancel.Location = New System.Drawing.Point(940, 2)
        Me.bnCancel.Size = New System.Drawing.Size(100, 36)
        Me.bnCancel.Text = "Cancel"
        '
        'bnOK
        '
        Me.bnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bnOK.Location = New System.Drawing.Point(834, 2)
        Me.bnOK.Size = New System.Drawing.Size(100, 36)
        Me.bnOK.Text = "OK"
        '
        'lvAudio
        '
        Me.lvAudio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvAudio.Location = New System.Drawing.Point(11, 30)
        Me.lvAudio.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.lvAudio.Name = "lvAudio"
        Me.lvAudio.Size = New System.Drawing.Size(1018, 277)
        Me.lvAudio.TabIndex = 8
        Me.lvAudio.UseCompatibleStateImageBehavior = False
        '
        'lvSubtitles
        '
        Me.lvSubtitles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvSubtitles.Location = New System.Drawing.Point(11, 30)
        Me.lvSubtitles.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.lvSubtitles.Name = "lvSubtitles"
        Me.lvSubtitles.Size = New System.Drawing.Size(1018, 133)
        Me.lvSubtitles.TabIndex = 9
        Me.lvSubtitles.UseCompatibleStateImageBehavior = False
        '
        'llAudioAll
        '
        Me.llAudioAll.AutoSize = True
        Me.llAudioAll.Location = New System.Drawing.Point(3, 0)
        Me.llAudioAll.Name = "llAudioAll"
        Me.llAudioAll.Size = New System.Drawing.Size(32, 25)
        Me.llAudioAll.TabIndex = 1
        Me.llAudioAll.TabStop = True
        Me.llAudioAll.Text = "All"
        '
        'llAudioNone
        '
        Me.llAudioNone.AutoSize = True
        Me.llAudioNone.Location = New System.Drawing.Point(47, 0)
        Me.llAudioNone.Name = "llAudioNone"
        Me.llAudioNone.Size = New System.Drawing.Size(55, 25)
        Me.llAudioNone.TabIndex = 2
        Me.llAudioNone.TabStop = True
        Me.llAudioNone.Text = "None"
        '
        'llSubtitlesAll
        '
        Me.llSubtitlesAll.AutoSize = True
        Me.llSubtitlesAll.Location = New System.Drawing.Point(3, 0)
        Me.llSubtitlesAll.Name = "llSubtitlesAll"
        Me.llSubtitlesAll.Size = New System.Drawing.Size(32, 25)
        Me.llSubtitlesAll.TabIndex = 3
        Me.llSubtitlesAll.TabStop = True
        Me.llSubtitlesAll.Text = "All"
        '
        'llSubtitlesNone
        '
        Me.llSubtitlesNone.AutoSize = True
        Me.llSubtitlesNone.Location = New System.Drawing.Point(41, 0)
        Me.llSubtitlesNone.Name = "llSubtitlesNone"
        Me.llSubtitlesNone.Size = New System.Drawing.Size(55, 25)
        Me.llSubtitlesNone.TabIndex = 4
        Me.llSubtitlesNone.TabStop = True
        Me.llSubtitlesNone.Text = "None"
        '
        'flpSubtitleLinks
        '
        Me.flpSubtitleLinks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.flpSubtitleLinks.AutoSize = True
        Me.flpSubtitleLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpSubtitleLinks.Controls.Add(Me.llSubtitlesAll)
        Me.flpSubtitleLinks.Controls.Add(Me.llSubtitlesNone)
        Me.flpSubtitleLinks.Controls.Add(Me.llSubtitlesEnglish)
        Me.flpSubtitleLinks.Controls.Add(Me.llSubtitlesNative)
        Me.flpSubtitleLinks.Location = New System.Drawing.Point(9, 169)
        Me.flpSubtitleLinks.Name = "flpSubtitleLinks"
        Me.flpSubtitleLinks.Size = New System.Drawing.Size(241, 25)
        Me.flpSubtitleLinks.TabIndex = 19
        '
        'llSubtitlesEnglish
        '
        Me.llSubtitlesEnglish.AutoSize = True
        Me.llSubtitlesEnglish.Enabled = False
        Me.llSubtitlesEnglish.Location = New System.Drawing.Point(102, 0)
        Me.llSubtitlesEnglish.Name = "llSubtitlesEnglish"
        Me.llSubtitlesEnglish.Size = New System.Drawing.Size(68, 25)
        Me.llSubtitlesEnglish.TabIndex = 5
        Me.llSubtitlesEnglish.TabStop = True
        Me.llSubtitlesEnglish.Text = "English"
        '
        'llSubtitlesNative
        '
        Me.llSubtitlesNative.AutoSize = True
        Me.llSubtitlesNative.Enabled = False
        Me.llSubtitlesNative.Location = New System.Drawing.Point(176, 0)
        Me.llSubtitlesNative.Name = "llSubtitlesNative"
        Me.llSubtitlesNative.Size = New System.Drawing.Size(62, 25)
        Me.llSubtitlesNative.TabIndex = 6
        Me.llSubtitlesNative.TabStop = True
        Me.llSubtitlesNative.Text = "Native"
        '
        'flpAudioLinks
        '
        Me.flpAudioLinks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.flpAudioLinks.AutoSize = True
        Me.flpAudioLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpAudioLinks.Controls.Add(Me.llAudioAll)
        Me.flpAudioLinks.Controls.Add(Me.FlowLayoutPanel1)
        Me.flpAudioLinks.Controls.Add(Me.llAudioNone)
        Me.flpAudioLinks.Controls.Add(Me.llAudioEnglish)
        Me.flpAudioLinks.Controls.Add(Me.llAudioNative)
        Me.flpAudioLinks.Location = New System.Drawing.Point(9, 359)
        Me.flpAudioLinks.Name = "flpAudioLinks"
        Me.flpAudioLinks.Size = New System.Drawing.Size(247, 25)
        Me.flpAudioLinks.TabIndex = 18
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(41, 10)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 8)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'llAudioEnglish
        '
        Me.llAudioEnglish.AutoSize = True
        Me.llAudioEnglish.Enabled = False
        Me.llAudioEnglish.Location = New System.Drawing.Point(108, 0)
        Me.llAudioEnglish.Name = "llAudioEnglish"
        Me.llAudioEnglish.Size = New System.Drawing.Size(68, 25)
        Me.llAudioEnglish.TabIndex = 3
        Me.llAudioEnglish.TabStop = True
        Me.llAudioEnglish.Text = "English"
        '
        'llAudioNative
        '
        Me.llAudioNative.AutoSize = True
        Me.llAudioNative.Enabled = False
        Me.llAudioNative.Location = New System.Drawing.Point(182, 0)
        Me.llAudioNative.Name = "llAudioNative"
        Me.llAudioNative.Size = New System.Drawing.Size(62, 25)
        Me.llAudioNative.TabIndex = 4
        Me.llAudioNative.TabStop = True
        Me.llAudioNative.Text = "Native"
        '
        'cbVideoStream
        '
        Me.cbVideoStream.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbVideoStream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVideoStream.FormattingEnabled = True
        Me.cbVideoStream.Location = New System.Drawing.Point(304, 13)
        Me.cbVideoStream.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbVideoStream.Name = "cbVideoStream"
        Me.cbVideoStream.Size = New System.Drawing.Size(725, 33)
        Me.cbVideoStream.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(215, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Stream:"
        '
        'tlp
        '
        Me.tlp.ColumnCount = 1
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1049.0!))
        Me.tlp.Controls.Add(Me.Panel2, 0, 3)
        Me.tlp.Controls.Add(Me.Panel1, 0, 0)
        Me.tlp.Controls.Add(Me.Panel3, 0, 5)
        Me.tlp.Controls.Add(Me.gbAudio, 0, 1)
        Me.tlp.Controls.Add(Me.gbSubtitles, 0, 2)
        Me.tlp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp.Location = New System.Drawing.Point(0, 0)
        Me.tlp.Name = "tlp"
        Me.tlp.RowCount = 6
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp.Size = New System.Drawing.Size(1049, 750)
        Me.tlp.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 652)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1049, 47)
        Me.Panel2.TabIndex = 21
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.bnBrowse, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbTempDir, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1049, 47)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 47)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Target Directory:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbVideoOutput)
        Me.Panel1.Controls.Add(Me.cbVideoStream)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 50)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bnMenu)
        Me.Panel3.Controls.Add(Me.cbChapters)
        Me.Panel3.Controls.Add(Me.bnOK)
        Me.Panel3.Controls.Add(Me.bnCancel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 702)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1043, 45)
        Me.Panel3.TabIndex = 22
        '
        'bnMenu
        '
        Me.bnMenu.ContextMenuStrip = Me.cms
        Me.bnMenu.Location = New System.Drawing.Point(792, 2)
        Me.bnMenu.ShowMenuSymbol = True
        Me.bnMenu.Size = New System.Drawing.Size(36, 36)
        '
        'cms
        '
        Me.cms.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(61, 4)
        '
        'cbChapters
        '
        Me.cbChapters.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbChapters.AutoSize = True
        Me.cbChapters.Location = New System.Drawing.Point(6, 3)
        Me.cbChapters.Name = "cbChapters"
        Me.cbChapters.Size = New System.Drawing.Size(165, 29)
        Me.cbChapters.TabIndex = 2
        Me.cbChapters.Text = "Extract Chapters"
        Me.cbChapters.UseVisualStyleBackColor = True
        Me.cbChapters.Visible = False
        '
        'gbAudio
        '
        Me.gbAudio.Controls.Add(Me.cbAudioOutput)
        Me.gbAudio.Controls.Add(Me.Label3)
        Me.gbAudio.Controls.Add(Me.Label1)
        Me.gbAudio.Controls.Add(Me.flpAudioLinks)
        Me.gbAudio.Controls.Add(Me.lvAudio)
        Me.gbAudio.Controls.Add(Me.cmdlOptions)
        Me.gbAudio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbAudio.Location = New System.Drawing.Point(3, 53)
        Me.gbAudio.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.gbAudio.Name = "gbAudio"
        Me.gbAudio.Size = New System.Drawing.Size(1043, 390)
        Me.gbAudio.TabIndex = 23
        Me.gbAudio.TabStop = False
        Me.gbAudio.Text = "Audio"
        '
        'cbAudioOutput
        '
        Me.cbAudioOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAudioOutput.FormattingEnabled = True
        Me.cbAudioOutput.Location = New System.Drawing.Point(85, 317)
        Me.cbAudioOutput.Name = "cbAudioOutput"
        Me.cbAudioOutput.Size = New System.Drawing.Size(115, 33)
        Me.cbAudioOutput.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Options:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Output:"
        '
        'gbSubtitles
        '
        Me.gbSubtitles.Controls.Add(Me.flpSubtitleLinks)
        Me.gbSubtitles.Controls.Add(Me.lvSubtitles)
        Me.gbSubtitles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbSubtitles.Location = New System.Drawing.Point(3, 449)
        Me.gbSubtitles.Name = "gbSubtitles"
        Me.gbSubtitles.Size = New System.Drawing.Size(1043, 200)
        Me.gbSubtitles.TabIndex = 24
        Me.gbSubtitles.TabStop = False
        Me.gbSubtitles.Text = "Subtitles"
        '
        'eac3toForm
        '
        Me.AcceptButton = Me.bnOK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.bnCancel
        Me.ClientSize = New System.Drawing.Size(1049, 750)
        Me.Controls.Add(Me.tlp)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "eac3toForm"
        Me.Text = "eac3to"
        Me.flpSubtitleLinks.ResumeLayout(False)
        Me.flpSubtitleLinks.PerformLayout()
        Me.flpAudioLinks.ResumeLayout(False)
        Me.flpAudioLinks.PerformLayout()
        Me.tlp.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gbAudio.ResumeLayout(False)
        Me.gbAudio.PerformLayout()
        Me.gbSubtitles.ResumeLayout(False)
        Me.gbSubtitles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Property M2TSFile As String
    Property PlaylistFolder As String
    Property OutputFolder As String
    Property PlaylistID As Integer

    Private Output As String
    Private Streams As New BindingList(Of M2TSStream)

    Sub New()
        MyBase.New()
        InitializeComponent()

        cbAudioOutput.Sorted = True
        cbAudioOutput.Items.AddRange({"m4a", "ac3", "dts", "flac", "wav", "dtsma", "dtshr", "eac3", "thd"})

        tlp.Enabled = False
        cbChapters.Checked = s.Storage.GetBool("demux Blu-ray chapters", True)

        lvAudio.View = View.Details
        lvAudio.Columns.Add("")
        lvAudio.CheckBoxes = True
        lvAudio.HeaderStyle = ColumnHeaderStyle.None
        lvAudio.ShowItemToolTips = True
        lvAudio.FullRowSelect = True
        lvAudio.MultiSelect = False
        lvAudio.SendMessageHideFocus()

        lvSubtitles.View = View.SmallIcon
        lvSubtitles.CheckBoxes = True
        lvSubtitles.HeaderStyle = ColumnHeaderStyle.None

        cmdlOptions.Presets = s.CmdlPresetsEac3to
        cmdlOptions.RestoreFunc = Function() ApplicationSettings.GetDefaultEac3toMenu.FormatColumn("=")

        If CultureInfo.CurrentCulture.TwoLetterISOLanguageName = "en" Then
            llAudioNative.Visible = False
            llSubtitlesNative.Visible = False
        Else
            Try
                llAudioNative.Text = New CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName).EnglishName
                llSubtitlesNative.Text = llAudioNative.Text
            Catch ex As Exception
                g.ShowException(ex)
                llAudioNative.Visible = False
                llSubtitlesNative.Visible = False
            End Try
        End If

        cms.Items.Add(New ActionMenuItem("Show eac3to wikibook", Sub() g.ShellExecute("http://en.wikibooks.org/wiki/Eac3to")))
        cms.Items.Add(New ActionMenuItem("Show eac3to support forum", Sub() g.ShellExecute("http://forum.doom9.org/showthread.php?t=125966")))
        cms.Items.Add(New ActionMenuItem("Execute eac3to.exe -test", Sub() g.ShellExecute("cmd.exe", "/k """ + Packs.eac3to.GetPath + """ -test")))

        ActiveControl = Nothing
    End Sub

    Sub StartAnalyze()
        Dim args = ""

        If File.Exists(M2TSFile) Then
            args = """" + M2TSFile + """ -progressnumbers"
            Log.Write("Process M2TS file using eac3to", """" + Packs.eac3to.GetPath + """ " + args + CrLf2)
        ElseIf Directory.Exists(PlaylistFolder) Then
            args = """" + PlaylistFolder + """ " & PlaylistID & ") -progressnumbers"
            Log.Write("Process playlist file using eac3to", """" + Packs.eac3to.GetPath + """ " + args + CrLf2)
        End If

        Using o As New Process
            AddHandler o.OutputDataReceived, AddressOf OutputDataReceived
            o.StartInfo.FileName = Packs.eac3to.GetPath
            o.StartInfo.Arguments = args
            o.StartInfo.CreateNoWindow = True
            o.StartInfo.UseShellExecute = False
            o.StartInfo.RedirectStandardOutput = True
            o.Start()
            o.BeginOutputReadLine()
            o.WaitForExit()

            If o.ExitCode <> 0 Then
                Invoke(Sub()
                           MsgError("eac3to failed with exit code " & o.ExitCode, Output)
                           bnCancel.PerformClick()
                       End Sub)
            Else
                Invoke(Sub() Init())
            End If
        End Using
    End Sub

    Sub OutputDataReceived(sender As Object, e As DataReceivedEventArgs)
        If Not e.Data Is Nothing Then
            BeginInvoke(Sub() Text = e.Data)

            If Not e.Data.StartsWith("analyze: ") Then
                Output += e.Data + CrLf
            End If
        End If
    End Sub

    Sub Init()
        Text = "eac3to"
        tlp.Enabled = True

        If Output <> "" Then
            Log.WriteLine(Output)

            If Output.Contains(CrLf + "   (embedded: ") Then
                Output = Output.Replace(CrLf + "   (embedded: ", "(embedded: ")
            End If

            While Output.Contains("  (embedded: ")
                Output = Output.Replace("  (embedded: ", " (embedded: ")
            End While

            If Output.Contains(CrLf + "   (core: ") Then
                Output = Output.Replace(CrLf + "   (core: ", "(core: ")
            End If

            While Output.Contains("  (core: ")
                Output = Output.Replace("  (core: ", " (core: ")
            End While

            Output = Output.Replace(" channels, ", "ch, ").Replace(" bits, ", "bits, ").Replace("dialnorm", "dn")
            Output = Output.Replace("(core: ", "(").Replace("(embedded: ", "(")

            For Each i In Output.SplitLinesNoEmpty
                Dim m = Regex.Match(i, "^(\d+): (.+)$")

                If m.Success Then
                    Dim ms As New M2TSStream
                    ms.Text = i.Trim
                    ms.ID = m.Groups(1).Value.ToInt
                    ms.Codec = m.Groups(2).Value

                    If ms.Codec.Contains(",") Then ms.Codec = ms.Codec.Left(",")

                    ms.IsVideo = {"h264/AVC", "VC-1", "MPEG2"}.Contains(ms.Codec)
                    ms.IsAudio = {"AC3", "AC3 EX", "TrueHD/AC3", "TrueHD/AC3 (Atmos)", "AC3 Surround", "RAW/PCM", "DTS Master Audio", "DTS", "DTS-ES", "DTS Hi-Res", "DTS Express", "E-AC3"}.Contains(ms.Codec)
                    ms.IsSubtitle = ms.Codec.StartsWith("Subtitle")
                    ms.IsChapters = ms.Codec.StartsWith("Chapters")

                    If ms.IsAudio OrElse ms.IsSubtitle Then
                        For Each i2 In Language.Languages
                            If ms.Text.Contains(", " + i2.CultureInfo.EnglishName) Then
                                ms.Language = i2
                                Exit For
                            End If
                        Next

                        Select Case ms.Codec
                            Case "AC3 EX", "AC3 Surround"
                                ms.OutputType = "ac3"
                            Case "TrueHD/AC3"
                                ms.OutputType = "thd"
                            Case "TrueHD/AC3 (Atmos)"
                                ms.OutputType = "ac3"
                            Case "DTS-ES", "DTS Express"
                                ms.OutputType = "dts"
                            Case "DTS Master Audio", "DTS Hi-Res"
                                If s.Storage.GetBool("eac3to hd output", False) Then
                                    Select Case ms.Codec
                                        Case "DTS Master Audio"
                                            ms.OutputType = "dtsma"
                                        Case "DTS Hi-Res"
                                            ms.OutputType = "dtshr"
                                    End Select
                                Else
                                    ms.OutputType = "dts"
                                    If ms.Text.Contains("(DTS,") Then ms.Options = "-core"
                                End If
                            Case "RAW/PCM"
                                ms.OutputType = "flac"
                            Case Else
                                ms.OutputType = ms.Codec.ToLower.Replace("-", "")
                        End Select
                    End If

                    If Not ms.IsVideo AndAlso Not ms.IsAudio AndAlso
                        Not ms.IsSubtitle AndAlso Not ms.IsChapters Then

                        Throw New Exception("Failed to detect stream: " + i)
                    End If

                    Streams.Add(ms)
                End If
            Next

            For Each i In Streams
                If i.IsAudio Then
                    i.ListViewItem = lvAudio.Items.Add(i.ToString)
                    i.ListViewItem.Tag = i

                    If i.Language.CultureInfo.TwoLetterISOLanguageName = CultureInfo.CurrentCulture.TwoLetterISOLanguageName Then
                        llAudioNative.Enabled = True
                        i.ListViewItem.Checked = True
                    ElseIf i.Language.CultureInfo.TwoLetterISOLanguageName = "en" Then
                        llAudioEnglish.Enabled = True
                        i.ListViewItem.Checked = True
                    ElseIf i.Language.TwoLetterCode = "iv" Then
                        i.ListViewItem.Checked = True
                    End If
                ElseIf i.IsVideo Then
                    cbVideoStream.Items.Add(i)
                ElseIf i.IsSubtitle Then
                    If i.Language.CultureInfo.TwoLetterISOLanguageName = CultureInfo.CurrentCulture.TwoLetterISOLanguageName Then
                        llSubtitlesNative.Enabled = True
                    ElseIf i.Language.CultureInfo.TwoLetterISOLanguageName = "en" Then
                        llSubtitlesEnglish.Enabled = True
                    End If

                    Dim lang = i.Language.ToString

                    Dim item = lvSubtitles.Items.Add(lang)
                    item.Tag = i

                    For Each i2 In p.AutoSubtitles.SplitNoEmptyAndWhiteSpace(",", ";")
                        If i2.ToLower = "all" OrElse i2.ToLower = i.Language.TwoLetterCode Then
                            item.Checked = True
                        End If
                    Next
                ElseIf i.IsChapters Then
                    cbChapters.Visible = True
                End If
            Next

            If cbVideoStream.Items.Count < 2 Then
                cbVideoStream.Enabled = False
            End If

            If cbVideoStream.Items.Count > 0 Then
                cbVideoStream.SelectedIndex = 0
            Else
                cbVideoOutput.Enabled = False
            End If

            If lvAudio.Items.Count > 0 Then
                lvAudio.Items(0).Selected = True
            Else
                gbAudio.Enabled = False
            End If

            If lvSubtitles.Items.Count = 0 Then
                lvSubtitles.Enabled = False
                flpSubtitleLinks.Enabled = False
            End If

            lvAudio.Columns(0).Width = lvAudio.ClientSize.Width
        Else
            MsgWarn("eac3to output was empty")
            bnCancel.PerformClick()
        End If
    End Sub

    Private Sub eac3toForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim hdCounter As Integer

        For Each i In Streams
            If i.Checked AndAlso i.IsAudio Then
                If {"dtsma", "dtshr"}.Contains(i.OutputType) Then
                    hdCounter += 1
                ElseIf i.OutputType = "dts" AndAlso {"DTS Master Audio", "DTS Hi-Res"}.Contains(i.Codec) Then
                    hdCounter -= 1
                End If
            End If
        Next

        s.Storage.SetBool("eac3to hd output", hdCounter > 0)
        s.CmdlPresetsEac3to = cmdlOptions.Presets

        If Not bnOK.Enabled Then e.Cancel = True

        If DialogResult = DialogResult.OK Then
            If cbVideoOutput.Text = "MKV" AndAlso Not Packs.Haali.VerifyOK(True) Then
                e.Cancel = True
            End If

            s.Storage.SetBool("demux Blu-ray chapters", cbChapters.Checked)
        End If
    End Sub

    Private Sub AddCmdlControl_PresetsChanged(presets As String) Handles cmdlOptions.PresetsChanged
        cmdlOptions.Presets = presets
    End Sub

    Private Sub eac3toForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Task.Run(AddressOf StartAnalyze)
    End Sub

    Function GetArgs(src As String, baseName As String) As String
        Dim r = src

        Dim videoStream = TryCast(cbVideoStream.SelectedItem, M2TSStream)

        If Not videoStream Is Nothing AndAlso Not cbVideoOutput.Text = "Nothing" Then
            r += " " & videoStream.ID & ": """ + OutputFolder + baseName +
                "." + cbVideoOutput.Text.ToLower + """"
        End If

        For Each i In Streams
            If i.IsAudio AndAlso i.Checked Then
                r += " " & i.ID & ": """ + OutputFolder + baseName + " ID" & i.ID

                If Not i.Language.CultureInfo Is CultureInfo.InvariantCulture Then
                    r += " " + i.Language.CultureInfo.EnglishName
                End If

                r += "." + i.OutputType + """"

                If i.Options <> "" Then r += " " + i.Options.Trim
            End If
        Next

        For Each i In Streams
            If i.IsSubtitle AndAlso i.Checked Then
                r += " " & i.ID & ": """ + OutputFolder + baseName + " ID" & i.ID

                If Not i.Language.CultureInfo Is CultureInfo.InvariantCulture Then
                    r += " " + i.Language.CultureInfo.EnglishName
                End If

                r += ".sup"""
            End If

            If i.IsChapters AndAlso cbChapters.Checked Then
                r += " " & i.ID & ": """ + OutputFolder + baseName + "_Chapters.txt"""
            End If
        Next

        Return r + " -progressnumbers"
    End Function

    Private Sub bnBrowse_Click() Handles bnBrowse.Click
        Using d As New FolderBrowserDialog
            d.Description = "Please choose a directory."
            d.SetSelectedPath(tbTempDir.Text)

            If d.ShowDialog = DialogResult.OK Then
                tbTempDir.Text = d.SelectedPath
            End If
        End Using
    End Sub

    Private Sub tbTempDir_TextChanged(sender As Object, e As EventArgs) Handles tbTempDir.TextChanged
        OutputFolder = DirPath.AppendSeparator(tbTempDir.Text)
    End Sub

    Private Sub lvSubtitles_Click(sender As Object, e As EventArgs) Handles lvSubtitles.Click
        Dim pos = lvSubtitles.ClientMousePos
        Dim item = lvSubtitles.GetItemAt(pos.X, pos.Y)

        If Not item Is Nothing Then
            Dim b = item.GetBounds(ItemBoundsPortion.Entire)

            If pos.X > b.Left + b.Height Then
                item.Checked = Not item.Checked
            End If
        End If
    End Sub

    Private Sub lvSubtitles_ItemCheck(sender As Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles lvSubtitles.ItemCheck
        DirectCast(lvSubtitles.Items(e.Index).Tag, M2TSStream).Checked = e.NewValue = CheckState.Checked
    End Sub

    Private Sub llAudioAll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAudioAll.LinkClicked
        For Each i As ListViewItem In lvAudio.Items
            i.Checked = True
        Next
    End Sub

    Private Sub llAudioNone_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAudioNone.LinkClicked
        For Each i As ListViewItem In lvAudio.Items
            i.Checked = False
        Next
    End Sub

    Private Sub llAudioEnglish_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAudioEnglish.LinkClicked
        For Each i As ListViewItem In lvAudio.Items
            Dim stream = DirectCast(i.Tag, M2TSStream)

            If stream.Language.TwoLetterCode = "en" Then
                i.Checked = True
            End If
        Next
    End Sub

    Private Sub llAudioNative_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAudioNative.LinkClicked
        For Each i As ListViewItem In lvAudio.Items
            Dim stream = DirectCast(i.Tag, M2TSStream)

            If stream.Language.TwoLetterCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName Then
                i.Checked = True
            End If
        Next
    End Sub

    Private Sub llSubtitlesAll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSubtitlesAll.LinkClicked
        For Each i As ListViewItem In lvSubtitles.Items
            i.Checked = True
        Next
    End Sub

    Private Sub llSubtitlesNone_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSubtitlesNone.LinkClicked
        For Each i As ListViewItem In lvSubtitles.Items
            i.Checked = False
        Next
    End Sub

    Private Sub llSubtitlesEnglish_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSubtitlesEnglish.LinkClicked
        For Each i As ListViewItem In lvSubtitles.Items
            Dim stream = DirectCast(i.Tag, M2TSStream)

            If stream.Language.TwoLetterCode = "en" Then
                i.Checked = True
            End If
        Next
    End Sub

    Private Sub llSubtitlesNative_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSubtitlesNative.LinkClicked
        For Each i As ListViewItem In lvSubtitles.Items
            Dim stream = DirectCast(i.Tag, M2TSStream)

            If stream.Language.TwoLetterCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName Then
                i.Checked = True
            End If
        Next
    End Sub

    Private Sub cbVideoStream_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVideoStream.SelectedIndexChanged
        cbVideoOutput.Items.Clear()
        cbVideoOutput.Items.Add("Nothing")
        cbVideoOutput.Enabled = True

        Dim stream = TryCast(cbVideoStream.SelectedItem, M2TSStream)

        Select Case stream.Codec
            Case "h264/AVC"
                cbVideoOutput.Items.Add("H264")
                cbVideoOutput.Items.Add("MKV")
                cbVideoOutput.Text = If(M2TSFile = "", "MKV", "Nothing")
            Case "VC-1"
                cbVideoOutput.Items.Add("MKV")
                cbVideoOutput.Text = If(M2TSFile = "", "MKV", "Nothing")
            Case "MPEG2"
                cbVideoOutput.Items.Add("M2V")
                cbVideoOutput.Items.Add("MKV")
                cbVideoOutput.Text = If(M2TSFile = "", "M2V", "Nothing")
        End Select
    End Sub

    Private Sub cbAudioOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAudioOutput.SelectedIndexChanged
        If Not cbAudioOutput.SelectedItem Is Nothing AndAlso Not GetSelectedStream() Is Nothing Then
            Dim ms = GetSelectedStream()
            ms.OutputType = cbAudioOutput.SelectedItem.ToString
            ms.ListViewItem.Text = ms.ToString

            If ms.OutputType = "dts" AndAlso {"DTS Master Audio", "DTS Hi-Res"}.Contains(ms.Codec) AndAlso Not ms.Options.Contains("-core") Then
                If ms.Options = "" Then ms.Options = "-core"
                ms.UpdateListViewItem()
                cmdlOptions.tb.Text = ms.Options
            ElseIf {"dtsma", "dtshr"}.Contains(ms.OutputType) AndAlso ms.Options.Contains("-core") Then
                ms.Options = ms.Options.Replace(" -core ", "").Replace(" -core", "").Replace("-core ", "").Replace("-core", "")
                ms.UpdateListViewItem()
                cmdlOptions.tb.Text = ms.Options
            End If
        End If
    End Sub

    Private Sub cmdlOptions_ValueChanged(value As String) Handles cmdlOptions.ValueChanged
        If cmdlOptions.tb.Focused OrElse cmdlOptions.bu.Focused Then
            Dim ms = GetSelectedStream()

            If Not ms Is Nothing Then
                ms.Options = value

                If ms.Options <> "" Then
                    ms.ListViewItem.Checked = True
                End If

                If ms.Options = "-core" AndAlso ms.Codec.StartsWith("DTS") Then
                    cbAudioOutput.SelectedItem = "dts"
                End If

                If ms.Options.Contains("-quality=") Then
                    cbAudioOutput.SelectedItem = "m4a"
                End If

                lvAudio.SelectedItems(0).Text = ms.ToString
            End If
        End If
    End Sub

    Private Sub lvAudio_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvAudio.ItemCheck
        DirectCast(lvAudio.Items(e.Index).Tag, M2TSStream).Checked = e.NewValue = CheckState.Checked
    End Sub

    Function GetSelectedStream() As M2TSStream
        If lvAudio.SelectedItems.Count > 0 Then Return DirectCast(lvAudio.SelectedItems(0).Tag, M2TSStream)
    End Function

    Private Sub lvAudio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvAudio.SelectedIndexChanged
        Dim ms = GetSelectedStream()

        If Not ms Is Nothing Then
            cmdlOptions.tb.Text = ms.Options
            cbAudioOutput.Items.Clear()
            cbAudioOutput.Items.AddRange(GetAudioOutputFormatList(ms.Codec))
            cbAudioOutput.SelectedItem = ms.OutputType
        End If
    End Sub

    Function GetAudioOutputFormatList(codec As String) As String()
        Select Case codec
            Case "TrueHD/AC3", "TrueHD/AC3 (Atmos)"
                Return {"thd", "ac3", "thd+ac3", "wav", "flac", "m4a"}
            Case "DTS", "DTS-ES", "DTS Express"
                Return {"dts", "ac3", "wav", "flac", "m4a"}
            Case "DTS Master Audio"
                Return {"dtsma", "dts", "ac3", "wav", "flac", "m4a"}
            Case "DTS Hi-Res"
                Return {"dtshr", "dts", "ac3", "wav", "flac", "m4a"}
            Case "RAW/PCM"
                Return {"ac3", "wav", "flac", "m4a"}
            Case "E-AC3"
                Return {"eac3", "ac3", "wav", "flac", "m4a"}
            Case Else
                Return {"ac3", "wav", "flac", "m4a"}
        End Select
    End Function
End Class