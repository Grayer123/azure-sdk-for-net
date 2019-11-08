// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the properties of a latency metric used in the latency
    /// scorecard
    /// </summary>
    public partial class LatencyMetric
    {
        /// <summary>
        /// Initializes a new instance of the LatencyMetric class.
        /// </summary>
        public LatencyMetric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LatencyMetric class.
        /// </summary>
        /// <param name="name">The name of the Latency Metric</param>
        /// <param name="endDateTimeUTC">The end time of the Latency Scorecard
        /// in UTC</param>
        /// <param name="aValue">The metric value of the A endpoint</param>
        /// <param name="bValue">The metric value of the B endpoint</param>
        /// <param name="delta">The difference in value between endpoint A and
        /// B</param>
        /// <param name="deltaPercent">The percent difference between endpoint
        /// A and B</param>
        /// <param name="aCLower95CI">The lower end of the 95% confidence
        /// interval for endpoint A</param>
        /// <param name="aHUpper95CI">The upper end of the 95% confidence
        /// interval for endpoint A</param>
        /// <param name="bCLower95CI">The lower end of the 95% confidence
        /// interval for endpoint B</param>
        /// <param name="bUpper95CI">The upper end of the 95% confidence
        /// interval for endpoint B</param>
        public LatencyMetric(string name = default(string), string endDateTimeUTC = default(string), double? aValue = default(double?), double? bValue = default(double?), double? delta = default(double?), double? deltaPercent = default(double?), double? aCLower95CI = default(double?), double? aHUpper95CI = default(double?), double? bCLower95CI = default(double?), double? bUpper95CI = default(double?))
        {
            Name = name;
            EndDateTimeUTC = endDateTimeUTC;
            AValue = aValue;
            BValue = bValue;
            Delta = delta;
            DeltaPercent = deltaPercent;
            ACLower95CI = aCLower95CI;
            AHUpper95CI = aHUpper95CI;
            BCLower95CI = bCLower95CI;
            BUpper95CI = bUpper95CI;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the Latency Metric
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the end time of the Latency Scorecard in UTC
        /// </summary>
        [JsonProperty(PropertyName = "endDateTimeUTC")]
        public string EndDateTimeUTC { get; private set; }

        /// <summary>
        /// Gets the metric value of the A endpoint
        /// </summary>
        [JsonProperty(PropertyName = "aValue")]
        public double? AValue { get; private set; }

        /// <summary>
        /// Gets the metric value of the B endpoint
        /// </summary>
        [JsonProperty(PropertyName = "bValue")]
        public double? BValue { get; private set; }

        /// <summary>
        /// Gets the difference in value between endpoint A and B
        /// </summary>
        [JsonProperty(PropertyName = "delta")]
        public double? Delta { get; private set; }

        /// <summary>
        /// Gets the percent difference between endpoint A and B
        /// </summary>
        [JsonProperty(PropertyName = "deltaPercent")]
        public double? DeltaPercent { get; private set; }

        /// <summary>
        /// Gets the lower end of the 95% confidence interval for endpoint A
        /// </summary>
        [JsonProperty(PropertyName = "aCLower95CI")]
        public double? ACLower95CI { get; private set; }

        /// <summary>
        /// Gets the upper end of the 95% confidence interval for endpoint A
        /// </summary>
        [JsonProperty(PropertyName = "aHUpper95CI")]
        public double? AHUpper95CI { get; private set; }

        /// <summary>
        /// Gets the lower end of the 95% confidence interval for endpoint B
        /// </summary>
        [JsonProperty(PropertyName = "bCLower95CI")]
        public double? BCLower95CI { get; private set; }

        /// <summary>
        /// Gets the upper end of the 95% confidence interval for endpoint B
        /// </summary>
        [JsonProperty(PropertyName = "bUpper95CI")]
        public double? BUpper95CI { get; private set; }

    }
}