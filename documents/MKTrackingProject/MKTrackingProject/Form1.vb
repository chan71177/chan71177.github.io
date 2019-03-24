'Allow the use of the StreamWriter
Imports System.IO
Public Class MKTracking
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Password.Hide()

    End Sub
    'Changes Tab on click
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles Home.Click
    End Sub
    'Display drop down list selection : consultant name
    Private Sub consultName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstConsultName.SelectedIndexChanged
        lblConsultantFullName.Text = "Welcome " & LstConsultName.Text
    End Sub
    'display drop down list selection : Directors name
    Private Sub directorName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstConsultName.SelectedIndexChanged
        directorContact.Text = lstDirectorName.Text
    End Sub
    'Contest Prize descriptions displayed when picture is clicked
    Private Sub picBee_Click(sender As Object, e As EventArgs) Handles picBee.Click
        lblContestRules.Show()
        lblContestRules.Text = "BEE CONTEST RULES:
-  Report to your Director any combination of sales $400 or more in 1 week..

RECEIVE WONDERFUL BEE CHARM"
    End Sub
    'Contest Prize descriptions displayed when picture is clicked
    Private Sub picStar_Click(sender As Object, e As EventArgs) Handles picStar.Click
        lblContestRules.Show()
        lblContestRules.Text = "STAR CONSULTANT RULES:
Vitiosum est enim in dividendo partem in genere numerare. Cur ipse Pythagoras et Aegyptum lustravit et Persarum magos adiit?

    Nunc reliqua videamus, nisi aut ad haec, Cato, dicere aliquid vis aut nos iam longiores sumus.
    Piso, familiaris noster, et alia multa et hoc loco Stoicos irridebat: Quid enim?
    Iam id ipsum absurdum, maximum malum neglegi.
    Idemne, quod iucunde?"

    End Sub
    'Contest Prize descriptions displayed when picture is clicked
    Private Sub picBracelet_Click(sender As Object, e As EventArgs) Handles picBracelet.Click
        lblContestRules.Show()
        lblContestRules.Text = "BRACELET CONTEST RULES:
-Place cumlative orders of $600 Or more in one calendar month
RECEIVE MONTHLY BRACELET"
    End Sub
    'Contest Prize descriptions displayed when picture is clicked
    Private Sub picCar_Click(sender As Object, e As EventArgs) Handles picCar.Click
        lblContestRules.Show()
        lblContestRules.Text = " CAREER CAR RULES:
Non igitur bene:
    Sit hoc ultimum bonorum, quod nunc a me defenditur;
Quid vero:
    Quo invento omnis ab eo quasi capite de summo bono et malo disputatio ducitur.

