﻿using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Gigobyte.Mockaroo.Fields
{
    /// <summary>
    /// Defines methods and properties that represents a Mockaroo data type.
    /// </summary>
    public interface IField
    {
        /// <summary>
        /// Gets or sets the identifier of this field.
        /// </summary>
        /// <value>The name.</value>
        
        string Name { get; set; }

        /// <summary>
        /// Gets the data type.
        /// </summary>
        /// <value>The data type.</value>
        
        DataType Type { get; }

        /// <summary>
        /// Gets or sets the Ruby script to generate data based on custom logic. see more at https://mockaroo.com/help/formulas
        /// </summary>
        /// <value>The formula.</value>
        
        string Formula { get; set; }

        /// <summary>
        /// Gets or sets an integer between 0 and 100 that determines what percent of the generated
        /// values will be null
        /// </summary>
        /// <value>The percent blank.</value>
        
        int BlankPercentage { get; set; }

        /// <summary>
        /// Converts this instance into its equivalent json representation.
        /// </summary>
        /// <returns>A json representation of the instance.</returns>
        string ToJson();
    }
}