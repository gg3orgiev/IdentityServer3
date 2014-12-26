﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Models;

namespace Thinktecture.IdentityServer.Core.Validation.Logging
{
    class TokenValidationLog
    {
        // identity token
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string IdentityTokenSigningKeyType { get; set; }
        public bool ValidateLifetime { get; set; }

        // access token
        public string AccessTokenType { get; set; }
        public string ExpectedScope { get; set; }
        public string TokenHandle { get; set; }

        // both
        public Dictionary<string, object> Claims { get; set; }
    }
}
