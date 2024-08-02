using AntDesign;
using Space.ServiceConsumer;

namespace Space.Web.Pages.Entidad.PersonaNatural.Main
{
    public partial class PersonaNaturalMain
    {
        List<PersonaNaturalMainModel> Persona_Lista = new List<PersonaNaturalMainModel>();
        string _size = AntSizeLDSType.Large;
        Boolean _loading = true;
        protected override async Task OnInitializedAsync()
        {
            try
            {
                _loading = true;


                await EventMethod_LoadData();

                _loading = false;
            }
            catch (Exception ex)
            {
            }
        }
        private async Task EventMethod_LoadData()
        {
            try
            {

                Persona_Lista = await ServiceConsumer.Service.PersonaNaturalService.GetPersonaNaturalMain();

                Int32 OrderNumber = 1;
                foreach (var i in Persona_Lista) i.Item = (OrderNumber++);

            }
            catch (Exception ex)
            {
                //_loading = false;
                //_snackBar.Add("Hubo un error en el sistema", Severity.Error, a => a.VisibleStateDuration = 1000);

            }
        }


        private async Task IrAlSave()
        {
            try
            {
                NavigationManager.NavigateTo($"/EmpresaSave/0", false);
            }
            catch (Exception ex)
            { }

        }

        private async Task Method_Editar(Int32 RowItem)
        {
            try
            {

                NavigationManager.NavigateTo($"/EmpresaSave/{RowItem.ToString()}", false);

            }
            catch (Exception ex)
            {

            }
        }
    }
}