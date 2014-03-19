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
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// Parameters supplied to the Update Web Site operation.
    /// </summary>
    public partial class WebSiteUpdateParameters
    {
        private Microsoft.WindowsAzure.Management.WebSites.Models.WebSpaceAvailabilityState? _availabilityState;
        
        /// <summary>
        /// Optional. The state of the availability of management information
        /// for the site. Possible values are Normal or Limited. Normal means
        /// that the site is running correctly and that management information
        /// for the site is available. Limited means that only partial
        /// management information for the site is available and that detailed
        /// site information is unavailable.
        /// </summary>
        public Microsoft.WindowsAzure.Management.WebSites.Models.WebSpaceAvailabilityState? AvailabilityState
        {
            get { return this._availabilityState; }
            set { this._availabilityState = value; }
        }
        
        private Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteComputeMode? _computeMode;
        
        /// <summary>
        /// Optional. The Compute Mode for the web site. Possible values are
        /// Shared or Dedicated.
        /// </summary>
        public Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteComputeMode? ComputeMode
        {
            get { return this._computeMode; }
            set { this._computeMode = value; }
        }
        
        private bool? _enabled;
        
        /// <summary>
        /// Optional. true if the site is enabled; otherwise, false. Setting
        /// this value to false disables the site (takes the site off line).
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }
        
        private IList<string> _hostNames;
        
        /// <summary>
        /// Optional. An array of strings that contains the public hostnames
        /// for the site, including custom domains. Important: When you add a
        /// custom domain in a PUT operation, be sure to include every
        /// hostname that you want for the web site. To delete a custom domain
        /// name in a PUT operation, include all of the hostnames for the site
        /// that you want to keep, but leave out the one that you wangt to
        /// delete.
        /// </summary>
        public IList<string> HostNames
        {
            get { return this._hostNames; }
            set { this._hostNames = value; }
        }
        
        private IList<WebSiteUpdateParameters.WebSiteHostNameSslState> _hostNameSslStates;
        
        /// <summary>
        /// Optional. SSL states bound to the website.
        /// </summary>
        public IList<WebSiteUpdateParameters.WebSiteHostNameSslState> HostNameSslStates
        {
            get { return this._hostNameSslStates; }
            set { this._hostNameSslStates = value; }
        }
        
        private Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteRuntimeAvailabilityState? _runtimeAvailabilityState;
        
        /// <summary>
        /// Optional. Possible values are Normal, Degraded, or NotAvailable.
        /// Normal: the web site is running correctly. Degraded: the web site
        /// is running temporarily in a degraded mode (typically with less
        /// memory and a shared instance.) Not Available: due to an unexpected
        /// issue, the site has been excluded from provisioning. This
        /// typically occurs only for free sites.
        /// </summary>
        public Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteRuntimeAvailabilityState? RuntimeAvailabilityState
        {
            get { return this._runtimeAvailabilityState; }
            set { this._runtimeAvailabilityState = value; }
        }
        
        private string _serverFarm;
        
        /// <summary>
        /// Optional. String. If a server farm exists, this value is
        /// DefaultServerFarm.
        /// </summary>
        public string ServerFarm
        {
            get { return this._serverFarm; }
            set { this._serverFarm = value; }
        }
        
        private Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteMode? _siteMode;
        
        /// <summary>
        /// Optional. String that represents the web site mode. If the web site
        /// mode is Free, this value is Limited. If the web site mode is
        /// Shared, this value is Basic.  Note: The SiteMode value is not used
        /// for Reserved mode. Reserved mode uses the ComputeMode setting.
        /// </summary>
        public Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteMode? SiteMode
        {
            get { return this._siteMode; }
            set { this._siteMode = value; }
        }
        
        private IList<WebSiteUpdateParameters.WebSiteSslCertificate> _sslCertificates;
        
        /// <summary>
        /// Optional. SSL certificates bound to the web site.
        /// </summary>
        public IList<WebSiteUpdateParameters.WebSiteSslCertificate> SslCertificates
        {
            get { return this._sslCertificates; }
            set { this._sslCertificates = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. A string that describes the state of the web site.
        /// Possible values include Stopped, Running or QuotaExceeded.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteUpdateParameters class.
        /// </summary>
        public WebSiteUpdateParameters()
        {
            this._hostNames = new List<string>();
            this._hostNameSslStates = new List<WebSiteUpdateParameters.WebSiteHostNameSslState>();
            this._sslCertificates = new List<WebSiteUpdateParameters.WebSiteSslCertificate>();
        }
        
        /// <summary>
        /// SSL states bound to a website.
        /// </summary>
        public partial class WebSiteHostNameSslState
        {
            private Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteSslState? _sslState;
            
            /// <summary>
            /// Optional. The SSL state. Possible values are Disabled,
            /// SniEnabled, or IpBasedEnabled.
            /// </summary>
            public Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteSslState? SslState
            {
                get { return this._sslState; }
                set { this._sslState = value; }
            }
            
            private string _thumbprint;
            
            /// <summary>
            /// Optional. A string that contains the thumbprint of the SSL
            /// certificate.
            /// </summary>
            public string Thumbprint
            {
                get { return this._thumbprint; }
                set { this._thumbprint = value; }
            }
            
            private bool? _toUpdate;
            
            /// <summary>
            /// Optional.
            /// </summary>
            public bool? ToUpdate
            {
                get { return this._toUpdate; }
                set { this._toUpdate = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the WebSiteHostNameSslState class.
            /// </summary>
            public WebSiteHostNameSslState()
            {
            }
        }
        
        /// <summary>
        /// Contains SSL certificate properties.
        /// </summary>
        public partial class WebSiteSslCertificate
        {
            private bool? _isToBeDeleted;
            
            /// <summary>
            /// Optional. Boolean. true if the certificate is to be deleted.
            /// </summary>
            public bool? IsToBeDeleted
            {
                get { return this._isToBeDeleted; }
                set { this._isToBeDeleted = value; }
            }
            
            private string _password;
            
            /// <summary>
            /// Optional. A string that contains the password for the
            /// certificate.
            /// </summary>
            public string Password
            {
                get { return this._password; }
                set { this._password = value; }
            }
            
            private byte[] _pfxBlob;
            
            /// <summary>
            /// Optional. A base64Binary value that contains the PfxBlob of the
            /// certificate.
            /// </summary>
            public byte[] PfxBlob
            {
                get { return this._pfxBlob; }
                set { this._pfxBlob = value; }
            }
            
            private string _thumbprint;
            
            /// <summary>
            /// Optional. A string that contains the certificate thumbprint.
            /// </summary>
            public string Thumbprint
            {
                get { return this._thumbprint; }
                set { this._thumbprint = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the WebSiteSslCertificate class.
            /// </summary>
            public WebSiteSslCertificate()
            {
            }
        }
    }
}
