//
//  Author:
//       Nicolas VERINAUD <n.verinaud@gmail.com>
//
//  Copyright (c) 2014 Nicolas Verinaud. All Rights Reserved.
//
using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace NV 
{
	[BaseType (typeof (UIControl))]
	public partial interface NVUIGradientButton {

		[Export ("style")]
		NVUIGradientButtonStyle Style { get; set; }

		[Export ("cornerRadius"), Appearance]
		nfloat CornerRadius { get; set; }

		[Export ("borderWidth"), Appearance]
		nfloat BorderWidth { get; set; }

		[Export ("tintColor", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIColor TintColor { get; set; }

		[Export ("highlightedTintColor", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIColor HighlightedTintColor { get; set; }

		[Export ("borderColor", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIColor BorderColor { get; set; }

		[Export ("highlightedBorderColor", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIColor HighlightedBorderColor { get; set; }

		[Export ("textColor", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIColor TextColor { get; set; }

		[Export ("highlightedTextColor", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIColor HighlightedTextColor { get; set; }

		[Export ("textShadowColor", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIColor TextShadowColor { get; set; }

		[Export ("highlightedTextShadowColor", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIColor HighlightedTextShadowColor { get; set; }

		[Export ("text", ArgumentSemantic.Copy), NullAllowed]
		string Text { get; set; }

		[Export ("highlightedText", ArgumentSemantic.Copy), NullAllowed]
		string HighlightedText { get; set; }

		[Export ("disabledText", ArgumentSemantic.Copy), NullAllowed]
		string DisabledText { get; set; }

		[Export ("attributedText", ArgumentSemantic.Copy), NullAllowed]
		NSAttributedString AttributedText { get; set; }

		[Export ("highlightedAttributedText", ArgumentSemantic.Copy), NullAllowed]
		NSAttributedString HighlightedAttributedText { get; set; }

		[Export ("disabledAttributedText", ArgumentSemantic.Copy), NullAllowed]
		NSAttributedString DisabledAttributedText { get; set; }

		[Export ("titleLabel", ArgumentSemantic.Retain)]
		UILabel TitleLabel { get; }

		[Export ("gradientEnabled"), Appearance]
		nint GradientEnabled { [Bind ("isGradientEnabled")] get; set; }

		[Export ("glossy"), Appearance]
		nint Glossy { [Bind ("isGlossy")] get; set; }

		[Export ("rightAccessoryImage", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIImage RightAccessoryImage { get; set; }

		[Export ("rightHighlightedAccessoryImage", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIImage RightHighlightedAccessoryImage { get; set; }

		[Export ("leftAccessoryImage", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIImage LeftAccessoryImage { get; set; }

		[Export ("leftHighlightedAccessoryImage", ArgumentSemantic.Retain), Appearance, NullAllowed]
		UIImage LeftHighlightedAccessoryImage { get; set; }

		[Export ("initWithFrame:style:cornerRadius:borderWidth:andText:")]
		IntPtr Constructor (CGRect frame, NVUIGradientButtonStyle style, nfloat cornerRadius, nfloat borderWidth, string text);

		[Export ("initWithFrame:cornerRadius:borderWidth:andText:")]
		IntPtr Constructor (CGRect frame, nfloat cornerRadius, nfloat borderWidth, string text);

		[Export ("initWithFrame:style:")]
		IntPtr Constructor (CGRect frame, NVUIGradientButtonStyle style);

		[Export ("setTintColor:forState:")]
		void SetTintColor ([NullAllowed] UIColor tintColor, UIControlState state);

		[Export ("setBorderColor:forState:")]
		void SetBorderColor ([NullAllowed] UIColor borderColor, UIControlState state);

		[Export ("setTextColor:forState:")]
		void SetTextColor ([NullAllowed] UIColor textColor, UIControlState state);

		[Export ("setTextShadowColor:forState:")]
		void SetTextShadowColor ([NullAllowed] UIColor textShadowColor, UIControlState state);

		[Export ("setText:forState:")]
		void SetText ([NullAllowed] string text, UIControlState state);

		[Export ("setAttributedText:forState:")]
		void SetAttributedText ([NullAllowed] NSAttributedString attributedText, UIControlState state);

		[Export ("setRightAccessoryImage:forState:")]
		void SetRightAccessoryImage ([NullAllowed] UIImage rightAccessoryImage, UIControlState state);

		[Export ("setLeftAccessoryImage:forState:")]
		void SetLeftAccessoryImage ([NullAllowed] UIImage leftAccessoryImage, UIControlState state);
	}
}