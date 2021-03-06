﻿/*	Copyright 2012 Brent Scriver

	Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at

		http://www.apache.org/licenses/LICENSE-2.0

	Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.
*/

namespace OneOddSock.Compression.Arithmetic
{
    /// <summary>
    /// Provides the range and the corresponding symbol from the model.
    /// </summary>
    public struct RangeSymbol<TSymbolType>
        where TSymbolType : struct
    {
        /// <summary>
        /// Range of the symbol [Low, High).
        /// </summary>
        public Range Range { get; set; }

        /// <summary>
        /// Symbol represented by the range in the model.
        /// </summary>
        public TSymbolType Symbol { get; set; }
    }
}