using System;

namespace IntXLib
{
	/// <summary>
	/// Used to retrieve needed divider.
	/// </summary>
	static internal class DivideManager
	{
		#region Fields

		/// <summary>
		/// Classic divider instance.
		/// </summary>
		static readonly public IDivider ClassicDivider;

		/// <summary>
		/// Newton divider instance.
		/// </summary>
		static readonly public IDivider AutoNewtonDivider;

		#endregion Fields

		#region Constructors

		// .cctor
		static DivideManager()
		{
			// Create new classic divider instance
			IDivider classicDivider = new ClassicDivider();

			// Fill publicity visible divider fields
			ClassicDivider = classicDivider;
			AutoNewtonDivider = new AutoNewtonDivider(classicDivider);
		}

		#endregion Constructors

		#region Methods

		/// <summary>
		/// Returns divider instance for given divide mode.
		/// </summary>
		/// <param name="mode">Divide mode.</param>
		/// <returns>Divider instance.</returns>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="mode" /> is out of range.</exception>
		static public IDivider GetDivider(DivideMode mode)
		{
			switch (mode)
			{
				case DivideMode.AutoNewton:
					return AutoNewtonDivider;
				case DivideMode.Classic:
					return ClassicDivider;
				default:
					throw new ArgumentOutOfRangeException("mode");
			}
		}

		/// <summary>
		/// Returns current divider instance.
		/// </summary>
		/// <returns>Current divider instance.</returns>
		static public IDivider GetCurrentDivider()
		{
			return GetDivider(IntX.GlobalSettings.DivideMode);
		}

		#endregion Methods
	}
}
