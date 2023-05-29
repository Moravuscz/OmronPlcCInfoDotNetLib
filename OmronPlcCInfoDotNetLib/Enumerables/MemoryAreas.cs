using System;
using System.ComponentModel;

namespace Moravuscz.OmronPlcInformation
{
    [Flags]
    public enum MemoryArea : ulong
    {
        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        CIO = 0b000000000000000000000000000000000001,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        A = 0b000000000000000000000000000000000010,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        D = 0b000000000000000000000000000000000100,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E = 0b000000000000000000000000000000001000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E0 = E,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E1 = 0b000000000000000000000000000000010000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E2 = 0b000000000000000000000000000000100000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E3 = 0b000000000000000000000000000001000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E4 = 0b000000000000000000000000000010000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E5 = 0b000000000000000000000000000100000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E6 = 0b000000000000000000000000001000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E7 = 0b000000000000000000000000010000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E8 = 0b000000000000000000000000100000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E9 = 0b000000000000000000000001000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        EA = 0b000000000000000000000010000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        EB = 0b000000000000000000000100000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        EC = 0b000000000000000000001000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        ED = 0b000000000000000000010000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        EE = 0b000000000000000000100000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        EF = 0b000000000000000001000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E10 = 0b000000000000000010000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E11 = 0b000000000000000100000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E12 = 0b000000000000001000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E13 = 0b000000000000010000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E14 = 0b000000000000100000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E15 = 0b000000000001000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E16 = 0b000000000010000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E17 = 0b000000000100000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        E18 = 0b000000001000000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        H = 0b000000010000000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        W = 0b000000100000000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        T = 0b000001000000000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        C = 0b000010000000000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        TK = 0b000100000000000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        TR = 0b001000000000000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        IR = 0b010000000000000000000000000000000000,

        /// <summary>
        /// </summary>
        /// <remarks>
        /// <para></para>
        /// </remarks>
        [Description("")]
        DR = 0b100000000000000000000000000000000000
    }
}
