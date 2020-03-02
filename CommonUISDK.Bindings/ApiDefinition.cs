using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace CommonUISDK.Bindings
{
    [Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double CommonUISDKVersionNumber;
		[Field("CommonUISDKVersionNumber", "__Internal")]
		double CommonUISDKVersionNumber { get; }

		// extern const unsigned char [] CommonUISDKVersionString;
		//[Field("CommonUISDKVersionString", "__Internal")]
		//byte[] CommonUISDKVersionString { get; }
	}

	// @interface ActionOptionView : UIView
	[BaseType(typeof(UIView), Name = "_TtC11CommonUISDK16ActionOptionView")]
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
		void AwakeFromNib();

		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse();

		// -(BOOL)canPerformAction:(SEL _Nonnull)action withSender:(id _Nullable)sender __attribute__((warn_unused_result));
		[Export("canPerformAction:withSender:")]
		bool CanPerformAction(Selector action, [NullAllowed] NSObject sender);

		// @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
		[Export("canBecomeFirstResponder")]
		bool CanBecomeFirstResponder { get; }
	}

	// @interface ArticlesTableViewCell : UITableViewCell
	[BaseType(typeof(UITableViewCell), Name = "_TtC11CommonUISDK21ArticlesTableViewCell")]
	interface ArticlesTableViewCell
	{
		// -(void)awakeFromNib __attribute__((objc_requires_super));
		[Export("awakeFromNib")]
		[RequiresSuper]
		void AwakeFromNib();

		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse();

		// -(BOOL)canPerformAction:(SEL _Nonnull)action withSender:(id _Nullable)sender __attribute__((warn_unused_result));
		[Export("canPerformAction:withSender:")]
		bool CanPerformAction(Selector action, [NullAllowed] NSObject sender);

		// @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
		[Export("canBecomeFirstResponder")]
		bool CanBecomeFirstResponder { get; }
	}

	// @interface ZDKCommonTheme : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKCommonTheme
	{
		// @property (readonly, nonatomic, strong, class) ZDKCommonTheme * _Nonnull currentTheme;
		[Static]
		[Export("currentTheme", ArgumentSemantic.Strong)]
		ZDKCommonTheme CurrentTheme { get; }

		// @property (nonatomic, strong) UIColor * _Nonnull primaryColor;
		[Export("primaryColor", ArgumentSemantic.Strong)]
		UIColor PrimaryColor { get; set; }
	}

	// @interface InputField : UIView
	[BaseType(typeof(UIView), Name = "_TtC11CommonUISDK10InputField")]
	interface InputField
	{
		//// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor(NSCoder aDecoder);

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export("traitCollectionDidChange:")]
		void TraitCollectionDidChange([NullAllowed] UITraitCollection previousTraitCollection);
	}

	//// @interface CommonUISDK_Swift_991 (InputField) <UITextViewDelegate>
	//[Category]
	//[BaseType(typeof(InputField))]
	//interface InputField_CommonUISDK_Swift_991 : IUITextViewDelegate
	//{
	//	// -(void)textViewDidChange:(UITextView * _Nonnull)textView;
	//	[Export("textViewDidChange:")]
	//	void TextViewDidChange(UITextView textView);

	//	// -(void)textViewDidBeginEditing:(UITextView * _Nonnull)textView;
	//	[Export("textViewDidBeginEditing:")]
	//	void TextViewDidBeginEditing(UITextView textView);
	//}

	// @interface ResponseOptionsTableViewCell : UITableViewCell
	[BaseType(typeof(UITableViewCell), Name = "_TtC11CommonUISDK28ResponseOptionsTableViewCell")]
	interface ResponseOptionsTableViewCell
	{
	}

	// @interface ResponseOptionsView : UIView
	[BaseType(typeof(UIView), Name = "_TtC11CommonUISDK19ResponseOptionsView")]
	interface ResponseOptionsView
	{
	}

	//// @interface CommonUISDK_Swift_1021 (ResponseOptionsView) <UICollectionViewDataSource, UICollectionViewDelegate>
	//[Category]
	//[BaseType(typeof(ResponseOptionsView))]
	//interface ResponseOptionsView_CommonUISDK_Swift_1021 : IUICollectionViewDataSource, IUICollectionViewDelegate
	//{
	//	// -(NSInteger)numberOfSectionsInCollectionView:(UICollectionView * _Nonnull)collectionView __attribute__((warn_unused_result));
	//	[Export("numberOfSectionsInCollectionView:")]
	//	nint NumberOfSectionsInCollectionView(UICollectionView collectionView);

	//	// -(NSInteger)collectionView:(UICollectionView * _Nonnull)collectionView numberOfItemsInSection:(NSInteger)section __attribute__((warn_unused_result));
	//	[Export("collectionView:numberOfItemsInSection:")]
	//	nint CollectionView(UICollectionView collectionView, nint section);

	//	// -(UICollectionViewCell * _Nonnull)collectionView:(UICollectionView * _Nonnull)collectionView cellForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
	//	[Export("collectionView:cellForItemAtIndexPath:")]
	//	UICollectionViewCell CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

	//	// -(void)collectionView:(UICollectionView * _Nonnull)collectionView didSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
	//	[Export("collectionView:didSelectItemAtIndexPath:")]
	//	void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);
	//}

	// @interface TypingIndicatorTableViewCell : UITableViewCell
	[BaseType(typeof(UITableViewCell), Name = "_TtC11CommonUISDK28TypingIndicatorTableViewCell")]
	interface TypingIndicatorTableViewCell
	{
		// -(void)awakeFromNib __attribute__((objc_requires_super));
		[Export("awakeFromNib")]
		[RequiresSuper]
		void AwakeFromNib();
	}
}

