// 
// File.cs
//  
// Author:
//       Bojan Rajkovic <brajkovic@coderinserepeat.com>
// 
// Copyright (c) 2011 Bojan Rajkovic
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;

namespace CodeRinseRepeat.Deluge
{
	public class File
	{
		public static class Fields
		{
			public const string Index = "index";
			public const string Path = "path";
			public const string Offset = "offset";
			public const string Size = "size";
		}

		public override string ToString () {
			return string.Format ("[File: Index={0}, Path={1}, Offset={2}, Size={3}, Priority={4}, Progress={5}]", Index, Path, Offset, Size, Priority, Progress);
		}

		public long Index { get; internal set; }
		public string Path { get; internal set; }
		public long Offset { get; internal set; }
		public long Size { get; internal set; }

		// TODO: Turn this into a proper enum.
		public long Priority { get; internal set; }

		public double Progress { get; internal set; }
	}
}

