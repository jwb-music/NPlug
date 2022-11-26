// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;

namespace NPlug.Vst3;


internal static partial class LibVst
{
    public record struct ComResult(int Value)
    {
        public static int NoInterface => OperatingSystem.IsWindows() ? unchecked((int)0x80004002) : -1;
        public const int Ok = 0;
        public const int True = Ok;
        public const int False = 1;
        public static int InvalidArg => OperatingSystem.IsWindows() ? unchecked((int)0x80070057) : 2;
        public static int NotImplemented => OperatingSystem.IsWindows() ? unchecked((int)0x80004001) : 3;
        public static int InternalError => OperatingSystem.IsWindows() ? unchecked((int)0x80004005) : 4;
        public static int Unexpected => OperatingSystem.IsWindows() ? unchecked((int)0x8000FFFF) : 5;
        public static int OutOfMemory => OperatingSystem.IsWindows() ? unchecked((int)0x8007000EL) : 6;

        public static implicit operator ComResult(int value) => new(value);
    }
}