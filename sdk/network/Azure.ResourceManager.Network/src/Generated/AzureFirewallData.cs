// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the AzureFirewall data model. </summary>
    public partial class AzureFirewallData : Resource
    {
        /// <summary> Initializes a new instance of AzureFirewallData. </summary>
        public AzureFirewallData()
        {
            Zones = new ChangeTrackingList<string>();
            ApplicationRuleCollections = new ChangeTrackingList<AzureFirewallApplicationRuleCollection>();
            NatRuleCollections = new ChangeTrackingList<AzureFirewallNatRuleCollection>();
            NetworkRuleCollections = new ChangeTrackingList<AzureFirewallNetworkRuleCollection>();
            IpConfigurations = new ChangeTrackingList<AzureFirewallIPConfiguration>();
            IpGroups = new ChangeTrackingList<AzureFirewallIpGroups>();
            AdditionalProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of AzureFirewallData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="zones"> A list of availability zones denoting where the resource needs to come from. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="applicationRuleCollections"> Collection of application rule collections used by Azure Firewall. </param>
        /// <param name="natRuleCollections"> Collection of NAT rule collections used by Azure Firewall. </param>
        /// <param name="networkRuleCollections"> Collection of network rule collections used by Azure Firewall. </param>
        /// <param name="ipConfigurations"> IP configuration of the Azure Firewall resource. </param>
        /// <param name="managementIpConfiguration"> IP configuration of the Azure Firewall used for management traffic. </param>
        /// <param name="provisioningState"> The provisioning state of the Azure firewall resource. </param>
        /// <param name="threatIntelMode"> The operation mode for Threat Intelligence. </param>
        /// <param name="virtualHub"> The virtualHub to which the firewall belongs. </param>
        /// <param name="firewallPolicy"> The firewallPolicy associated with this azure firewall. </param>
        /// <param name="hubIPAddresses"> IP addresses associated with AzureFirewall. </param>
        /// <param name="ipGroups"> IpGroups associated with AzureFirewall. </param>
        /// <param name="sku"> The Azure Firewall Resource SKU. </param>
        /// <param name="additionalProperties"> The additional properties used to further config this azure firewall. </param>
        internal AzureFirewallData(string id, string name, string type, string location, IDictionary<string, string> tags, IList<string> zones, string etag, IList<AzureFirewallApplicationRuleCollection> applicationRuleCollections, IList<AzureFirewallNatRuleCollection> natRuleCollections, IList<AzureFirewallNetworkRuleCollection> networkRuleCollections, IList<AzureFirewallIPConfiguration> ipConfigurations, AzureFirewallIPConfiguration managementIpConfiguration, ProvisioningState? provisioningState, AzureFirewallThreatIntelMode? threatIntelMode, SubResource virtualHub, SubResource firewallPolicy, HubIPAddresses hubIPAddresses, IReadOnlyList<AzureFirewallIpGroups> ipGroups, AzureFirewallSku sku, IDictionary<string, string> additionalProperties) : base(id, name, type, location, tags)
        {
            Zones = zones;
            Etag = etag;
            ApplicationRuleCollections = applicationRuleCollections;
            NatRuleCollections = natRuleCollections;
            NetworkRuleCollections = networkRuleCollections;
            IpConfigurations = ipConfigurations;
            ManagementIpConfiguration = managementIpConfiguration;
            ProvisioningState = provisioningState;
            ThreatIntelMode = threatIntelMode;
            VirtualHub = virtualHub;
            FirewallPolicy = firewallPolicy;
            HubIPAddresses = hubIPAddresses;
            IpGroups = ipGroups;
            Sku = sku;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> A list of availability zones denoting where the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Collection of application rule collections used by Azure Firewall. </summary>
        public IList<AzureFirewallApplicationRuleCollection> ApplicationRuleCollections { get; }
        /// <summary> Collection of NAT rule collections used by Azure Firewall. </summary>
        public IList<AzureFirewallNatRuleCollection> NatRuleCollections { get; }
        /// <summary> Collection of network rule collections used by Azure Firewall. </summary>
        public IList<AzureFirewallNetworkRuleCollection> NetworkRuleCollections { get; }
        /// <summary> IP configuration of the Azure Firewall resource. </summary>
        public IList<AzureFirewallIPConfiguration> IpConfigurations { get; }
        /// <summary> IP configuration of the Azure Firewall used for management traffic. </summary>
        public AzureFirewallIPConfiguration ManagementIpConfiguration { get; set; }
        /// <summary> The provisioning state of the Azure firewall resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The operation mode for Threat Intelligence. </summary>
        public AzureFirewallThreatIntelMode? ThreatIntelMode { get; set; }
        /// <summary> The virtualHub to which the firewall belongs. </summary>
        public SubResource VirtualHub { get; set; }
        /// <summary> The firewallPolicy associated with this azure firewall. </summary>
        public SubResource FirewallPolicy { get; set; }
        /// <summary> IP addresses associated with AzureFirewall. </summary>
        public HubIPAddresses HubIPAddresses { get; set; }
        /// <summary> IpGroups associated with AzureFirewall. </summary>
        public IReadOnlyList<AzureFirewallIpGroups> IpGroups { get; }
        /// <summary> The Azure Firewall Resource SKU. </summary>
        public AzureFirewallSku Sku { get; set; }
        /// <summary> The additional properties used to further config this azure firewall. </summary>
        public IDictionary<string, string> AdditionalProperties { get; }
    }
}
