// jQueryXmlHttpRequest.cs
// Script#/Libraries/jQuery/Core
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;

namespace jQueryApi {

	/// <summary>
	/// Represents an XMLHttpRequest object as a deferred object.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[ScriptName("Object")]
	public sealed class jQueryXmlHttpRequest<T> : IjQueryPromise<T> {

		private jQueryXmlHttpRequest() {
		}

		/// <summary>
		/// The ready state property of the XmlHttpRequest object.
		/// </summary>
		[IntrinsicProperty]
		public ReadyState ReadyState {
			get {
				return default(ReadyState);
			}
		}

		/// <summary>
		/// The XML document for an XML response.
		/// </summary>
		[IntrinsicProperty]
		[ScriptName("responseXML")]
		public XmlDocument ResponseXml {
			get {
				return null;
			}
		}

		/// <summary>
		/// The text of the response.
		/// </summary>
		[IntrinsicProperty]
		public string ResponseText {
			get {
				return null;
			}
		}

		/// <summary>
		/// The status code associated with the response.
		/// </summary>
		[IntrinsicProperty]
		public int Status {
			get {
				return 0;
			}
		}

		/// <summary>
		/// The status text of the response.
		/// </summary>
		[IntrinsicProperty]
		public string StatusText {
			get {
				return null;
			}
		}

		/// <summary>
		/// Aborts the request.
		/// </summary>
		public void Abort() {
		}

		/// <summary>
		/// Gets the response headers associated with the request.
		/// </summary>
		/// <returns>The response headers.</returns>
		public string GetAllResponseHeaders() {
			return null;
		}

		/// <summary>
		/// Gets a specific response header associated with the request.
		/// </summary>
		/// <param name="name">The name of the response header.</param>
		/// <returns>The response header value.</returns>
		public string GetResponseHeader(string name) {
			return null;
		}

		/// <summary>
		/// Sets the mime type on the request.
		/// </summary>
		/// <param name="type">The mime type to use.</param>
		public void OverrideMimeType(string type) {
		}

		/// <summary>
		/// Sets a request header value.
		/// </summary>
		/// <param name="name">The name of the request header.</param>
		/// <param name="value">The value of the request header.</param>
		public void SetRequestHeader(string name, string value) {
		}
	}
}
