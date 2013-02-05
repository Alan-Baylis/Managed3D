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
using Managed3D.Geometry;

namespace Managed3D.Modeling
{
    /// <summary>
    /// Represents the vertex of an editable mesh.
    /// </summary>
    public interface IVertex : ISelectable
    {
        #region Properties
        int Id { get; }
        Vector3 Position { get; set; }
        Vector3 Normal { get; }
        object Tag { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Enumerates over each other vertex that shares an edge with the current <see cref="IVertex"/>.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IVertex> GetNeighboringVertices();
        
        /// <summary>
        /// Enumerates over edges in the mesh which originate at the current <see cref="IVertex"/>.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IHalfEdge> GetOutgoingEdges();
        
        /// <summary>
        /// Enumerates over edges in the mesh which terminate at the current <see cref="IVertex"/>.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IHalfEdge> GetIncomingEdges();

        /// <summary>
        /// Enumerates over faces in the mesh which share the current <see cref="IVertex"/>.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IFace> GetNeighboringFaces();
        #endregion
    }
}