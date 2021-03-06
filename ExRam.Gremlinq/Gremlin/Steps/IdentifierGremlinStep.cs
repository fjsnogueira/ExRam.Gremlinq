using System.Text;

namespace ExRam.Gremlinq
{
    public sealed class IdentifierGremlinStep : TerminalGremlinStep
    {
        private readonly string _variable;

        public IdentifierGremlinStep(string variable)
        {
            this._variable = variable;
        }

        public override GroovyExpressionState Serialize(StringBuilder stringBuilder, GroovyExpressionState state)
        {
            return state.AppendIdentifier(stringBuilder, this._variable);
        }
    }
}