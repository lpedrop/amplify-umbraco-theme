//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.6
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Footer</summary>
	[PublishedModel("footer")]
	public partial class Footer : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "footer";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Footer, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Footer(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Footer Blocks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("footerBlocks")]
		public Umbraco.Core.Models.Blocks.BlockListModel FooterBlocks => this.Value<Umbraco.Core.Models.Blocks.BlockListModel>("footerBlocks");

		///<summary>
		/// Footer Background Color: Pick a background color for the navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("footerColor")]
		public Amplify.Web.Custom.Models.AmplifyColor FooterColor => this.Value<Amplify.Web.Custom.Models.AmplifyColor>("footerColor");

		///<summary>
		/// Footer Gradient: Optional footer gradient.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("footerGradient")]
		public Amplify.Web.Custom.Models.AmplifyGradient FooterGradient => this.Value<Amplify.Web.Custom.Models.AmplifyGradient>("footerGradient");

		///<summary>
		/// Footer Links Color: Set the footer link colors.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("footerLinksColor")]
		public Amplify.Web.Custom.Models.AmplifyColor FooterLinksColor => this.Value<Amplify.Web.Custom.Models.AmplifyColor>("footerLinksColor");

		///<summary>
		/// Footer Text Color: Pick a text color for the navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("footerTextColor")]
		public Amplify.Web.Custom.Models.AmplifyColor FooterTextColor => this.Value<Amplify.Web.Custom.Models.AmplifyColor>("footerTextColor");
	}
}