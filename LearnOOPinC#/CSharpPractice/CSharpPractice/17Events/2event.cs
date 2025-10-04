using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice._17Events
{
    public class DeviceCollection()
    {
        public event EventHandler IsDeviceFound;

        public void FindDevice()
        {
            for(int WAlert = 1; WAlert <= 10; WAlert++)
            {
                Thread.Sleep(500);
                if (WAlert == 10)
                {
                    AlertDeviceChanges();
                    WAlert = 1;
                }
            }
        }
        protected virtual void AlertDeviceChanges()
        {
            IsDeviceFound?.Invoke(this, EventArgs.Empty);
        }

        public int DeviceDetection(int i)
        {
            return i + 1;
        }
    }


    public class UIClass
    {
        readonly DeviceCollection _dCollection;
        public UIClass(DeviceCollection dc)
        {
            _dCollection = dc;
        }
        public void UpdateDeviceList(object send, EventArgs ev)
        {
            int newDevice = _dCollection.DeviceDetection(20);
            Console.WriteLine($"New Device Count : {newDevice}\n\n");
        }
    }
    public class eventPracticeTwo
    {
        public static async Task MainEv2()
        {
            DeviceCollection dcObj = new DeviceCollection();
            UIClass ui = new UIClass(dcObj);
            dcObj.IsDeviceFound += ui.UpdateDeviceList;
            Task t = Task.Run(dcObj.FindDevice);     // Start a thread an FindDevice Method will called.
            Console.WriteLine("Test Started, Wait for the Device Changes...");

            await t;  // Await to complete the Task but the FindDevice is looping indefinitely so never break;

        }
    }
}
