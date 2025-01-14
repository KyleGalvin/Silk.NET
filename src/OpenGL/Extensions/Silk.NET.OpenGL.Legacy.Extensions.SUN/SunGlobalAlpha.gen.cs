// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_global_alpha")]
    public unsafe partial class SunGlobalAlpha : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_global_alpha";
        [NativeApi(EntryPoint = "glGlobalAlphaFactorbSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] sbyte factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactoriSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] int factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorfSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] float factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactordSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] double factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorubSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] byte factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorusSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] ushort factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactoruiSUN")]
        public partial void ObalAlphaFactor([Flow(FlowDirection.In)] uint factor);

        [NativeApi(EntryPoint = "glGlobalAlphaFactorsSUN")]
        public partial void ObalAlphaFactors([Flow(FlowDirection.In)] short factor);

        public SunGlobalAlpha(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

