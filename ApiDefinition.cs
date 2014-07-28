using System.Drawing;
using System;

using MonoTouch.Foundation;

namespace NV {

	public enum NVUIGradientButtonStyle : [unmapped: unexposed: Elaborated] {
		Default = 1,
		BlackOpaque,
		BlackTranslucent
	}

	public enum NVUIGradientButtonStyle : uint {
		Default = 1,
		BlackOpaque,
		BlackTranslucent
	}

	[BaseType (typeof (UIControl))]
	[Register("NVUIGradientButton")]
	public partial interface NVUIGradientButton {

		[Export ("style")]
		NVUIGradientButtonStyle Style { get; set; }

		[Export ("cornerRadius")]
		float CornerRadius { get; set; }

		[Export ("borderWidth")]
		float BorderWidth { get; set; }

		[Export ("tintColor", ArgumentSemantic.Retain)]
		UIColor TintColor { get; set; }

		[Export ("highlightedTintColor", ArgumentSemantic.Retain)]
		UIColor HighlightedTintColor { get; set; }

		[Export ("borderColor", ArgumentSemantic.Retain)]
		UIColor BorderColor { get; set; }

		[Export ("highlightedBorderColor", ArgumentSemantic.Retain)]
		UIColor HighlightedBorderColor { get; set; }

		[Export ("textColor", ArgumentSemantic.Retain)]
		UIColor TextColor { get; set; }

		[Export ("highlightedTextColor", ArgumentSemantic.Retain)]
		UIColor HighlightedTextColor { get; set; }

		[Export ("textShadowColor", ArgumentSemantic.Retain)]
		UIColor TextShadowColor { get; set; }

		[Export ("highlightedTextShadowColor", ArgumentSemantic.Retain)]
		UIColor HighlightedTextShadowColor { get; set; }

		[Export ("text", ArgumentSemantic.Copy)]
		string Text { get; set; }

		[Export ("highlightedText", ArgumentSemantic.Copy)]
		string HighlightedText { get; set; }

		[Export ("disabledText", ArgumentSemantic.Copy)]
		string DisabledText { get; set; }

		[Export ("attributedText", ArgumentSemantic.Copy)]
		NSAttributedString AttributedText { get; set; }

		[Export ("highlightedAttributedText", ArgumentSemantic.Copy)]
		NSAttributedString HighlightedAttributedText { get; set; }

		[Export ("disabledAttributedText", ArgumentSemantic.Copy)]
		NSAttributedString DisabledAttributedText { get; set; }

		[Export ("titleLabel", ArgumentSemantic.Retain)]
		UILabel TitleLabel { get; }

		[Export ("gradientEnabled")]
		int GradientEnabled { [Bind ("isGradientEnabled")] get; set; }

		[Export ("glossy")]
		int Glossy { [Bind ("isGlossy")] get; set; }

		[Export ("rightAccessoryImage", ArgumentSemantic.Retain)]
		UIImage RightAccessoryImage { get; set; }

		[Export ("rightHighlightedAccessoryImage", ArgumentSemantic.Retain)]
		UIImage RightHighlightedAccessoryImage { get; set; }

		[Export ("leftAccessoryImage", ArgumentSemantic.Retain)]
		UIImage LeftAccessoryImage { get; set; }

		[Export ("leftHighlightedAccessoryImage", ArgumentSemantic.Retain)]
		UIImage LeftHighlightedAccessoryImage { get; set; }

		[Export ("initWithFrame:style:cornerRadius:borderWidth:andText:")]
		IntPtr Constructor (RectangleF frame, NVUIGradientButtonStyle style, float cornerRadius, float borderWidth, string text);

		[Export ("initWithFrame:cornerRadius:borderWidth:andText:")]
		IntPtr Constructor (RectangleF frame, float cornerRadius, float borderWidth, string text);

		[Export ("initWithFrame:style:")]
		IntPtr Constructor (RectangleF frame, NVUIGradientButtonStyle style);

		[Export ("setTintColor:forState:")]
		void SetTintColor (UIColor tintColor, UIControlState state);

		[Export ("setBorderColor:forState:")]
		void SetBorderColor (UIColor borderColor, UIControlState state);

		[Export ("setTextColor:forState:")]
		void SetTextColor (UIColor textColor, UIControlState state);

		[Export ("setTextShadowColor:forState:")]
		void SetTextShadowColor (UIColor textShadowColor, UIControlState state);

		[Export ("setText:forState:")]
		void SetText (string text, UIControlState state);

		[Export ("setAttributedText:forState:")]
		void SetAttributedText (NSAttributedString attributedText, UIControlState state);

		[Export ("setRightAccessoryImage:forState:")]
		void SetRightAccessoryImage (UIImage rightAccessoryImage, UIControlState state);

		[Export ("setLeftAccessoryImage:forState:")]
		void SetLeftAccessoryImage (UIImage leftAccessoryImage, UIControlState state);
	}
}
