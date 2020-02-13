﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;

namespace Microsoft.Azure.WebJobs.Extensions.SignalRService
{
    internal class OpenConnectionMessage : ISignalRServerlessMessage
    {
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }
    }
}
