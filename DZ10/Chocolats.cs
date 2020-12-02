namespace DZ10
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  This class for Chocolats.
    /// </summary>
    internal class Chocolats : Confection
    {
        private bool withNuts;
        private Colour colour;

        /// <summary>
        /// Initializes a new instance of the <see cref="Chocolats"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="weight">weight.</param>
        /// <param name="colour">colour.</param>
        /// <param name="withNuts">withNuts.</param>
        /// /// <param name="expDate">expDate.</param>
        public Chocolats(string name, float weight, Colour colour, bool withNuts, DateTime expDate)
        {
            this.Name = name;
            this.Weight = weight;
            this.colour = colour;
            this.WithNuts = withNuts;
            this.ExpirationDate = expDate;
        }

        /// <summary>
        ///  Gets or sets a value indicating whether gets or sets .
        /// </summary>
        public bool WithNuts { get => this.withNuts; set => this.withNuts = value; }

        /// <summary>
        ///  Gets or sets a value indicating whether gets or sets .
        /// </summary>
        public Colour Colour { get => this.colour; set => this.colour = value; }
    }
}
