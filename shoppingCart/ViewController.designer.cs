// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace shoppingCart
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnCheckOut { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnJacket { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPants { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnShirt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSkirt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnViewCart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgJacket { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgPants { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgShirt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSkirt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblJacketPrice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPantsPrice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblResult { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblShirtPrice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSkirtPrice { get; set; }

        [Action ("BtnCheckOut_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnCheckOut_Activated (UIKit.UIBarButtonItem sender);

        [Action ("BtnJacket_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnJacket_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnPants_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnPants_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnShirt_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnShirt_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnSkirt_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnSkirt_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnViewCart_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnViewCart_Activated (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCheckOut != null) {
                btnCheckOut.Dispose ();
                btnCheckOut = null;
            }

            if (btnJacket != null) {
                btnJacket.Dispose ();
                btnJacket = null;
            }

            if (btnPants != null) {
                btnPants.Dispose ();
                btnPants = null;
            }

            if (btnShirt != null) {
                btnShirt.Dispose ();
                btnShirt = null;
            }

            if (btnSkirt != null) {
                btnSkirt.Dispose ();
                btnSkirt = null;
            }

            if (btnViewCart != null) {
                btnViewCart.Dispose ();
                btnViewCart = null;
            }

            if (imgJacket != null) {
                imgJacket.Dispose ();
                imgJacket = null;
            }

            if (imgPants != null) {
                imgPants.Dispose ();
                imgPants = null;
            }

            if (imgShirt != null) {
                imgShirt.Dispose ();
                imgShirt = null;
            }

            if (imgSkirt != null) {
                imgSkirt.Dispose ();
                imgSkirt = null;
            }

            if (lblJacketPrice != null) {
                lblJacketPrice.Dispose ();
                lblJacketPrice = null;
            }

            if (lblPantsPrice != null) {
                lblPantsPrice.Dispose ();
                lblPantsPrice = null;
            }

            if (lblResult != null) {
                lblResult.Dispose ();
                lblResult = null;
            }

            if (lblShirtPrice != null) {
                lblShirtPrice.Dispose ();
                lblShirtPrice = null;
            }

            if (lblSkirtPrice != null) {
                lblSkirtPrice.Dispose ();
                lblSkirtPrice = null;
            }
        }
    }
}