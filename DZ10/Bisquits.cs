namespace DZ10
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  This class for Bisquits.
    /// </summary>
    internal class Bisquits : Confection
    {
        private PackType pack;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bisquits"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="weight">weight.</param>
        /// <param name="pack">pack.</param>
        /// /// <param name="expDate">expDate.</param>
        public Bisquits(string name, float weight, PackType pack, DateTime expDate)
        {
            this.Name = name;
            this.Weight = weight;
            this.ExpirationDate = expDate;
            this.Pack = pack;
        }

        /// <summary>
        ///  Gets or sets .
        /// </summary>
        public PackType Pack { get => this.pack; set => this.pack = value; }
    }
}
