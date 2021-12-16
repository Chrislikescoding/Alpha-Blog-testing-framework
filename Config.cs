namespace AutoFramework
{
    public static class Config
    {
       // public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "https://learnrubyonrails2020.herokuapp.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Email = "sharpchr@gmail.com";
                public static string Username = "sharpchr@gmail.com";
                public static string Password = "Charlie1";
            }

            public static class Invalid
            {
                public static class Email
                {
                    public static string NoUser = "@example.com";
                    public static string NoAt = "exampleexample.com";
                    public static string NoDomain = "example@";
                    public static string NoExtension = "example@example";
                }

                public static class Username
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }

                public static class Password
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }
            }
        }

        public static class MenuElements
        {
            public static string Introduction = "Introduction";
            public static string Selectors = "Selectors";
            public static string SpecialElements = "Special Elements";
            public static string TestCases = "Test Cases";
            public static string TestScenarios = "Test Scenarios";
            public static string About = "About";
        }

        public static class TestMessages
        {

        }

        public static class AlertsTexts
        {
            public static string InvalidPassword = "There was something wrong with your login details";
            public static string InvalidEmailnoat = "Please include an '@' in the email address.";
            public static string PasswordLenghtOutOfRange = "Password should not be empty / length be between 5 to 12";
            public static string SuccessfulLogin = "Logged in successfully";
        }
    }
    
}

