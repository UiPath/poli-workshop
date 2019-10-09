namespace Poli.App.Core
{
    public class HelloWorld
    {
        public string GetMessage(string name)
        {
            return string.isNullOrEmpty(name)
                ? "Hello"
                : $"Hello {name}";
        }
    }
}
