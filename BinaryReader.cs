//This is a sample of how to display the last players score in your quiz game using binary reader
//Binary reader usage should be done within the try/catch blocks
try
{
    // Read the 'scores.bin' binary file
    BinaryReader b = new BinaryReader(File.Open("score.bin", FileMode.Open));
    
    //Create variables to control position and length of the stream
    int pos = 0;
    int length = (int)b.BaseStream.Length;

    //Iterate through the binary file and get assign the score to the label 'lblPreviousSCore.Text
    while (pos < length)
    {
        // Read integer.
        int score = b.ReadInt32();
        //Assign the last score lbl to include the score and show score lbl
        lblPreviousScore.Text += " " + score;
        lblPreviousScore.Visible = true;
        // Advance our position variable.
        pos += sizeof(int);
    }

    //Close BinaryReader
    b.Close();

}
catch (Exception ex)
{
    //If error occurs, write error to console and hide score label
    Console.WriteLine("General Exception: " + ex);
    LblScorePreviousPlayer1.Visible = false;
}