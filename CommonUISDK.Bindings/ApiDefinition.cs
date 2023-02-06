using System;
using CommonUISDK;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CommonUISDK.Bindings
{
    // @interface ActionOptionView : UIButton
    [BaseType(typeof(UIButton), Name = "_TtC11CommonUISDK16ActionOptionView")]
    interface ActionOptionView
    {
    }

    // @interface ActionOptionsTableViewCell : UITableViewCell
    [BaseType(typeof(UITableViewCell), Name = "_TtC11CommonUISDK26ActionOptionsTableViewCell")]
    interface ActionOptionsTableViewCell
    {
        // -(void)awakeFromNib __attribute__((objc_requires_super));
        [Export("awakeFromNib")]
        [RequiresSuper]
        [Override]
        void AwakeFromNib();

        // -(BOOL)canPerformAction:(SEL _Nonnull)action withSender:(id _Nullable)sender __attribute__((warn_unused_result("")));
        [Export("canPerformAction:withSender:")]
        bool CanPerformAction(Selector action, [NullAllowed] NSObject sender);

        // @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
        [Export("canBecomeFirstResponder")]
        [Override]
        bool CanBecomeFirstResponder { get; }

        // -(void)prepareForReuse __attribute__((objc_requires_super));
        [Export("prepareForReuse")]
        [RequiresSuper]
        [Override]
        void PrepareForReuse();

        // -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
        [Export("traitCollectionDidChange:")]
        [Override]
        void TraitCollectionDidChange([NullAllowed] UITraitCollection previousTraitCollection);
    }

    // @interface AlignedCollectionViewFlowLayout : UICollectionViewFlowLayout
    [BaseType(typeof(UICollectionViewFlowLayout), Name = "_TtC11CommonUISDK31AlignedCollectionViewFlowLayout")]
    [DisableDefaultCtor]
    interface AlignedCollectionViewFlowLayout
    {
        //		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //		[Export ("initWithCoder:")]
        //		[DesignatedInitializer]
        //		IntPtr Constructor (NSCoder aDecoder);

        // -(BOOL)shouldInvalidateLayoutForBoundsChange:(CGRect)newBounds __attribute__((warn_unused_result("")));
        [Export("shouldInvalidateLayoutForBoundsChange:")]
        [Override]
        bool ShouldInvalidateLayoutForBoundsChange(CGRect newBounds);

        // -(UICollectionViewLayoutAttributes * _Nullable)layoutAttributesForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
        [Export("layoutAttributesForItemAtIndexPath:")]
        [return: NullAllowed]
        UICollectionViewLayoutAttributes LayoutAttributesForItemAtIndexPath(NSIndexPath indexPath);

        // -(NSArray<UICollectionViewLayoutAttributes *> * _Nullable)layoutAttributesForElementsInRect:(CGRect)rect __attribute__((warn_unused_result("")));
        [Export("layoutAttributesForElementsInRect:")]
        [Override]
        UICollectionViewLayoutAttributes[] LayoutAttributesForElementsInRect(CGRect rect);
    }

    // @interface ArticlesTableViewCell : UITableViewCell
    [BaseType(typeof(UITableViewCell), Name = "_TtC11CommonUISDK21ArticlesTableViewCell")]
    interface ArticlesTableViewCell
    {
        // -(void)awakeFromNib __attribute__((objc_requires_super));
        [Export("awakeFromNib")]
        [RequiresSuper]
        [Override]
        void AwakeFromNib();

        // -(void)prepareForReuse __attribute__((objc_requires_super));
        [Export("prepareForReuse")]
        [RequiresSuper]
        [Override]
        void PrepareForReuse();

        // -(BOOL)canPerformAction:(SEL _Nonnull)action withSender:(id _Nullable)sender __attribute__((warn_unused_result("")));
        [Export("canPerformAction:withSender:")]
        bool CanPerformAction(Selector action, [NullAllowed] NSObject sender);

        // @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
        [Export("canBecomeFirstResponder")]
        [Override]
        bool CanBecomeFirstResponder { get; }

        // -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
        [Export("traitCollectionDidChange:")]
        [Override]
        void TraitCollectionDidChange([NullAllowed] UITraitCollection previousTraitCollection);
    }

    // @interface ZDKCommonTheme : NSObject
    [BaseType(typeof(NSObject))]
    interface ZDKCommonTheme
    {
        // @property (nonatomic, strong, class) ZDKCommonTheme * _Nonnull currentTheme;
        [Static]
        [Export("currentTheme", ArgumentSemantic.Strong)]
        ZDKCommonTheme CurrentTheme { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull primaryColor;
        [Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; set; }
    }

    // @interface InputField : UIView
    [BaseType(typeof(UIView), Name = "_TtC11CommonUISDK10InputField")]
    interface InputField
    {
        //		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //		[Export ("initWithCoder:")]
        //		[DesignatedInitializer]
        //		IntPtr Constructor (NSCoder aDecoder);

        // -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
        [Export("traitCollectionDidChange:")]
        [Override]
        void TraitCollectionDidChange([NullAllowed] UITraitCollection previousTraitCollection);

        // -(void)textViewDidChange:(UITextView * _Nonnull)textView;
        [Export("textViewDidChange:")]
        void TextViewDidChange(UITextView textView);

        // -(void)textViewDidBeginEditing:(UITextView * _Nonnull)textView;
        [Export("textViewDidBeginEditing:")]
        void TextViewDidBeginEditing(UITextView textView);
    }

    // @interface TypingIndicatorTableViewCell : UITableViewCell
    [BaseType(typeof(UITableViewCell), Name = "_TtC11CommonUISDK28TypingIndicatorTableViewCell")]
    interface TypingIndicatorTableViewCell
    {
        // -(void)awakeFromNib __attribute__((objc_requires_super));
        [Export("awakeFromNib")]
        [RequiresSuper]
        [Override]
        void AwakeFromNib();
    }

    // @interface CommonUISDK_Swift_334 (UIImageView)
    [BaseType(typeof(UIImageView))]
    interface UIImageViewExtension
    {
        // -(void)nuke_displayWithImage:(UIImage * _Nullable)image;
        [Export("nuke_displayWithImage:")]
        void Nuke_displayWithImage([NullAllowed] UIImage image);
    }
}
