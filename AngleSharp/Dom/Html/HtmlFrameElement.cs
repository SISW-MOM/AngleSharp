﻿namespace AngleSharp.Dom.Html
{
    using AngleSharp.Extensions;
    using AngleSharp.Html;
    using System;

    /// <summary>
    /// Represents the HTML frame element.
    /// </summary>
    sealed class HtmlFrameElement : HtmlFrameElementBase
    {
        #region ctor

        public HtmlFrameElement(Document owner, String prefix = null)
            : base(owner, Tags.Frame, prefix, NodeFlags.SelfClosing)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets if the frame cannot be resized.
        /// </summary>
        public Boolean NoResize
        {
            get { return this.GetOwnAttribute(AttributeNames.NoResize).ToBoolean(false); }
            set { this.SetOwnAttribute(AttributeNames.NoResize, value.ToString()); }
        }

        #endregion
    }
}
