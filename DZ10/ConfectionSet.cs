namespace DZ10
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  This class for confection set.
    /// </summary>
    internal class ConfectionSet : ICalcWeight, ICalcExpirationDate
    {
        private List<Confection> composition;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfectionSet"/> class.
        /// </summary>
        public ConfectionSet()
        {
            this.composition = new List<Confection>();
        }

        /// <summary>
        /// Add to collection.
        /// </summary>
        /// <param name="ob">object.</param>
        public void AddToSet(Confection ob)
        {
            this.composition.Add(ob);
        }

        /// <inheritdoc/>
        float ICalcWeight.CalcWeight()
        {
            float weight = 0;
            foreach (Confection ob in this.composition)
            {
                weight += ob.Weight;
            }

            return weight;
        }

        /// <inheritdoc/>
        DateTime ICalcExpirationDate.CalcExpirationDate()
        {
            DateTime expDate = DateTime.MaxValue;
            foreach (Confection ob in this.composition)
            {
                if (ob.ExpirationDate < expDate)
                {
                    expDate = ob.ExpirationDate;
                }
            }

            return expDate;
        }
    }
}
