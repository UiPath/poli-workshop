namespace Poli.App.Core
{
    public class HelloWorld
    {
        public string GetMessage(string name)
        {
            return string.IsNullOrEmpty(name)
                ? "Hello"
                : $"Hello {name}";
        }
    }
}
