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
        String encryptedMessage = "";

        //CAESAR SHIFT
        for (int i = 0; i < message.length(); i++)
        {
            if (message.charAt(i) != ' ')
            {
                temp = message.charAt(i);
                temp += (incrementNumber + i);
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
