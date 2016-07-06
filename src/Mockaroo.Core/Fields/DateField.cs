﻿using Newtonsoft.Json;
using System;

namespace Gigobyte.Mockaroo.Fields
{
    public partial class DateField
    {
        /// <summary>
        /// Gets or sets the minimum date.
        /// </summary>
        /// <value>The minimum date.</value>
        [JsonProperty("min")]
        public DateTime Min { get; set; } = new DateTime(1975, 04, 04);

        /// <summary>
        /// Gets or sets the maximum date.
        /// </summary>
        /// <value>The maximum date.</value>
        [JsonProperty("max")]
        public DateTime Max { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets The format to output. This can be any format directive supported by ruby see
        /// more at http://ruby-doc.org/core-1.9.3/Time.html#method-i-strftime. Defaults to ISO 8601 format.
        /// </summary>
        /// <value>The format to output.</value>
        [JsonProperty("format")]
        public string Format { get; set; } = "%F %T";
    }
}