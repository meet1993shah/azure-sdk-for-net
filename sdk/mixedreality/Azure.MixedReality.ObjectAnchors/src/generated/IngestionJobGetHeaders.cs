// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.MixedReality.ObjectAnchors
{
    internal partial class IngestionJobGetHeaders
    {
        private readonly Response _response;
        public IngestionJobGetHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The service response correlation vector, which will be a new value for every response. </summary>
        public string MsCv => _response.Headers.TryGetValue("ms-cv", out string value) ? value : null;
    }
}
