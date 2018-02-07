using System;

using UIKit;
using Autofac;

using TimeKeeper.DateWriting;
using TimeKeeper.Services;

namespace TimeKeeper
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

            TimeLabel.Text = DateTimeService.GetCurrentTime().ToShortTimeString();

            using (ILifetimeScope scope = Application.Container.BeginLifetimeScope())
            {
                IDateWriter writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
