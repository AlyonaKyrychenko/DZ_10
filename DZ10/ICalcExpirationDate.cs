namespace DZ10
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  This is interface for calculating expiration date.
    /// </summary>
    internal interface ICalcExpirationDate
    {
        /// <summary>
        /// This is method for calculating expiration date.
        /// </summary>
        /// <returns>DateTime expiration date.</returns>
        DateTime CalcExpirationDate();
    }
}
