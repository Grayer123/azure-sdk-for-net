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
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// This object encapsulates localized status message from the Guest Agent.
    /// </summary>
    public partial class FormattedMessage
    {
        private string _language;
        
        /// <summary>
        /// Optional. Language code. Eg. "en-US"
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }
        
        private string _message;
        
        /// <summary>
        /// Optional. A string containing message about status of the Guest
        /// Agent, or Resource Extension.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the FormattedMessage class.
        /// </summary>
        public FormattedMessage()
        {
        }
    }
}
