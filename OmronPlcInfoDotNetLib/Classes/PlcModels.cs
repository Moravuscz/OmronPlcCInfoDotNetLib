using System;

namespace Moravuscz.OmronPlcInformation
{
    public struct PlcModels
    {
        public struct CJ2M
        {
            public struct CPU11
            {
                /// <summary>
                /// Total Program Area Size
                /// </summary>
                /// <remarks>#K of steps</remarks>
                public static int TotalProgramAreaSize => 5;
                
                public static int GetTotalProgramAreaSize() => TotalProgramAreaSize;
                
                /// <summary>
                /// Expansion Memory Bank Size
                /// </summary>
                /// <remarks>#KW</remarks>
                public static int ExpansionMemorySize => 32;

                /// <summary>
                /// Number of Expansion Memory Banks
                /// </summary>
                public static int ExpansionMemoryBankCount => ExtensionMethods.GetFlagCount(ExpansionMemoryBanks);

                /// <summary>
                /// Availabe Memory Areas
                /// </summary>
                /// <remarks>Inlcuding <see cref="ExpansionMemoryBanks"/> Banks</remarks>
                /// <value>CIO, A, D, E, H, T, C</value>
                public static MemoryArea MemoryAreas =>
                      MemoryArea.CIO
                    | MemoryArea.A
                    | MemoryArea.T
                    | MemoryArea.C
                    | MemoryArea.IR
                    | MemoryArea.DR
                    | MemoryArea.D
                    | MemoryArea.TK
                    | MemoryArea.H
                    | MemoryArea.W
                    | MemoryArea.E;

                /// <summary>
                /// Available Expansion Memory Banks
                /// </summary>
                /// <value>E</value>
                public static MemoryArea ExpansionMemoryBanks => MemoryArea.E;

                /// <summary>
                /// Indicates whether CPU has a build-in Ethernet/IP adapter
                /// </summary>
                /// <value>false</value>
                public static bool HasEthernetIPAdapter = false;
            }

            public struct CPU12
            {
                /// <summary>
                /// Total Program Area Size
                /// </summary>
                /// <remarks>#K of steps</remarks>
                public static int TotalProgramAreaSize => 10;

                public static int GetTotalProgramAreaSize() => TotalProgramAreaSize;

                /// <summary>
                /// Expansion Memory Bank Size
                /// </summary>
                /// <remarks>#KW</remarks>
                public static int ExpansionMemorySize => 32;

                /// <summary>
                /// Number of Expansion Memory Banks
                /// </summary>
                public static int ExpansionMemoryBankCount => ExtensionMethods.GetFlagCount(ExpansionMemoryBanks);

                /// <summary>
                /// Availabe Memory Areas
                /// </summary>
                /// <remarks>Inlcuding <see cref="ExpansionMemoryBanks"/> Banks</remarks>
                /// <value>CIO, A, D, E, H, T, C</value>
                public static MemoryArea MemoryAreas =>
                      MemoryArea.CIO
                    | MemoryArea.A
                    | MemoryArea.T
                    | MemoryArea.C
                    | MemoryArea.IR
                    | MemoryArea.DR
                    | MemoryArea.D
                    | MemoryArea.TK
                    | MemoryArea.H
                    | MemoryArea.W
                    | MemoryArea.E0
                    | MemoryArea.E1;

                /// <summary>
                /// Available Expansion Memory Banks
                /// </summary>
                /// <value>E</value>
                public static MemoryArea ExpansionMemoryBanks => MemoryArea.E0 | MemoryArea.E1;

                /// <summary>
                /// Indicates whether CPU has a build-in Ethernet/IP adapter
                /// </summary>
                /// <value>false</value>
                public static bool HasEthernetIPAdapter = false;
            }


            public struct CPU13 { }
            
            
            public struct CPU14 { }
            
            
            public struct CPU15 { }
            
            
            public struct CPU31 { }
            
            
            public struct CPU32 { }
            
            
            public struct CPU33 { }
            
            
            public struct CPU34 { }
            
            
            public struct CPU35 { }

        }

        public struct CJ2H
        {
            public struct CPU64 { }
            public struct CPU65 { }
            public struct CPU66 { }
            public struct CPU67 { }
            public struct CPU68 { }
            public struct CPU64_EIP { }
            public struct CPU65_EIP { }
            public struct CPU66_EIP { }
            public struct CPU67_EIP { }
            public struct CPU68_EIP { }
}
    }
}
