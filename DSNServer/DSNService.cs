using System.ServiceModel;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using DSNInterfaces;
using System.Threading;
namespace DSNServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    //public class Store
    //{
    //    public BindingList<SpaceCraft> storedData
    //    {
    //        get;
    //        set;
    //    }
    //    public void setValue(BindingList<SpaceCraft> message)
    //    {
    //        this.storedData = message;
    //    }
    //}
    public class DSNService : IDSNService
    {

        //public static Store tempStore { get; set; }
        public void Connect()
        {
            Callback = OperationContext.Current.GetCallbackChannel<ICallbackService>();
            MessageBox.Show("Connect Success ^^");
        }

        public static ICallbackService Callback { get; set; }


        public void SendMessage(BindingList<SpaceCraft> message)
        {
            //MessageBox.Show(message);
            //send SpaceCraft info from space running program to DSN server(implement later)
            Thread t = new Thread(() => DSNServerForm.GetNewData(message));
            t.Start();
            //DSNServerForm.GetNewData(message);
            //tempStore = new Store();
            //tempStore.setValue(message);
        }
    }
}