using System;


namespace R5T.O0024
{
    public class SyntaxOperations : ISyntaxOperations
    {
        #region Infrastructure

        public static ISyntaxOperations Instance { get; } = new SyntaxOperations();


        private SyntaxOperations()
        {
        }

        #endregion
    }
}
