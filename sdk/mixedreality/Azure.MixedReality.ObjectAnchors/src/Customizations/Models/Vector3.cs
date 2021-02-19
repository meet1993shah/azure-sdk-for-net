// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.MixedReality.ObjectAnchors.Models
{
    /// <summary> The Vector3. </summary>
    internal partial class Vector3 : IEquatable<Vector3>
    {
        internal System.Numerics.Vector3 data;

        internal Vector3(System.Numerics.Vector3 vector)
        {
            data = vector;
        }

        /// <summary> Initializes a new instance of Vector3. </summary>
        /// <param name="x"> . </param>
        /// <param name="y"> . </param>
        /// <param name="z"> . </param>
        internal Vector3(float x, float y, float z)
        {
            data = new System.Numerics.Vector3(x, y, z);
        }

        public float X { get { return data.X; } set { data.X = value; } }

        public float Y { get { return data.Y; } set { data.Y = value; } }

        public float Z { get { return data.Z; } set { data.Z = value; } }

        public bool Equals(Vector3 other)
        {
            return this.data.Equals(other.data);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return obj is Vector3 && this.Equals(obj as Quaternion);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return data.GetHashCode();
        }

        public bool IsNormalized()
        {
            return data.IsNormalized();
        }
    }
}
