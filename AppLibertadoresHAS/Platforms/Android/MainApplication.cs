using Android.App;
using Android.Runtime;

namespace AppLibertadoresHAS
{
    [Application(UsesCleartextTraffic=true)]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        #region Métodos
        public async Task RegistrarUsuario()//Método para registrar um usuário
        {
            try
            {

            }
            catch (Exception ex)
            {
        //      await Application.Current.MainPage.DisplayAlert("Informação", ex.Message + "Detalhes: " + ex.InnerException, "Ok");
                
            }
        }
        #endregion
    }
}