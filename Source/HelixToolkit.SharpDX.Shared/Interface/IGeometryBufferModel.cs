﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
using System;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;

#if !NETFX_CORE
namespace HelixToolkit.Wpf.SharpDX
#else
namespace HelixToolkit.UWP
#endif
{
    using Utilities;
    public interface IGeometryBufferModel : IGUID, IDisposable
    {
        Geometry3D Geometry { get; set; }
        PrimitiveTopology Topology { set; get; }

        event EventHandler<bool> InvalidateRenderer;
        IElementsBufferProxy VertexBuffer { get; }
        IElementsBufferProxy IndexBuffer { get; }

        bool AttachBuffers(DeviceContext context, InputLayout vertexLayout, int vertexBufferSlot);
    }

    public interface IBillboardBufferModel : IDisposable
    {
        ShaderResourceView TextureView { get; }
        BillboardType Type { get; }
    }
}