﻿/*
 * Copyright 2014, 2015 Dominick Baier, Brock Allen
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

using System.Collections.Generic;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Validation;

namespace Thinktecture.IdentityServer.Core.Services
{
    /// <summary>
    /// The client validator turn some credential on an incoming HTTP request into a Client
    /// </summary>
    public interface IClientValidator
    {
        /// <summary>
        /// Validates the incoming HTTP request
        /// </summary>
        /// <param name="environment">The environment.</param>
        /// <returns>A validation result</returns>
        Task<ClientValidationResult> ValidateAsync(IDictionary<string, object> environment);
    }
}