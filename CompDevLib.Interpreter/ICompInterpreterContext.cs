using CompDevLib.Interpreter.Parse;

namespace CompDevLib.Interpreter
{
    public interface ICompInterpreterContext
    {
        public CompEnvironment Environment { get; }
    }
}