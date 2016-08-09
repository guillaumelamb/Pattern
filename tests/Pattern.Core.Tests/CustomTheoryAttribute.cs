namespace Pattern.Core.Tests
{
    using Xunit;

    public class CustomTheoryAttribute : TheoryAttribute
    {
        private string displayName;

        public override string DisplayName
        {
            get
            {
                return this.displayName;
            }
            set
            {
                this.displayName = value.Replace("_", " ");
            }
        }
    }
}