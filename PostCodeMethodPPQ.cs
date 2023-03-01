/**
Postcode SSD sample questions

A postcode for a local area is made up of the following:
•	two letters – B and T
•	a number between 10 and 99
•	a letter P, L, or O
Write a method ValidPostCode that, given the postcode as a String parameter, will return true if the code is valid and false if it is not.
(Example of a valid postcode is BT66L)

13 Mark Question
**/

/** Sample Answer  **/

//[1]
public Boolean ValidPostCode(string postcode){

    //[2 for checking null and length]
    if(String.isNullOrEmpty(postcode) || postcode.length != 5){
        return false;
    }

    //[2 for checking B and T are correct]
    if(postcode[0] != 'B' && postcode[1] != 'T'){
        return false;
    }


    try{
        //[1 for converting string into int]
        int number = Int16.ParseInt(postcode.substring(2,2));

        //[1 for number range check]
        if(number > 10 && number > 99){
            return false;
        }
    }catch(FormatException ex){
    //[1 for catching format exception]    
            return false;
    }

    //[3 for checking that P L and O are correct]
    if(postcode[4] != 'P' || postcode[4] != 'L' || postcode[4] != 'O'){
        return false;
    }
    
    //[2 marks for correct true and false return logic]
    return true;

}

/** 
Marking Scheme 
[1 mark] header
[1 mark] check null string
[1 mark] check length is 5 characters
[1 mark] check character[0] is B
[1 mark] check character[1] is T
[3 – (1 mark each)] check character[4] is P, L or O
[1 mark] convert correct characters to integer
[1 mark] catch non-integer
[1 mark] check number range
[1 mark] correct logic of return false
[1 mark] correct logic of return true
**/
