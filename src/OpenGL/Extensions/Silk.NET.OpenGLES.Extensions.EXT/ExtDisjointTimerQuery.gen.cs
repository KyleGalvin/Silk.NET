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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_disjoint_timer_query")]
    public unsafe partial class ExtDisjointTimerQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_disjoint_timer_query";
        [NativeApi(EntryPoint = "glBeginQueryEXT")]
        public partial void BeginQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBeginQueryEXT")]
        public partial void BeginQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteQueriesEXT")]
        public unsafe partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteQueriesEXT")]
        public partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint ids);

        [NativeApi(EntryPoint = "glDeleteQueriesEXT")]
        public unsafe partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Query* ids);

        [NativeApi(EntryPoint = "glDeleteQueriesEXT")]
        public partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Query ids);

        [NativeApi(EntryPoint = "glEndQueryEXT")]
        public partial void EndQuery([Flow(FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glEndQueryEXT")]
        public partial void EndQuery([Flow(FlowDirection.In)] QueryTarget target);

        [NativeApi(EntryPoint = "glGenQueriesEXT")]
        public unsafe partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenQueriesEXT")]
        public partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glGenQueriesEXT")]
        public unsafe partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Query* ids);

        [NativeApi(EntryPoint = "glGenQueriesEXT")]
        public partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Query ids);

        [NativeApi(EntryPoint = "glGetInteger64vEXT")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64vEXT")]
        public partial void GetInteger64([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetInteger64vEXT")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64vEXT")]
        public partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public partial void GetQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public partial void GetQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectivEXT")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectivEXT")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectivEXT")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectivEXT")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glIsQueryEXT")]
        public partial bool IsQuery([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glQueryCounterEXT")]
        public partial void QueryCounter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glQueryCounterEXT")]
        public partial void QueryCounter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryCounterTarget target);

        public unsafe void DeleteQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteQueries(1, &ids);
        }

        public unsafe uint GenQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenQueries(n, &ret);
            return ret;
        }

        public unsafe long GetInteger64([Flow(FlowDirection.In)] EXT pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        public ExtDisjointTimerQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

