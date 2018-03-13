using System;
using Foundation;
using UIKit;

namespace DateAndTime05
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            btnDateTime.TouchUpInside += BtnDateTime_TouchUpInside;
            btnNSDate.TouchUpInside += BtnNSDate_TouchUpInside;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        #region Interactions

        void BtnDateTime_TouchUpInside(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now;
            //lblDate.Text = currentTime.ToLongDateString();
            lblDate.Text = currentTime.ToString("D", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
            lblTime.Text = currentTime.ToLongTimeString();
        }

        void BtnNSDate_TouchUpInside(object sender, EventArgs e)
        {
            
            var currentTime2 = NSDate.Now;
            //lblDate.Text = currentTime2.Description;

            var tiempoFormato = new NSDateFormatter 
            {
                TimeStyle = NSDateFormatterStyle.Medium,
                DateFormat = "HH:mm:ss a"
            };

            var fechaFormato = new NSDateFormatter
            {
                DateStyle = NSDateFormatterStyle.Long,
                DateFormat = "dd 'de' MMMM 'del' yyyy"
            };

            NSLocale f = new NSLocale(identifier: ("es_mx"));
            fechaFormato.Locale = f;
            tiempoFormato.Locale = f;
            lblDate.Text = fechaFormato.ToString(currentTime2);
            lblTime.Text = tiempoFormato.ToString(currentTime2);

            /*
            dateFormatter.locale = Locale(identifier: "en_US");

            NSDateFormatter.locale = NSLocale(NSIdentifier: "en_US");
            */
        }

        #endregion
    }
}
