/// Filename: Enigma.java
// / Author: Dr. Shane Wilson
/// Description: Add a useful description of this file

import java.util.List;

public final class Enigma {

    public static String Encrypt(String message, int incrementNumber,List<String> rotors ){
        // TODO - Implement the Encrypt method
        // Steps in brief
        // 1. Apply the CAESAR shift using the increment number
        // 2. For each rotor in the list rotors
        //  2.1 Translate the message using the rotor
        // 3. Return the encrypted string

        char temp;
        char start = 'A';

        String messageUpperCase = message.toUpperCase();
        String encryptedMessage = "";
        String nextMessage = "";
        char characterToAdd;

        //CAESAR SHIFT
        for (int i = 0; i < messageUpperCase.length(); i++)
        {
            
            if (messageUpperCase.charAt(i) != ' ')
            {
                temp = messageUpperCase.charAt(i);
                temp += (incrementNumber + i);
                if(temp < 'a' || temp > ('z'))
                {
                    characterToAdd = (char)(((temp - start + (incrementNumber + i)) % 26) + start);
                    encryptedMessage+=characterToAdd;
                }
                else
                {
                    encryptedMessage+=temp;
                }
                encryptedMessage += temp;
            }
            else
            {
                encryptedMessage += message.charAt(i);
            }
        }

        return encryptedMessage;
    }


    public static String Decrypt(String message, int incrementNumber, List<String> rotors)
    {
        // TODO - Implement the Decrypt method

        // Steps in brief
        // 1. For each rotor in the list rotors, starting with the last rotor
        //  1.1 Translate the message using the rotor
        // 2. Apply the CAESAR shift
        // 3. Return the decrypted string

        return "Implement the decrypt";

    }
}
