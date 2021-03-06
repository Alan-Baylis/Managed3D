﻿/******************************************************************************
 * Managed3D: A 3D Graphics API for .NET and Mono - http://gearedstudios.com/ *
 * Copyright © 2009-2012 William 'cathode' Shelley. All Rights Reserved.      *
 * This software is released under the terms and conditions of the MIT/X11    *
 * license. See the 'license.txt' file for details.                           *
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagedStudio3D
{
    public enum SupportedRasterizer
    {
        Software = 0,
        OpenGL = 1,
        DirectX = 2,
        RaytracerCpu = 3,
        RaytracerGpu = 4
    }
}
