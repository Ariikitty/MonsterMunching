Public Class Game
    Private intMonsterVelX As Integer = 0
    Private intMonsterVelY As Integer = 0
    Private intMonsterVelMax As Integer = 7
    ' Runs on every frame of the game
    Private Sub TmrGameLoop_Tick(sender As Object, e As EventArgs) Handles tmrGameLoop.Tick
        Call MoveMonster()
        Call PlayerHitsHealth()
        Call MonsterHitsPlayer()
    End Sub
    ' Handels the player's motion
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        picPlayer.Left = e.X - picPlayer.Width / 2
        picPlayer.Top = e.Y - picPlayer.Height / 2
    End Sub
    ' Handels acceleration and motion of the monster
    Private Sub MoveMonster()
        ' Accelerates the monster on the X plane
        If picMonster.Left < picPlayer.Left Then
            If intMonsterVelX < intMonsterVelMax Then
                intMonsterVelX += 1
            End If
        Else
            If intMonsterVelX > -intMonsterVelMax Then
                intMonsterVelX -= 1
            End If
        End If
        ' Accelerates the monster on the Y plane
        If picMonster.Top < picPlayer.Top Then
            If intMonsterVelY < intMonsterVelMax Then
                intMonsterVelY += 1
            End If
        Else
            If intMonsterVelY > -intMonsterVelMax Then
                intMonsterVelY -= 1
            End If
        End If
        ' Moves the monster
        picMonster.Left += intMonsterVelX
        picMonster.Top += intMonsterVelY
    End Sub
    ' Handles collision between player and monster
    Private Sub MonsterHitsPlayer()
        If picPlayer.Bounds.IntersectsWith(picMonster.Bounds) Then
            Me.BackColor = Color.Black
            If prgHealth.Value - 2 < 0 Then
                prgHealth.Value = 0
                tmrGameLoop.Enabled = False
                MsgBox("Ya got munched son!!")
            Else
                prgHealth.Value -= 2
            End If
        End If
    End Sub
    ' Handles the recovery of the player's health
    Private Sub PlayerHitsHealth()
        If picPlayer.Bounds.IntersectsWith(picHealth.Bounds) Then
            Me.BackColor = Color.Yellow
            If prgHealth.Value + 1 > 100 Then
                prgHealth.Value = 100
            Else
                prgHealth.Value += 1
            End If
        Else
            Me.BackColor = Color.White
        End If
    End Sub
End Class
