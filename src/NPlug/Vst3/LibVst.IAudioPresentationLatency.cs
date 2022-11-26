// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.
namespace NPlug.Vst3;


using System;

internal static unsafe partial class LibVst
{
    public partial struct IAudioPresentationLatency
    {
        private static partial ComResult setAudioPresentationLatencySamples_ccw(ComObject* self, LibVst.BusDirection dir, int busIndex, uint latencyInSamples)
        {
            throw new NotImplementedException();
        }
    }
}