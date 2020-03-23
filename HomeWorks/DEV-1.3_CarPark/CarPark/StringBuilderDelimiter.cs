using System.Text;

namespace CarPark
{
    /// <summary>
    /// extension class for StringBuilder
    /// </summary>
    internal static class StringBuilderDelimiter
    {
        const char SYMBOL_SPACE = ' ';
        /// <summary>
        /// extension method adds to stringBuilder delimiter (default == ' ') and then addedString
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="addedString"></param>
        /// <param name="delimiter"></param>
        /// <returns>stringBuilder</returns>
        internal static StringBuilder AppendWithDelimiter ( this StringBuilder stringBuilder, string addedString, char delimiter = SYMBOL_SPACE )
        {
            stringBuilder.Append(delimiter);
            stringBuilder.Append(addedString);
            return stringBuilder;
        }
    }
}
