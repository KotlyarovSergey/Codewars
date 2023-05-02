using System;

    public class Kata
    {

        public static bool Validate_hello(string greetings)
        {
            greetings = greetings.ToLower();
            if(greetings.IndexOf("hello") >= 0) return true;
            if(greetings.IndexOf("ciao") >= 0) return true;
            if(greetings.IndexOf("salut") >= 0) return true;
            if(greetings.IndexOf("hallo") >= 0) return true;
            if(greetings.IndexOf("hola") >= 0) return true;
            if(greetings.IndexOf("ahoj") >= 0) return true;
            if(greetings.IndexOf("czesc") >= 0) return true;

            return false; 
        }
    }