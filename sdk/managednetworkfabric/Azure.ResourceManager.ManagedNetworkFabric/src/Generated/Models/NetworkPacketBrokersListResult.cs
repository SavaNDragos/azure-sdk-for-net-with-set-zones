// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of NetworkPacketBrokers. </summary>
    internal partial class NetworkPacketBrokersListResult
    {
        /// <summary> Initializes a new instance of NetworkPacketBrokersListResult. </summary>
        internal NetworkPacketBrokersListResult()
        {
            Value = new ChangeTrackingList<NetworkPacketBrokerData>();
        }

        /// <summary> Initializes a new instance of NetworkPacketBrokersListResult. </summary>
        /// <param name="value"> List of NetworkPacketBroker resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal NetworkPacketBrokersListResult(IReadOnlyList<NetworkPacketBrokerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of NetworkPacketBroker resources. </summary>
        public IReadOnlyList<NetworkPacketBrokerData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
