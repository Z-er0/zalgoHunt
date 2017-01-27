Public Class frmShoppe
    Private Sub btnBuy1_Click(sender As Object, e As EventArgs) Handles btnBuy1.Click
        shopPrice = 10
        If shopPrice > slain Then
            MessageBox.Show("
I̪̲̩͎̣̥͚̬̦̠̮̤̞ͧ̉̈ͫ̆̓̓̅ͅn̯͔̱͔͙̰̩͚͈̭̝̞̟͇̜̞̗̗̫̑̿̏̓̾s̟͕͉̫͉ͩ̀̌̎̏̈ͩͩ͛͌ͣ̉̚u͉̯̲̠͕͈̫̯̮ͧͩ͂̾̋ͪ͊͛͛ͦ̋̌ͨͣ͐̎͑̋f̬̺͈̣͈̣̲͚̆͛͑͑ͩ̋̓̆ͪͫ̎f̯̮̖̰͓ͩ̋̌̌̓ͅĭ̞̗͈͓̠͔͍͍̹͈̹̳̭̮̱͊̐̄ͮc̼͈͓͍͇̪̼͓̄ͣ̈̃í̖̯̘͍̳̥̗͕̣̞̯̯̙̖̥̣͕̒ͥ̅ͧ̉̑̃̊ͨe̖̩͎̝͕͓̻̦̼ͧ͌͗͆̓̑͒̋͂ͮ͑n̤̝̲̺̘̲̍̾̍ͬͥ̀ͯ͋͛ͨͦ̇̈́̽̚̚t̜̬̘͙̜̲̺̺̙͕̯̯͙͓ͤ͒͐̄̔͂̉̽̔́̇͌ͯ̚ ̘͕̜̖̲̗͚̥̟̬̗̱̹̗̺̩̯͐ͩͣͮͥ͛̑ͦ̋S̝̝̤̮͉̦̟̱̘̎̍ͥ͌̑̍̐ͫͨ͒̇̌̅̂ͮ̂ͅo̝̣̠̦̰̟̟̻͎͎ͨͯ̈̄ͪͫu͔͕͉̘͙͍̲̝̳̳̥͚̗̾̐̑ͩ̈́̀̏̽̑̇̿̍̐͛ͅl͖̘͔̲͕̠͔͉͕̤̈́ͭ͗̿ͫ̒ͯ̈́͌ͪ̾̐͗ͯͦ̚s͕̤̲̦̹͎͖̱̗̗̩̩͎͇̹̖̋ͤ̾ͥ͋̎͗͊ͅ")
        Else
            slain -= shopPrice
            shopMunitions += 1
            Me.lblMunitions.Text = totalMunitions
            Me.lblShopSouls.Text = slain
        End If
    End Sub

    Private Sub btnBuy2_Click(sender As Object, e As EventArgs) Handles btnBuy2.Click
        shopPrice = 15
        If shopPrice > slain Then
            MessageBox.Show("
I̪̲̩͎̣̥͚̬̦̠̮̤̞ͧ̉̈ͫ̆̓̓̅ͅn̯͔̱͔͙̰̩͚͈̭̝̞̟͇̜̞̗̗̫̑̿̏̓̾s̟͕͉̫͉ͩ̀̌̎̏̈ͩͩ͛͌ͣ̉̚u͉̯̲̠͕͈̫̯̮ͧͩ͂̾̋ͪ͊͛͛ͦ̋̌ͨͣ͐̎͑̋f̬̺͈̣͈̣̲͚̆͛͑͑ͩ̋̓̆ͪͫ̎f̯̮̖̰͓ͩ̋̌̌̓ͅĭ̞̗͈͓̠͔͍͍̹͈̹̳̭̮̱͊̐̄ͮc̼͈͓͍͇̪̼͓̄ͣ̈̃í̖̯̘͍̳̥̗͕̣̞̯̯̙̖̥̣͕̒ͥ̅ͧ̉̑̃̊ͨe̖̩͎̝͕͓̻̦̼ͧ͌͗͆̓̑͒̋͂ͮ͑n̤̝̲̺̘̲̍̾̍ͬͥ̀ͯ͋͛ͨͦ̇̈́̽̚̚t̜̬̘͙̜̲̺̺̙͕̯̯͙͓ͤ͒͐̄̔͂̉̽̔́̇͌ͯ̚ ̘͕̜̖̲̗͚̥̟̬̗̱̹̗̺̩̯͐ͩͣͮͥ͛̑ͦ̋S̝̝̤̮͉̦̟̱̘̎̍ͥ͌̑̍̐ͫͨ͒̇̌̅̂ͮ̂ͅo̝̣̠̦̰̟̟̻͎͎ͨͯ̈̄ͪͫu͔͕͉̘͙͍̲̝̳̳̥͚̗̾̐̑ͩ̈́̀̏̽̑̇̿̍̐͛ͅl͖̘͔̲͕̠͔͉͕̤̈́ͭ͗̿ͫ̒ͯ̈́͌ͪ̾̐͗ͯͦ̚s͕̤̲̦̹͎͖̱̗̗̩̩͎͇̹̖̋ͤ̾ͥ͋̎͗͊ͅ")
        Else
            slain -= shopPrice
            shopTime += 1
            Me.lblTime.Text = totalTime
            Me.lblShopSouls.Text = slain
        End If
    End Sub

    Private Sub frmShoppe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblShopSouls.Text = slain
        lblMunitions.Text = totalMunitions
        lblTime.Text = totalTime
    End Sub
End Class