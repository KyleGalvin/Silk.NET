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

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureInstanceKHR")]
    public unsafe partial struct AccelerationStructureInstanceKHR
    {
        public AccelerationStructureInstanceKHR
        (
            TransformMatrixKHR? transform = null,
            uint? instanceCustomIndex = null,
            uint? mask = null,
            uint? instanceShaderBindingTableRecordOffset = null,
            GeometryInstanceFlagsKHR? flags = null,
            ulong? accelerationStructureReference = null
        ) : this()
        {
            if (transform is not null)
            {
                Transform = transform.Value;
            }

            if (instanceCustomIndex is not null)
            {
                InstanceCustomIndex = instanceCustomIndex.Value;
            }

            if (mask is not null)
            {
                Mask = mask.Value;
            }

            if (instanceShaderBindingTableRecordOffset is not null)
            {
                InstanceShaderBindingTableRecordOffset = instanceShaderBindingTableRecordOffset.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (accelerationStructureReference is not null)
            {
                AccelerationStructureReference = accelerationStructureReference.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkTransformMatrixKHR")]
        [NativeName("Type.Name", "VkTransformMatrixKHR")]
        [NativeName("Name", "transform")]
        public TransformMatrixKHR Transform;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceCustomIndex")]
        public uint InstanceCustomIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mask")]
        public uint Mask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceShaderBindingTableRecordOffset")]
        public uint InstanceShaderBindingTableRecordOffset;
/// <summary></summary>
        [NativeName("Type", "VkGeometryInstanceFlagsKHR")]
        [NativeName("Type.Name", "VkGeometryInstanceFlagsKHR")]
        [NativeName("Name", "flags")]
        public GeometryInstanceFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "accelerationStructureReference")]
        public ulong AccelerationStructureReference;
    }
}