Si est nihil nisi corpus, summa erunt illa: valitudo, vacuitas doloris, pulchritudo, cetera. Servari enim iustitia nisi a forti viro, nisi a sapiente non potest. His singulis copiose responderi solet, sed quae perspicua sunt longa esse non debent. Hoc enim constituto in philosophia constituta sunt omnia. Prioris generis est docilitas, memoria; Omnes enim iucundum motum, quo sensus hilaretur. "
    End Sub
    'Will generate the concatenated string of "space dash space"
    Private Sub btnShowNewProduct_Click(sender As Object, e As EventArgs) Handles btnShowNewProduct.Click

        'Constants
        Const intNewProduct As Integer = 5

        'Variables
        Dim strProductName 'New Product Name
        Dim strProductType 'New Product Type
        Dim strProductLine 'New Product Category
        Dim strProductPrice 'New Product Price
        Dim strProductDescription 'New Product Description
        Dim newproduct As StreamReader 'StreamWriter object variable
        Dim intNumNewProd As Integer 'Product number loop counter

        'Open the file
        Try
            newproduct = File.OpenText("C:\Users\Chandra\OneDrive\~School\~Spring 2018\VB.Net\~Project3\newproduct.txt")
            'Get Data from the file
            For intNumNewProd = 1 To intNewProduct
                'New product information
                strProductName = newproduct.ReadLine()
                strProductType = newproduct.ReadLine()
                strProductLine = newproduct.ReadLine()
                strProductPrice = newproduct.ReadLine()
                strProductDescription = newproduct.ReadLine()

                'Display the data from the file
                lstNewProduct.Items.Add("Product Number " & vbTab & intNumNewProd.ToString())
                lstNewProduct.Items.Add("Product: " & vbTab & vbTab & strProductName)
                lstNewProduct.Items.Add("Type: " & vbTab & vbTab & strProductType)
                lstNewProduct.Items.Add("Product Line: " & vbTab & strProductLine)
                lstNewProduct.Items.Add("Price: " & vbTab & vbTab & strProductPrice)
                lstNewProduct.Items.Add("Description: " & vbTab & strProductDescription)
                lstNewProduct.Items.Add("") 'Add a blank line to seperate
            Next

            'Close the file
            newproduct.Close()
        Catch
        End Try
    End Sub
    'Clear the items you have saved in the unsaved list displayed on the screen
    Private Sub btnNewProductClear_Click(sender As Object, e As EventArgs) Handles btnNewProductClear.Click
        'Clear the list box
        lstNewProduct.Items.Clear()
        lblQuickNewProduct.Text = ""
    End Sub
    'Verify new random number against default value or previous high score
    Public Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompareSales.Click
        'Insert High Score and Random Number information from Module into the Form
        lblUnitHighScoreSales.Text = HighScoreSales()
        lblRandomNumberSales.Text = intMyScoreSales.ToString
        lblResultSales.Text = strResultSales
    End Sub
    'Clear all of the scores in the text boxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all text boxes in the tab for high scores
        lblUnitHighScoreSales.Text = ""
        lblRandomNumberSales.Text = ""
        lblResultSales.Text = ""
        lblUnitHighScoreWholesale.Text = ""
        lblRandomNumberWholesale.Text = ""
        lblResultWholesale.Text = ""

    End Sub
    'Verify new random number against default value or previous high score
    Public Sub btnCompareWholesale_Click(sender As Object, e As EventArgs) Handles btnCompareWholesale.Click
        'Insert High Score and Random Number information from Module into the Form
        lblUnitHighScoreWholesale.Text = HighScoreWholesale()
        lblRandomNumberWholesale.Text = intMyScoreWholesale.ToString
        lblResultWholesale.Text = strResultWholesale
    End Sub
    'Concatenate items together with format "space dash space"
    Private Sub btnQuickView_Click(sender As Object, e As EventArgs) Handles btnQuickView.Click
        Dim newproduct As StreamReader 'StreamWriter object variable
        Dim prod1 As String 'Variable to hold specific line data from text file
        Dim prod2 As String 'Variable to hold specific line data from text file
        Dim prod3 As String 'Variable to hold specific line data from text file
        Dim prod4 As String 'Variable to hold specific line data from text file
        Dim prod5 As String 'Variable to hold specific line data from text file

        'Read text file informaiont
        Dim allLines As List(Of String) = New List(Of String)
        newproduct = File.OpenText("C:\Users\Chandra\OneDrive\~School\~Spring 2018\VB.Net\~Project3\newproduct.txt")
        'Loop through Text box informaiotn
        Do While Not newproduct.EndOfStream
            allLines.Add(newproduct.ReadLine())
        Loop
        'Put lines containing product names (listed here as specific lines) into a variable
        prod1 = dashConcat(1, allLines)
        prod2 = dashConcat(6, allLines)
        prod3 = dashConcat(11, allLines)
        prod4 = dashConcat(16, allLines)
        prod5 = dashConcat(21, allLines)
        'Display variable for product names concatinated with "space dash space"
        lblQuickNewProduct.Text = (prod1 & " - " & prod2 & " - " & prod3 & " - " & prod4 & " - " & prod5)
        'Close the text file
        newproduct.Close()
    End Sub
    'dashConcat Function to return lines from the subroutine
    Private Function dashConcat(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber - 1)
    End Function
    'Variables to Start on the the form
    Private Sub btnSeeCurrentValues_Click(sender As Object, e As EventArgs) Handles btnSeeCurrentValues.Click
        Dim intCurWkSales As Integer = 25
        Dim intCurMonSales As Integer = 487
        Dim intCurQtrSales As Integer = 1502
        Dim intCurYTDSales As Integer = 3216
        Dim intCurWkWholesale As Integer = 605
        Dim intCurMonWholesale As Integer = 605
        Dim intCurQtrWholesale As Integer = 914
        Dim intCurYTDWholesale As Integer = 1898
        'Display the variables when user clicks the see current values button
        lblCurWkValS.Text = "25"
        lblCurMonValS.Text = "487"
        lblCurQtrValS.Text = "1502"
        lblCurYTDValS.Text = "3216"
        lblCurWkValW.Text = "605"
        lblCurMonValW.Text = "605"
        lblCurQtrValW.Text = "914"
        lblCurYTDValW.Text = "1898"
    End Sub
    'Run the assignment requirement to show the difference in ByRef and ByVal
    Private Sub btnRun_Click(ByVal sender As Object, e As EventArgs) Handles btnRun.Click
        'Variables to Start on the the form
        Dim intCurWkSales As Integer = 25
        Dim intCurMonSales As Integer = 487
        Dim intCurQtrSales As Integer = 1502
        Dim intCurYTDSales As Integer = 3216
        Dim intCurWkWholesale As Integer = 605
        Dim intCurMonWholesale As Integer = 605
        Dim intCurQtrWholesale As Integer = 914
        Dim intCurYTDWholesale As Integer = 1898
        'Call the new subroutine and display the value of the ByVal outcome
        demoByRef(intCurYTDWholesale)
        lblOrigValW.Text = ("The ByVal Number Remains " & intCurYTDWholesale)
        'Call the new subroutine and display the value of the ByRef outcome
        demoByRef2(intCurYTDSales)
        lblOrigValS.Text = ("The ByVal Number Remains " & intCurYTDSales)
    End Sub
    'Call the new subroutine and display the value of the ByRef outcome
    Sub demoByRef(ByVal intForAssignment As Integer)
        intForAssignment += 100
        lblNewValW.Text = ("The ByVal Number in the Sub is " & intForAssignment)
    End Sub
    'Call the new subroutine and display the value of the ByRef outcome
    Sub demoByRef2(ByRef intForAssignment2 As Integer)
        intForAssignment2 += 100
        lblNewValS.Text = ("The ByRef Number in the Sub is " & intForAssignment2)
    End Sub
    'New subroutine on button click to add user input 
    'ALSO SHOWING GLOBAL VARIABLES AS THEY ARE STORED IN THE MODULE BusinessDetailDefault
    Private Sub btnUpdateSales_Click(sender As Object, e As EventArgs) Handles btnUpdateSales.Click
        'Verify user added integer and update all scores with new input
        '  If txtAddSales.Text = "" Then
        '  MessageBox.Show("Sales Amount Must Be Entered")

        'Verify Quantity Has Been Entered
        ' ElseIf IsNumeric(txtAddSales.Text) = False Then
        ' 'Display error message if quantity is not numeric
        ' MessageBox.Show("Sales Amount Must be Numeric")

        If Integer.TryParse(txtAddSales.Text, intAddSales) Then
            intUpdateCurWkSales = intCurWkSales + intAddSales
            lblCurWkValS.Text = intUpdateCurWkSales.ToString
        End If

        intUpdateCurMonSales = intCurMonSales + intAddSales
        lblCurMonValS.Text = intUpdateCurMonSales.ToString

        intUpdateCurQtrSales = intCurQtrSales + intAddSales
        lblCurQtrValS.Text = intUpdateCurQtrSales.ToString

        intUpdateCurYTDSales = intCurYTDSales + intAddSales
        lblCurYTDValS.Text = intUpdateCurYTDSales.ToString

        txtAddSales.Clear()
        txtAddSales.Focus()

    End Sub
    'New subroutine on button click to add user input 
    'ALSO SHOWING GLOBAL VARIABLES AS THEY ARE STORED IN THE MODULE BusinessDetailDefault
    Private Sub btnUpdateWholesale_Click(sender As Object, e As EventArgs) Handles btnUpdateWholesale.Click
        'Verify user added integer and update all scores with new input
        If txtAddWholesale.Text = "" Then
            MessageBox.Show("Wholesale Amount Must Be Entered")

            'Verify Quantity Has Been Entered
        ElseIf IsNumeric(txtAddWholesale.Text) = False Then
            'Display error message if quantity is not numeric
            MessageBox.Show("Wholesale Amount Must be Numeric")

        Else Integer.TryParse(txtAddWholesale.Text, intAddWholesale)
            intUpdateCurWkWholesale = intCurWkWholesale + intAddWholesale
            lblCurWkValW.Text = intUpdateCurWkWholesale.ToString

        End If

        intUpdateCurMonWholesale = intCurMonWholesale + intAddWholesale
        lblCurMonValW.Text = intUpdateCurMonWholesale.ToString

        intUpdateCurQtrWholesale = intCurQtrWholesale + intAddWholesale
        lblCurQtrValW.Text = intUpdateCurQtrWholesale.ToString

        intUpdateCurYTDWholesale = intCurYTDWholesale + intAddWholesale
        lblCurYTDValW.Text = intUpdateCurYTDWholesale.ToString

        txtAddWholesale.Clear()
        txtAddWholesale.Focus()
    End Sub
    'Declare array public
    Public productArray() As String
    'Create Private Structure
    Private Structure ProductList
        'Public Variables
        Dim strItemToAdd As String 'To hold product item entered from textbox
        Dim strQuantity As String 'To hold Quantity entered from textbox
        Dim intItemCount As Integer 'To hold loop counter
        Public strList As String 'To hold the list

    End Structure
    'Array
    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
        Dim intItemcount As Integer = 0

        ReDim Preserve productArray(intItemcount)
        For intItemcount = 0 To productArray.Length - 1
            productArray(intItemcount) = txtNewItem.Text & " - " & txtQuantity.Text

            'Display error message if quantity is not entered
            If txtQuantity.Text = "" Then
                MessageBox.Show("Quantity Must Be Entered")

                'Verify Quantity Has Been Entered
            ElseIf IsNumeric(txtQuantity.Text) = False Then
                'Display error message if quantity is not numeric
                MessageBox.Show("Quantity Must be Numeric")

                'Display in textbox
            Else txtListOfItems.Text += productArray(intItemcount) + vbCrLf
                txtListOfItems.Text = StrConv(txtListOfItems.Text, VbStrConv.ProperCase)
            End If
        Next
        'Clear text box for next entry
        txtNewItem.Clear()
        txtQuantity.Clear()
    End Sub
    'Clear the list when the clear buttion is clicked
    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        txtListOfItems.Clear()
    End Sub
    'Show Unit High Scores will generate the Default score of 327
    Private Sub btnShowUnitHighScores_Click(sender As Object, e As EventArgs) Handles btnShowUnitHighScores.Click
        lblUnitHighScoreSales.Text = "327"
        lblUnitHighScoreWholesale.Text = "327"
    End Sub
    'Tool Strip Menu to open a file
    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Try
            If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
                txtListOfItems.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            'Error Message
            MessageBox.Show("That file can't be opened")
        End Try
    End Sub
    'Open save file dialog box for user to enter location and name of file
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Button Click to save the list to a file

        'Variables for save file
        Dim strProductListFile As New SaveFileDialog 'File Name
        'Dim objProductList As StreamWriter 'Object variable to hold StreamWriter
        'Dim structProdList As ProductList 'Structure variable

        'Get the file name from the user
        strProductListFile.FileName = ""
        strProductListFile.Filter = "Text Files (*.txt) |*.txt"
        strProductListFile.Title = "Save"
        strProductListFile.ShowDialog()

        'Get the file name from the user
        Try
            Dim Write As New System.IO.StreamWriter(strProductListFile.FileName)
            Write.Write(txtListOfItems.Text)
            'Close File
            Write.Close()
            MessageBox.Show("Your File has been Saved")
        Catch ex As Exception
            'Error Message
            MessageBox.Show("That file can't be created.")
        End Try
    End Sub
    'Close Application from Menu Bar
    Private Sub ExitToolStripMenuTab7_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuTab7.Click
        Dim intExitResult As Integer = MessageBox.Show("Are You Sure You Want to Close the Application?", "Exit", MessageBoxButtons.YesNoCancel)

        If intExitResult = DialogResult.Yes Then
            MessageBox.Show("Have a Be-You'tiful Day!")
            Application.Exit()
        Else
        End If
    End Sub
    'Close Application from Menu Bar
    Private Sub ExitToolStripMenuTab6_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuTab6.Click
        Dim intExitResult As Integer = MessageBox.Show("Are You Sure You Want to Close the Application?", "Exit", MessageBoxButtons.YesNoCancel)

        If intExitResult = DialogResult.Yes Then
            MessageBox.Show("Have a Be-You'tiful Day!")
            Application.Exit()
        Else
        End If
    End Sub
    'Close Application from Menu Bar
    Private Sub ExitToolStripMenuTab5_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuTab5.Click
        Dim intExitResult As Integer = MessageBox.Show("Are You Sure You Want to Close the Application?", "Exit", MessageBoxButtons.YesNoCancel)

        If intExitResult = DialogResult.Yes Then
            MessageBox.Show("Have a Be-You'tiful Day!")
            Application.Exit()
        Else
        End If
    End Sub
    'Close Application from Menu Bar
    Private Sub ExitToolStripMenuTab4_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuTab4.Click
        Dim intExitResult As Integer = MessageBox.Show("Are You Sure You Want to Close the Application?", "Exit", MessageBoxButtons.YesNoCancel)

        If intExitResult = DialogResult.Yes Then
            MessageBox.Show("Have a Be-You'tiful Day!")
            Application.Exit()
        Else
        End If
    End Sub
    'Close Application from Menu Bar
    Private Sub ExitToolStripMenuTab3_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuTab3.Click
        Dim intExitResult As Integer = MessageBox.Show("Are You Sure You Want to Close the Application?", "Exit", MessageBoxButtons.YesNoCancel)

        If intExitResult = DialogResult.Yes Then
            MessageBox.Show("Have a Be-You'tiful Day!")
            Application.Exit()
        Else
        End If
    End Sub
    'Close Application from Menu Bar
    Private Sub ExitToolStripMenuTab2_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuTab2.Click
        Dim intExitResult As Integer = MessageBox.Show("Are You Sure You Want to Close the Application?", "Exit", MessageBoxButtons.YesNoCancel)

        If intExitResult = DialogResult.Yes Then
            MessageBox.Show("Have a Be-You'tiful Day!")
            Application.Exit()
        Else
        End If
    End Sub
    'Close Application from Menu Bar
    Private Sub ExitToolStripMenuTab1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuTab1.Click
        Dim intExitResult As Integer = MessageBox.Show("Are You Sure You Want to Close the Application?", "Exit", MessageBoxButtons.YesNoCancel)

        If intExitResult = DialogResult.Yes Then
            MessageBox.Show("Have a Be-You'tiful Day!")
            Application.Exit()
        Else
        End If
    End Sub
End Class














