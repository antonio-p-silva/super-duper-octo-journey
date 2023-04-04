namespace ShowIntent.SymbolicTypes.Extensions
{
    public static class MeaningfulTypesExtensions {
        
        /// <summary>
        /// Returns true if <see cref="IMeaningfulType"/> is defined (e.g. is not null)
        /// </summary>
        /// <param name="meaningfulType"></param>
        /// <returns></returns>
        public static bool IsDefined<T>(this IMeaningfulType<T> meaningfulType)
        {
            return meaningfulType != null;
        }
        
        /// <summary>
        /// Returns true if <see cref="IMeaningfulType"/> is undefined (e.g. is null)
        /// </summary>
        /// <param name="meaningfulType"></param>
        /// <returns></returns>
        public static bool IsUndefined<T>(this IMeaningfulType<T> meaningfulType)
        {
            return meaningfulType.IsDefined() == false;
        }
    }
}