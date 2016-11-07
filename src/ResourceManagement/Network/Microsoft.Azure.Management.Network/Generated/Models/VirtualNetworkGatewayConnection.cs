// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// A common class for general resource information
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkGatewayConnection : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayConnection
        /// class.
        /// </summary>
        public VirtualNetworkGatewayConnection() { }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayConnection
        /// class.
        /// </summary>
        /// <param name="connectionType">Gateway connection type. Possible
        /// values are: 'Ipsec','Vnet2Vnet','ExpressRoute', and 'VPNClient.
        /// Possible values include: 'IPsec', 'Vnet2Vnet', 'ExpressRoute',
        /// 'VPNClient'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="authorizationKey">The authorizationKey.</param>
        /// <param name="routingWeight">The routing weight.</param>
        /// <param name="sharedKey">The IPSec shared key.</param>
        /// <param name="connectionStatus">Virtual network Gateway connection
        /// status. Possible values are 'Unknown', 'Connecting', 'Connected'
        /// and 'NotConnected'. Possible values include: 'Unknown',
        /// 'Connecting', 'Connected', 'NotConnected'</param>
        /// <param name="tunnelConnectionStatus">Collection of all tunnels'
        /// connection health status.</param>
        /// <param name="egressBytesTransferred">The egress bytes transferred
        /// in this connection.</param>
        /// <param name="ingressBytesTransferred">The ingress bytes
        /// transferred in this connection.</param>
        /// <param name="peer">The reference to peerings resource.</param>
        /// <param name="enableBgp">EnableBgp flag</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// VirtualNetworkGatewayConnection resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// VirtualNetworkGatewayConnection resource. Possible values are:
        /// 'Updating', 'Deleting', and 'Failed'.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public VirtualNetworkGatewayConnection(VirtualNetworkGateway virtualNetworkGateway1, string connectionType, string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string authorizationKey = default(string), VirtualNetworkGateway virtualNetworkGateway2 = default(VirtualNetworkGateway), LocalNetworkGateway localNetworkGateway2 = default(LocalNetworkGateway), int? routingWeight = default(int?), string sharedKey = default(string), string connectionStatus = default(string), System.Collections.Generic.IList<TunnelConnectionHealth> tunnelConnectionStatus = default(System.Collections.Generic.IList<TunnelConnectionHealth>), long? egressBytesTransferred = default(long?), long? ingressBytesTransferred = default(long?), SubResource peer = default(SubResource), bool? enableBgp = default(bool?), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            AuthorizationKey = authorizationKey;
            VirtualNetworkGateway1 = virtualNetworkGateway1;
            VirtualNetworkGateway2 = virtualNetworkGateway2;
            LocalNetworkGateway2 = localNetworkGateway2;
            ConnectionType = connectionType;
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            ConnectionStatus = connectionStatus;
            TunnelConnectionStatus = tunnelConnectionStatus;
            EgressBytesTransferred = egressBytesTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            Peer = peer;
            EnableBgp = enableBgp;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets the authorizationKey.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.virtualNetworkGateway1")]
        public VirtualNetworkGateway VirtualNetworkGateway1 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.virtualNetworkGateway2")]
        public VirtualNetworkGateway VirtualNetworkGateway2 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.localNetworkGateway2")]
        public LocalNetworkGateway LocalNetworkGateway2 { get; set; }

        /// <summary>
        /// Gets or sets gateway connection type. Possible values are:
        /// 'Ipsec','Vnet2Vnet','ExpressRoute', and 'VPNClient. Possible
        /// values include: 'IPsec', 'Vnet2Vnet', 'ExpressRoute', 'VPNClient'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.connectionType")]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets the routing weight.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.routingWeight")]
        public int? RoutingWeight { get; set; }

        /// <summary>
        /// Gets or sets the IPSec shared key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets virtual network Gateway connection status. Possible values
        /// are 'Unknown', 'Connecting', 'Connected' and 'NotConnected'.
        /// Possible values include: 'Unknown', 'Connecting', 'Connected',
        /// 'NotConnected'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.connectionStatus")]
        public string ConnectionStatus { get; private set; }

        /// <summary>
        /// Gets collection of all tunnels' connection health status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tunnelConnectionStatus")]
        public System.Collections.Generic.IList<TunnelConnectionHealth> TunnelConnectionStatus { get; private set; }

        /// <summary>
        /// Gets the egress bytes transferred in this connection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.egressBytesTransferred")]
        public long? EgressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets the ingress bytes transferred in this connection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ingressBytesTransferred")]
        public long? IngressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets or sets the reference to peerings resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.peer")]
        public SubResource Peer { get; set; }

        /// <summary>
        /// Gets or sets enableBgp flag
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enableBgp")]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// Gets or sets the resource GUID property of the
        /// VirtualNetworkGatewayConnection resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets the provisioning state of the VirtualNetworkGatewayConnection
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualNetworkGateway1 == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "VirtualNetworkGateway1");
            }
            if (ConnectionType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ConnectionType");
            }
            if (this.VirtualNetworkGateway1 != null)
            {
                this.VirtualNetworkGateway1.Validate();
            }
            if (this.VirtualNetworkGateway2 != null)
            {
                this.VirtualNetworkGateway2.Validate();
            }
            if (this.LocalNetworkGateway2 != null)
            {
                this.LocalNetworkGateway2.Validate();
            }
        }
    }
}
