namespace BogusExtensionDiagnostic;

internal static class Extensions
{
    extension(string s)
    {
        public string Hello()
        {
            return $"Hello, {s}!";
        }
    }
}