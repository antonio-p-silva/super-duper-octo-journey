using ShowIntent.SymbolicTypes.Helpers;

namespace ShowIntent.SymbolicTypes.Extensions
{
    public static class MeaningfulIntegerExtensions {
        public static T Add<T>(this T first, T second) where T : MeaningfulInteger
        {
            var sumValue = first?.Value + second?.Value;
            var genericConstructor = GenericTypesHelpers.CreateConstructor(typeof(T), typeof(int));
            return (T) genericConstructor(sumValue.GetValueOrDefault());   
        }
        
        public static T Subtract<T>(this T first, T second) where T : MeaningfulInteger
        {
            var subtractValue = first?.Value - second?.Value;
            var genericConstructor = GenericTypesHelpers.CreateConstructor(typeof(T), typeof(int));
            return (T) genericConstructor(subtractValue.GetValueOrDefault());   
        }
        
        public static T Divide<T>(this T first, T second) where T : MeaningfulInteger
        {
            var subtractValue = first?.Value - second?.Value;
            var genericConstructor = GenericTypesHelpers.CreateConstructor(typeof(T), typeof(int));
            return (T) genericConstructor(subtractValue.GetValueOrDefault());   
        }
        
        public static T Multiply<T>(this T first, T second) where T : MeaningfulInteger
        {
            var subtractValue = first?.Value - second?.Value;
            var genericConstructor = GenericTypesHelpers.CreateConstructor(typeof(T), typeof(int));
            return (T) genericConstructor(subtractValue.GetValueOrDefault());   
        }
    }
}