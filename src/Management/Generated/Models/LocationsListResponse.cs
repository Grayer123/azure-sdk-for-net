// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure.Management.Models
{
    /// <summary>
    /// The List Locations operation response.
    /// </summary>
    public partial class LocationsListResponse : OperationResponse, IEnumerable<LocationsListResponse.Location>
    {
        private IList<LocationsListResponse.Location> _locations;
        
        /// <summary>
        /// Optional. The data center locations that are valid for your
        /// subscription.
        /// </summary>
        public IList<LocationsListResponse.Location> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LocationsListResponse class.
        /// </summary>
        public LocationsListResponse()
        {
            this._locations = new List<LocationsListResponse.Location>();
        }
        
        /// <summary>
        /// Gets the sequence of Locations.
        /// </summary>
        public IEnumerator<LocationsListResponse.Location> GetEnumerator()
        {
            return this.Locations.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Locations.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// A data center location that is valid for your subscription.
        /// </summary>
        public partial class Location
        {
            private IList<string> _availableServices;
            
            /// <summary>
            /// Optional. Indicates the services available at a location.
            /// </summary>
            public IList<string> AvailableServices
            {
                get { return this._availableServices; }
                set { this._availableServices = value; }
            }
            
            private string _displayName;
            
            /// <summary>
            /// Optional. The localized name of data center location.
            /// </summary>
            public string DisplayName
            {
                get { return this._displayName; }
                set { this._displayName = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The name of a data center location that is valid for
            /// your subscription.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the Location class.
            /// </summary>
            public Location()
            {
                this._availableServices = new List<string>();
            }
        }
    }
}
