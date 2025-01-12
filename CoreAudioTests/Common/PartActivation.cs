﻿// -----------------------------------------
// SoundScribe (TM) and related software.
// 
// Copyright (C) 2007-2011 Vannatech
// http://www.vannatech.com
// All rights reserved.
// 
// This source code is subject to the MIT License.
// http://www.opensource.org/licenses/mit-license.php
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// -----------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreAudio.Constants;
using CoreAudio.Enumerations;
using CoreAudio.Externals;
using CoreAudio.Interfaces;

namespace CoreAudioTests.Common
{
	/// <summary>
	/// Used for returning IPart interface along with actived interfaces.
	/// </summary>
	/// <typeparam name="T">The activated interface type.</typeparam>
	public class PartActivation<T> : IDisposable
	{
		/// <summary>
		/// The IPart instance.
		/// </summary>
		public IPart Part
		{
			get;
			set;
		}

		/// <summary>
		/// The activated interface.
		/// </summary>
		public T ActiveInterface
		{
			get;
			set;
		}

		/// <summary>
		/// Disposes of the object, releasing all internal COM references.
		/// </summary>
		public void Dispose()
		{
			Marshal.FinalReleaseComObject(Part);
			Marshal.FinalReleaseComObject(ActiveInterface);
		}
	}
}
