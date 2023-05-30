using System;
using System.Linq;

namespace Moravuscz.OmronPlcInformation
{
    /// <summary>
    /// Extension methods for use withing this project
    /// </summary>
    internal static class ExtensionMethods
    {
        /// <summary>
        /// Gets the count of <see cref="FlagsAttribute">Flags</see> set on <see cref="Enum"/>
        /// </summary>
        /// <typeparam name="T">Enumerable</typeparam>
        /// <param name="flagEnum"><typeparamref name="T"/> to count <see cref="FlagsAttribute">Flags</see> of</param>
        /// <returns></returns>
        internal static int GetFlagCount<T>(this T flagEnum) where T : Enum
        {
            if (flagEnum.GetType().GetCustomAttributes(false).OfType<FlagsAttribute>().Any())
            {
                return Enum.GetValues(typeof(T)).OfType<T>().Count(enumValue => flagEnum.HasFlag(enumValue));
            }
            else
            {
                throw new ArgumentException($"{nameof(flagEnum)} isn't a {nameof(FlagsAttribute)} {nameof(Enum)}!");
            }
        }
    }
}
