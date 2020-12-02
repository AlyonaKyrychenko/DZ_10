namespace DZ10
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  This class for confection.
    /// </summary>
    internal class Confection
    {
        private float weight;
        private DateTime expirationDate;
        private string name;

        /// <summary>
        ///  Gets or sets .
        /// </summary>
        public float Weight { get => this.weight; set => this.weight = value; }

        /// <summary>
        ///  Gets or sets .
        /// </summary>
        public DateTime ExpirationDate { get => this.expirationDate; set => this.expirationDate = value; }

        /// <summary>
        ///  Gets or sets .
        /// </summary>
        public string Name { get => this.name; set => this.name = value; }
    }
}
