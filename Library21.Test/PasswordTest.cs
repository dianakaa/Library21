namespace Library21.Test
{
    public class PasswordTest
    {
        [Theory]
        [InlineData("password", true)]
        [InlineData("", false)]
        [InlineData("pass", false)]
        public void IsValid_Theory(string password, bool expected)
        {
            Assert.Equal(expected, Password.IsValid(password));
        }
    }
}