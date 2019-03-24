
Module mdlHighScore
        'Declare Public Variables
        Public intrandomNumberSales As Integer 'To hold the random number generated
        Public intOldHighScoreSales As Integer = 327 'To hold the static variable 327 and the most recent score being compared
        Public intMyScoreSales As Integer 'To hold random number for comparison
        Public strResultSales As String 'Declare Variable to determine result message
        Public intrandomNumberWholesale As Integer 'To hold the random number generated
        Public intOldHighScoreWholesale As Integer = 327 'To hold the static variable 327 and the most recent score being compared


        Public intMyScoreWholesale As Integer 'To hold random number for comparison
        Public strResultWholesale As String 'Declare Variable to determine result message

        'New Function to creat random scores between 0 and 1000
        Public Function HighScoreSales()
            Randomize()
            intrandomNumberSales = Int(Rnd() * 1001) + 1
            intMyScoreSales = intrandomNumberSales

            'Compare new random number to static variable 327 and to old high score
            If intMyScoreSales > intOldHighScoreSales Then
                intOldHighScoreSales = intMyScoreSales
                'Result message if a new high score is reached
                strResultSales = ("New High Score")
                'Result message if new result is not a new high score
            Else strResultSales = ("This is not a new high score")
            End If

            'Return Function to Form1
            HighScoreSales = intOldHighScoreSales

        End Function
        Public Function HighScoreWholesale()
            Randomize()
            intrandomNumberWholesale = Int(Rnd() * 1001) + 1
            intMyScoreWholesale = intrandomNumberWholesale

            'Compare new random number to static variable 327 and to old high score
            If intMyScoreWholesale > intOldHighScoreWholesale Then
                intOldHighScoreWholesale = intMyScoreWholesale
                'Result message if a new high score is reached
                strResultWholesale = ("New High Score")
                'Result message if new result is not a new high score
            Else strResultWholesale = ("This is not a new high score")
            End If

            'Return Function to Form1
            HighScoreWholesale = intOldHighScoreWholesale

        End Function
    End Module

