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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_internalformat_sample_query")]
    public unsafe partial class NVInternalformatSampleQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_internalformat_sample_query";
        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        public NVInternalformatSampleQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

