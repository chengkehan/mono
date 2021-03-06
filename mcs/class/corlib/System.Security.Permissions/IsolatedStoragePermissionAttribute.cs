//
// System.Security.Permissions.IsolatedStoragePermissionAttribute.cs
//
// Author:
//   Dan Lewis (dihlewis@yahoo.co.uk)
//
// (C) 2002
// Copyright (C) 2004-2006 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Runtime.InteropServices;

namespace System.Security.Permissions {

#if NET_2_0
	[ComVisible (true)]
#endif
	[AttributeUsage ( AttributeTargets.Assembly | AttributeTargets.Class |
		AttributeTargets.Struct | AttributeTargets.Constructor |
		AttributeTargets.Method, AllowMultiple=true, Inherited=false)]
	[Serializable]
	public abstract class IsolatedStoragePermissionAttribute : CodeAccessSecurityAttribute {

#if NET_2_0
		protected IsolatedStoragePermissionAttribute (SecurityAction action)
#else
		public IsolatedStoragePermissionAttribute (SecurityAction action)
#endif
			: base (action)
		{
		}

		public IsolatedStorageContainment UsageAllowed {
			get { return usage_allowed; }
			set { usage_allowed = value; }
		}

		public long UserQuota {
			get { return user_quota; }
			set { user_quota = value; }
		}

		// private

		private IsolatedStorageContainment usage_allowed;
		private long user_quota;
	}
}
