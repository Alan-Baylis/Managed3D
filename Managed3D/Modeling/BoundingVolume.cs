﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Managed3D.Geometry;

namespace Managed3D.Modeling
{
    /// <summary>
    /// Represents a bounding volume, in other words an axis-aligned rectangular volume.
    /// </summary>
    public class BoundingVolume
    {
        #region Properties
        /// <summary>
        /// Gets or sets the width (measurement on the X-axis) of the volume.
        /// </summary>
        public double Width
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the length (measurement on the Y-axis) of the volume.
        /// </summary>
        public double Length
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the height (measurement on the Z-axis) of the volume.
        /// </summary>
        public double Height
        {
            get;
            set;
        }

        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public double Z
        {
            get;
            set;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Determines if the specified point is contained by the bounding volume.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool Contains(Vector3 point)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
