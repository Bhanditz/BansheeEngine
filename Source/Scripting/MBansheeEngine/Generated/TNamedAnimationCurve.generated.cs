using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Animation
	 *  @{
	 */

	/// <summary>An animation curve and its name.</summary>
	[StructLayout(LayoutKind.Sequential), SerializeObject]
	public partial struct NamedFloatCurve
	{
		/// <summary>Initializes the struct with default values.</summary>
		public static NamedFloatCurve Default()
		{
			NamedFloatCurve value = new NamedFloatCurve();
			value.name = "";
			value.flags = (AnimationCurveFlags)0;
			value.curve = null;

			return value;
		}

		/// <summary>Constructs a new named animation curve.</summary>
		/// <param name="name">Name of the curve.</param>
		/// <param name="curve">Curve containing the animation data.</param>
		public NamedFloatCurve(string name, AnimationCurve curve)
		{
			this.name = name;
			this.flags = (AnimationCurveFlags)0;
			this.curve = curve;
		}

		/// <summary>Constructs a new named animation curve.</summary>
		/// <param name="name">Name of the curve.</param>
		/// <param name="flags">Flags that describe the animation curve.</param>
		/// <param name="curve">Curve containing the animation data.</param>
		public NamedFloatCurve(string name, AnimationCurveFlags flags, AnimationCurve curve)
		{
			this.name = name;
			this.flags = (AnimationCurveFlags)0;
			this.curve = curve;
		}

		/// <summary>Name of the curve.</summary>
		public string name;
		/// <summary>Flags that describe the animation curve.</summary>
		public AnimationCurveFlags flags;
		/// <summary>Actual curve containing animation data.</summary>
		public AnimationCurve curve;
	}

	/** @} */

	/** @addtogroup Animation
	 *  @{
	 */

	/// <summary>An animation curve and its name.</summary>
	[StructLayout(LayoutKind.Sequential), SerializeObject]
	public partial struct NamedVector3Curve
	{
		/// <summary>Initializes the struct with default values.</summary>
		public static NamedVector3Curve Default()
		{
			NamedVector3Curve value = new NamedVector3Curve();
			value.name = "";
			value.flags = (AnimationCurveFlags)0;
			value.curve = null;

			return value;
		}

		/// <summary>Constructs a new named animation curve.</summary>
		/// <param name="name">Name of the curve.</param>
		/// <param name="curve">Curve containing the animation data.</param>
		public NamedVector3Curve(string name, Vector3Curve curve)
		{
			this.name = name;
			this.flags = (AnimationCurveFlags)0;
			this.curve = curve;
		}

		/// <summary>Constructs a new named animation curve.</summary>
		/// <param name="name">Name of the curve.</param>
		/// <param name="flags">Flags that describe the animation curve.</param>
		/// <param name="curve">Curve containing the animation data.</param>
		public NamedVector3Curve(string name, AnimationCurveFlags flags, Vector3Curve curve)
		{
			this.name = name;
			this.flags = (AnimationCurveFlags)0;
			this.curve = curve;
		}

		/// <summary>Name of the curve.</summary>
		public string name;
		/// <summary>Flags that describe the animation curve.</summary>
		public AnimationCurveFlags flags;
		/// <summary>Actual curve containing animation data.</summary>
		public Vector3Curve curve;
	}

	/** @} */

	/** @addtogroup Animation
	 *  @{
	 */

	/// <summary>An animation curve and its name.</summary>
	[StructLayout(LayoutKind.Sequential), SerializeObject]
	public partial struct NamedQuaternionCurve
	{
		/// <summary>Initializes the struct with default values.</summary>
		public static NamedQuaternionCurve Default()
		{
			NamedQuaternionCurve value = new NamedQuaternionCurve();
			value.name = "";
			value.flags = (AnimationCurveFlags)0;
			value.curve = null;

			return value;
		}

		/// <summary>Constructs a new named animation curve.</summary>
		/// <param name="name">Name of the curve.</param>
		/// <param name="curve">Curve containing the animation data.</param>
		public NamedQuaternionCurve(string name, QuaternionCurve curve)
		{
			this.name = name;
			this.flags = (AnimationCurveFlags)0;
			this.curve = curve;
		}

		/// <summary>Constructs a new named animation curve.</summary>
		/// <param name="name">Name of the curve.</param>
		/// <param name="flags">Flags that describe the animation curve.</param>
		/// <param name="curve">Curve containing the animation data.</param>
		public NamedQuaternionCurve(string name, AnimationCurveFlags flags, QuaternionCurve curve)
		{
			this.name = name;
			this.flags = (AnimationCurveFlags)0;
			this.curve = curve;
		}

		/// <summary>Name of the curve.</summary>
		public string name;
		/// <summary>Flags that describe the animation curve.</summary>
		public AnimationCurveFlags flags;
		/// <summary>Actual curve containing animation data.</summary>
		public QuaternionCurve curve;
	}

	/** @} */
}
