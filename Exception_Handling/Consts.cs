// Dedicated static class for exception handling constants


namespace WinFormsPermClipCalc.Exception_Handling
{
    public static class Consts
    {

        public const string StartFinishError = "Please select 'Start' or 'Finish' in the drop-down menu."; // error message to be shown if neither start or finish is selected.
        public const string StartOutOfRange = "Please enter a start dimension (inches) between 10.625 and 24.125"; // Start out of range error
        public const string FinishOutOfRange = "Please enter a finish dimension (inches) between 12.125 and 24.125"; // Finish out of range error
        public const string HorizontalZoneError = "Please enter a positive numeric value for the horizontal zone size (in decimal inches)"; // non-numeric error for horizontal zone size
        public const string VerticalZoneError = "Please enter a positive numeric value for the vertical zone size (in decimal inches)"; // non-numeric error for vertical zone size
        public const string PurlinStringError = "Please enter a positive numeric value for the purlin string (in inches)";// non-numeric error for purlin string
        public const string PurlinUserEntry = "Please enter the distance for the first / next purlin space in inches"; // prompts the user to enter the next space between purlins
        public const string InvalidEntryError = "Please enter a numeric value for all required fields"; // prompts the user to enter the next space between purlins

    }
}

