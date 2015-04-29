' Test 6
' Retrouver un bouton de menu à partir d'un de ses attributs (notamment .Caption, .Tag, .Parameter)

Private Sub startLodelMenu()
    Dim menuBar As CommandBar
    Dim menuItem As CommandBarControl

    Set menuBar = CommandBars.Add(menuBar:=False, Position:=msoBarTop, Name:="testbar", Temporary:=True)
    menuBar.Visible = True

    Set menuItem = menuBar.Controls.Add(Type:=msoControlButton)
    With menuItem
        .caption = "test"
        .OnAction = "StartRevuesOrgDefault"
        .Style = msoButtonCaption
        .Tag = "unTagPourLetest"
    End With
End Sub


Sub ShowShortcutMenuItems()
  Dim lodelStylesBar As CommandBar
  Dim Ctl As CommandBarControl
  Application.ScreenUpdating = False
  For Each lodelStylesBar In Application.CommandBars
    If lodelStylesBar.Name = "testbar" Then
      For Each Ctl In lodelStylesBar.Controls
          Debug.Print Ctl.caption
          Debug.Print Ctl.Tag
     Next Ctl
   End If
  Next lodelStylesBar
End Sub

Sub test()
    Call startLodelMenu
    Call ShowShortcutMenuItems
End Sub


Sub UneAutreMethode()
    Dim Ctl As CommandBarControl
    Call startLodelMenu
    Set Ctl = CommandBars.FindControl(Tag:="unTagPourLetest")
    Debug.Print Ctl.caption
    Debug.Print Ctl.Tag
End Sub
