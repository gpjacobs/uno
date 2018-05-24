﻿#region Assembly System.Runtime.WindowsRuntime.UI.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// C:\Users\jerome.laban\.nuget\packages\System.Runtime.WindowsRuntime.UI.Xaml\4.0.0\ref\netcore50\System.Runtime.WindowsRuntime.UI.Xaml.dll
#endregion

using System;
using System.Security;

namespace Windows.UI.Xaml.Media.Media3D
{
	//
	// Summary:
	//     Represents a 4 × 4 matrix that is used for transformations in a three-dimensional
	//     (3-D) space.
	[SecurityCritical]
	public struct Matrix3D : IFormattable
	{
		public Matrix3D(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double offsetX, double offsetY, double offsetZ, double m44) { throw new NotImplementedException(); }

		public static Matrix3D Identity { get; }

		public bool HasInverse { get; }

		public bool IsIdentity { get; }

		public double M11 { get; set; }

		public double M12 { get; set; }


		public double M13 { get; set; }


		public double M14 { get; set; }


		public double M21 { get; set; }


		public double M22 { get; set; }


		public double M23 { get; set; }


		public double M24 { get; set; }


		public double M31 { get; set; }


		public double M32 { get; set; }


		public double M33 { get; set; }


		public double M34 { get; set; }


		public double M44 { get; set; }


		public double OffsetX { get; set; }


		public double OffsetY { get; set; }

		public double OffsetZ { get; set; }

		public override bool Equals(object o) { throw new NotImplementedException(); }

		public bool Equals(Matrix3D value) { throw new NotImplementedException(); }

		[SecuritySafeCritical]
		public override int GetHashCode() { throw new NotImplementedException(); }

		public void Invert() { throw new NotImplementedException(); }

		public override string ToString() { throw new NotImplementedException(); }

		public string ToString(IFormatProvider provider) { throw new NotImplementedException(); }

		public string ToString(string format, IFormatProvider provider) { throw new NotImplementedException(); }

		public static Matrix3D operator *(Matrix3D matrix1, Matrix3D matrix2) { throw new NotImplementedException(); }

		public static bool operator ==(Matrix3D matrix1, Matrix3D matrix2) { throw new NotImplementedException(); }

		public static bool operator !=(Matrix3D matrix1, Matrix3D matrix2) { throw new NotImplementedException(); }
	}
}