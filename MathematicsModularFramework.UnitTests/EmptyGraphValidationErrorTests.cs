﻿/*
 * Copyright 2016 Alastair Wyse (http://www.oraclepermissiongenerator.net/mathematicsmodularframework/)
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
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
using NUnit.Framework;
using MathematicsModularFramework;
using MathematicsModularFramework.UnitTests.TestModules;

namespace MathematicsModularFramework.UnitTests
{
    /// <summary>
    /// Unit tests for class MathematicsModularFramework.EmptyGraphValidationError.
    /// </summary>
    public class EmptyGraphValidationErrorTests
    {
        /// <summary>
        /// Success test for method ToString().
        /// </summary>
        [Test]
        public new void ToString()
        {
            EmptyGraphValidationError testEmptyGraphValidationError = new EmptyGraphValidationError();

            Assert.AreEqual("Graph is empty.", testEmptyGraphValidationError.ToString());
        }
    }
}
