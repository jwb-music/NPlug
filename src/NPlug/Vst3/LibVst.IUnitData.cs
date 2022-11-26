// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;

namespace NPlug.Vst3;

internal static unsafe partial class LibVst
{
    public partial struct IUnitData
    {
        private static partial ComResult unitDataSupported_ccw(ComObject* self, UnitID unitID)
        {
            throw new NotImplementedException();
        }

        private static partial ComResult getUnitData_ccw(ComObject* self, UnitID unitId, IBStream* data)
        {
            throw new NotImplementedException();
        }

        private static partial ComResult setUnitData_ccw(ComObject* self, UnitID unitId, IBStream* data)
        {
            throw new NotImplementedException();
        }
    }
}