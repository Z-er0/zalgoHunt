'Background retrieved from http://www.shunvmall.com/data/out/54/47409164-cthulhu-wallpaper.jpg
Public Class frmZalgoHunt 'Zalgo Hunt game is available to play on this form

    Public Sub reloadHit()
        If totalMunitions <= 0 Then
            tmrReload.Enabled = True
            reload = 5
        Else
            totalMunitions -= 1
            lblMunitions.Text = totalMunitions

        End If
    End Sub


    Private Sub tmrCthuluMovement_Tick(sender As Object, e As EventArgs) Handles tmrCthulhuMovement.Tick
        If picLesser1.Left >= 832 Then
            picLesser1.Left = 0
            picLesser1.Top = random.Next(0, 340)
        Else
            picLesser1.Left += random.Next(1, 7)
        End If
        If picLesser2.Left >= 832 Then
            picLesser2.Left = 0
            picLesser2.Top = random.Next(0, 340)
        Else
            picLesser2.Left += random.Next(1, 7)
        End If
        If picLesser3.Left >= 832 Then
            picLesser3.Left = 0
            picLesser3.Top = random.Next(0, 340)
        Else
            picLesser3.Left += random.Next(1, 7)
        End If
        If picLesser4.Left <= 0 Then
            picLesser4.Left = 847
            picLesser4.Top = random.Next(0, 340)
        Else
            picLesser4.Left -= random.Next(1, 7)
        End If
        If picLesser5.Left <= 0 Then
            picLesser5.Left = 847
            picLesser5.Top = random.Next(0, 340)
        Else
            picLesser5.Left -= random.Next(1, 7)
        End If
        If picLesser6.Left <= 0 Then
            picLesser6.Left = 847
            picLesser6.Top = random.Next(0, 340)
        Else
            picLesser6.Left -= random.Next(1, 7)
        End If
    End Sub

    Private Sub frmZalgoHunt_Click(sender As Object, e As EventArgs) Handles Me.Click
        If munitions <= 0 Then
            tmrReload.Enabled = True
            reload = 5
            shootOrNah = True
        Else
            munitions -= 1
            lblMunitions.Text = munitions

        End If
        '------------------------------------------------------------------------------
        If Not shootOrNah Then
            attempts += 1
            lblAttempts.Text = attempts
            If souls <= 0 Then
                MessageBox.Show("Y̤̭̻̫̱͕̦̳͙̹̟͉̖͇̱ͧ̋̑ͫ̈̏ͬ̄̑̽̇̃́̾ͣ̃ͅo̗̖̫̣̥͙͖̝̣̙̠̹͎͈͇̱ͭ̏͑͂̈́ͧ̄̄͗u̖̺̻̠͎͎̪̔ͯ̂ͩ̋͗̓̇͌̿̽͂ͥ̄̚ ̠͔̪͓͉͖̟̩͈͙̟̖̂̓ͣ̉̾̍ẖ̘͔̦̫͙͈͈̤̱̞̠͚̜̩̪̋͑̏͌̓̄̽̐̔̋̃̓ͤ̀͂̉͊̅ͅã͉̙̺̰̝̖̙̼̘͈̗̝͔̦̼̠͖̙͒͒͛̅ͬv͍̯̩̳͔̆̍͌́̉ͧͧ̔̿̉ͅͅe̮̖̫̹͕̳͓͈̜̝͚̟̬̫̜̠̩̝̅̐ͨ̌ͮ̎͋̊̄ͧ̈̂̆̚ ͇̤̠ͣ̓̆͛̒ͫ̉n̜͔͔͖̠͓͉̼̭͙̪ͣ̀̊̽̃̑͊̑͌ͦͯ̎ͨ͌̚o̘̖͖̟̥͂ͪ͒̓̋͂͂̐͑̍̓ ̠̘̲̖̙̤̥͙͖̣̹̩̆́ͭͨ̈̚m̥̲͍̲̫̞͍͓͕̤̻̻̩͓͕̏ͧ̈́́̐o̱̭̰̱̦̝̰̥̩ͮ͗̉̈́̔͊̽͂̈ͩ̐͂̾͒͛ͪr̖͓̜͙̂ͣ̑̔ͬ̊ͦ̐̚e̲̜͎̟̹̪͍̟̭̦̟̘̘͍̟̖͍̻ͩ͐ͩͧ̇̈́ͤ̇ͭ̑ ̳͕͇̣͓̺̇̽̑ͤ̒̀ͣͪͮͬ̍ͧ̑͗ͩ̃̂s͓̗̱̦̑̒ͤ̂͌ͦͬo̱̩̱̺͕͓̹͓̜̝͕̘̰̝͍̊̎ͣͪͨ̎͌̑ͧ͂̓͌͊͗̒̓͐ͅu̫̱͍̲̥̎͛ͦͨ͂ͯ̀l̰͚̺͉̝͖̰̯̳̻͈͚̖͔̼̦̾̑͋ͥͪ̀s̜͙̰͎̙̻̲̣̥̝̥̮̉̆ͨͬ̓͊̐ ̟̖̭̦͉̜͛͆͐̑͒ͨͪ̊͆̆f͎̞͓̼̟̻̗̱͓͍͙̎̽͛̂͐͌ͤ͂͋̎ͬͩ̚ō͖̘̙̫̫̤̖̥̮̟͙̭̱͕̮̰̥̞̫̂̋̄́ͮͬ͑ͯ͗̈r̪̩̪̦͌ͥ̍̓ ̜͈͖̲̦̼͓̰̝̯̟̬̳̱̫̫̺̩ͫ̒͐̋̈́̃̔͑̐m͉̺̘̣͉̱̹͕̰̑̊͊ͯͭͩ́̒̍͊ͅĕ̳̳͖̠̬̜̲̠͉̣̣̮͈͎ͬ̿̇̈́͑̏ͭ̊̏̾̃̄ͣ͑ ͙̲̦͈͖̬̟̩͓̱̜̭̭̭͓̩͙ͩ͐̋̓̑̚ͅt̼͎͉͎̠̣͚̮̗͉̹̞̯̞̳̻̱̀̐̾̀̈́̓̽ͪ͛ͥ̓ͮ̒͗̐ͯ̚ͅo͇̤̬͚̪͔̞̦̭͔̹̺̗̻̗̟̺ͨ̿͆͆ͅ ̬̻͙̺̲̜̳̬͔̘̽̄̚c͇̟͇̭̜̝͙͍̹̞̥̰̰͉̹̼̤̖ͯ̿ͫ́͆͐̎̈́̉̓̚ͅō͔̝͔̟̼̰͎̜̬͍͈̲̔͗̀ͭ̌͗͒ͭ̋̊̑͋́̓n̦̝͎̖̼̩̥͔̙͚̖̹͈̠̗̗̳̖ͫ̆̃̃̓̌͑̆ͯ́̿ͦ͐̀ͦ̒̃ͅs̞̬͉̼̈́̒͋͐̓ͭ͑̎u̖̘̫̰̺̥͔̣̞͎͋̽̔̃ͭͣ̅͂̈́́̽̓͗́̚ͅͅm̥̫̠̰̩͐ͩ̿̒̔ͭ̒̌́̒ͥ͂ͅê̮͔͓̞͖͉̱̮̥̠̭͈̼̱̳̇̒̉͑̅ͯ,̟̬͉̪̝̳̰̹͉̲̲̠̰̬̊̑̑̇̋͒͋ͫͯ͊ͩ̀ ̜̥̰̩̑͆̈́ͨ͊̂͋͌̾̅̓ͯb̘̪̜͍̩̳̣̗̲ͤ̋ͩ̓ͣ̀̔̒͊̅͊̐̄͋ͮ̆̉ẹ̬̣͙͕̫͎̞̦̱̗̙̯̥̱̯ͮͩ̋͆ͬ̇̓ͤ ̦̩̖̪̠̩̠̥̺̫̠͌ͫ̃̂͛̽ͅͅḡ̞̞͙̗̭͖̞̫͌̉̅̃̎̏ͩͯͧͮ͌̓̇ͬ̐ö̦͚̦̘̦̲̥͙́ͫ̌̉̓̀́͑͛̆ͦͭͯͅn̫̯̜͈̹͈̝͔̰ͪͨ̀ͤ͑̓͊̎̈́ͣ̋̃̇̒̄̑̚e̤̳̳̰͙̺̫̤̹̪̰ͩ̂ͨ͑̚ ̰̦͓̰̟̠̭͚͉̝̹̪̝ͥ̒̚f͇̱̲̰̥͎̠̮̟̤͍̣͕͔̟̥̪̗̈́̏̓ͭ̏ͪ̽ͥͯo̬̖̟̫̬̦̻͎̬̖̬̠̲͙ͪ͊ͤ̒̐͂ͣͥ̒ő͇̱̭̻̣̬̹͙̭̆̐͛̉̓̊ͦͥ̈ͬ͑ͫͧl̖̭̝͓̲̣͓̬͌ͩ̎̓̑ị̹̘̗̯̟͍̲̪̖͖͎̦ͬ̿ͩ̍ͣͥ̆ͣͮͮͧ̓̚̚ͅͅs͕̪̭̙͇̪̪̭͔̣̘͍̞̗͓͉̓̽̌̿ͩͤ̾͐̽̅̈̀ͥͯ̎ͣ̐h̟̖̦̟̰͓͎̠̳̻͙̥͓̠̘̭̘͌ͭ͑̀͒̊̓ͣ͌͗͒̅̏̂̑ ͓̫͕̻̣̞̣̯͓̭̽ͬ̈̿̆̆̏̓͋ͣ̀m̳̖̭̙̰̙̯̫̞̳͓̳̠̩͔͈̞̯͆̒́̌͑ͯ̀ͩ̿ͮ̈̽ͪͦ̚o̫̱͓̭̺͛͛ͭ̊͗ͪ͊͛ͧ̓̍̐͋̓̚r̻̲̥͉̹̜͇͍̿͑͐̿ͪ̎ͪ̄̌̄̄ͪ̀̍͊͆t̫̗̜̱́ͮ͂ͩḁ̼͇̺̟̞̣̫̅ͮ̒̽l̺͙̜͖̞ͪͯ͆ͪ̏̿͛̎̉̏̓̏͌͂̌ͅ")
                Hide()
                frmTitle.Show()
            Else
                souls -= 1
                lblSouls.Text = souls
            End If
        End If
    End Sub

    Private Sub tmrReload_Tick(sender As Object, e As EventArgs) Handles tmrReload.Tick
        If reload = 0 Then
            totalMunitions = munitions + shopMunitions
            lblMunitions.Text = totalMunitions
            tmrReload.Enabled = False
            shootOrNah = False
        Else
            reload -= 0.1
            lblReload.Text = reload
        End If
    End Sub

    Private Sub picLesser1_Click(sender As Object, e As EventArgs) Handles picLesser1.Click
        If Not shootOrNah Then
            slain += 1
            lblSlain.Text = slain
            picLesser1.Left = -35
            reloadHit()
        End If
    End Sub

    Private Sub picLesser2_Click(sender As Object, e As EventArgs) Handles picLesser2.Click
        If Not shootOrNah Then
            slain += 1
            lblSlain.Text = slain
            picLesser2.Left = -35
            reloadHit()
        End If
    End Sub

    Private Sub picLesser3_Click(sender As Object, e As EventArgs) Handles picLesser3.Click
        If Not shootOrNah Then
            slain += 1
            lblSlain.Text = slain
            picLesser3.Left = -35
            reloadHit()
        End If
    End Sub

    Private Sub picLesser4_Click(sender As Object, e As EventArgs) Handles picLesser4.Click
        If Not shootOrNah Then
            slain += 1
            lblSlain.Text = slain
            picLesser4.Left = 882
            reloadHit()
        End If
    End Sub

    Private Sub picLesser5_Click(sender As Object, e As EventArgs) Handles picLesser5.Click
        If Not shootOrNah Then
            slain += 1
            lblSlain.Text = slain
            picLesser5.Left = 882
            reloadHit()
        End If
    End Sub

    Private Sub picLesser6_Click(sender As Object, e As EventArgs) Handles picLesser6.Click
        If Not shootOrNah Then
            slain += 1
            lblSlain.Text = slain
            picLesser6.Left = 882
            reloadHit()
        End If
    End Sub

    Private Sub tmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
        If totalTime <= 0 Then
            Hide()
            frmTitle.Show()
        Else
            totalTime -= 1
            lblTimeLeft.Text = totalTime
        End If
    End Sub
End Class