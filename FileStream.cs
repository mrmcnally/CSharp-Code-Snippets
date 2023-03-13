/* FileStream and StreamWriter sample code */


//ensure that System.IO directive is declared at the top of the document
using System.IO;

/*
Create a file called userDetails.txt if the file doesn't exist
*/
FileStream fs;
if (!File.Exists("userDetails.txt")) 
{
    fs = new FileStream("userDetails.txt", FileMode.Create);

    //Closes file stream after use. 
    //Accessing th userDetails file will cause an exception if not closed
    fs.Close();
}


/* Read lines from a file into an array*/
string[] allUsers = File.ReadLines("userDetails.txt").ToArray();

/*
* This is a sample method of how to read user details from a text file
* Each line of the allUsers array is split on a ',' and saved in a player array
* The Player array will look like this:
*       [0]       [1]     [2]     [3]       
*       username,email,password,avatar
*/
        public Boolean ValidateUser(String username)
        {
            if (username.Length > 30 || username == "")
            {
                txtUserError.Visible = true;
                txtUserError.Text = "Enter a valid username";
                return false;
            }

            for(int i = 0; i < AllUsers.Length; i++)
            {
                string[] player = AllUsers[i].Split(',');
                
                if(username == player[0])
                {
                    txtUserError.Text = "User already exists";
                    txtUserError.Visible = true;
                    return false;
                }
            }
            
             return true;            
        }


/* 
* Writing data to a file
* FileStream and StreamWriter are required to write to a text file
* FileMode.Append is used to add lines to the end of the text file
* The StreamWriter object is used to write the string to the text file
*/
FileStream fs = new FileStream("userDetails.txt", FileMode.Append);
StreamWriter sw = new StreamWriter(fs);
sw.WriteLine("This string will be appened to the userDetails.txt file" + "," + "1234");
//StreamWriter and FileStream must be closed after use
sw.Close();
fs.Close();
