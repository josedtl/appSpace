using AntDesign;
using Microsoft.AspNetCore.Components;

using Space.ServiceConsumer;


namespace Space.Web.Pages.Infraestructura.Save
{
    public partial class InfraestructuraSave : ComponentBase
    {

        private String txtValue = String.Empty;
        string _selectedValue4 = "lucy";
        Boolean EsAdd = true;
        private InfraestructuraSaveModel Infraestructura = new InfraestructuraSaveModel();
        private List<InfraListaModel> lst_Sucursal = new List<InfraListaModel>();
        private List<InfraListaModel> lst_Tipo = new List<InfraListaModel>();
        private List<InfraListaModel> lst_Clasificacion = new List<InfraListaModel>();
        private List<InfraListaModel> lst_Dimension = new List<InfraListaModel>();
        private List<InfraListaModel> lst_Piso = new List<InfraListaModel>();

        private InfraListaModel select_Sucursal = new InfraListaModel();
        private InfraListaModel select_Tipo = new InfraListaModel();
        private InfraListaModel select_Clasificacion = new InfraListaModel();
        private InfraListaModel select_Dimension = new InfraListaModel();
        private InfraListaModel select_Piso = new InfraListaModel();
        [Parameter]
        public String MiVariable { get; set; }
        Boolean _loading = true;
        protected override async Task OnInitializedAsync()
        {
            try
            {
                _loading = true;


                lst_Sucursal = await ServiceConsumer.Service.GeneralService.GetInFraLista_Codigo("0001");
                lst_Tipo = await ServiceConsumer.Service.GeneralService.GetInFraLista_Codigo("0006");
                lst_Clasificacion = await ServiceConsumer.Service.GeneralService.GetInFraLista_Codigo("0013");
                lst_Dimension = await ServiceConsumer.Service.GeneralService.GetInFraLista_Codigo("0007");
                lst_Piso = await ServiceConsumer.Service.GeneralService.GetInFraLista_Codigo("0009");

                Int32 OrdenPedidoId = Convert.ToInt32(MiVariable);



                if (OrdenPedidoId > 0)
                {


                    EsAdd = false;
                    var Items = await ServiceConsumer.Service.InfraestructuraService.GetInfraestructuraItem(OrdenPedidoId);



                    if (Items != null && Items.Count > 0)
                    {
                        var Item_Select = Items[0];


                        Infraestructura = Item_Select;




                        Int32 Index_Sucursal = lst_Sucursal.FindIndex(S => S.ListaId == Infraestructura.SucursalId);
                        select_Sucursal = Index_Sucursal >= 0 ? lst_Sucursal[Index_Sucursal] : new InfraListaModel();

                        Int32 Index_Tipo = lst_Tipo.FindIndex(S => S.ListaId == Infraestructura.TipoInfraestructuraId);
                        select_Tipo = Index_Tipo >= 0 ? lst_Tipo[Index_Tipo] : new InfraListaModel();

                        Int32 Index_Clasificacion = lst_Clasificacion.FindIndex(S => S.ListaId == Infraestructura.ClasificacionId);
                        select_Clasificacion = Index_Clasificacion >= 0 ? lst_Clasificacion[Index_Clasificacion] : new InfraListaModel();

                        Int32 Index_Dimension = lst_Dimension.FindIndex(S => S.ListaId == Infraestructura.InfraestructuraDimensionId);
                        select_Dimension = Index_Dimension >= 0 ? lst_Dimension[Index_Dimension] : new InfraListaModel();

                        Int32 Index_Piso = lst_Piso.FindIndex(S => S.ListaId == Infraestructura.PisoId);
                        select_Piso = Index_Piso >= 0 ? lst_Piso[Index_Piso] : new InfraListaModel();

                    }

                }
                _loading = false;
            }
            catch (Exception ex)
            {

            }
        }

        private async Task Method_Guardar()
        {
            try
            {
                Infraestructura.SucursalId = select_Sucursal.ListaId;
                Infraestructura.TipoInfraestructuraId = select_Tipo.ListaId;
                Infraestructura.ClasificacionId = select_Clasificacion.ListaId;
                Infraestructura.InfraestructuraDimensionId = select_Dimension.ListaId;
                Infraestructura.PisoId = select_Piso.ListaId;
                Infraestructura.FechaRegistro = DateTime.Now;
                Infraestructura.CodUsuario = "adm";
                Infraestructura.EstadoRegistro = true;
                Infraestructura.Estado = 0;
                var item = Infraestructura;



                if (Infraestructura.InfraestructuraId == 0)
                {
                    var dato = await ServiceConsumer.Service.InfraestructuraService.Save(Infraestructura);
                    await _message.Success("Se guardo correctamente");
                }
                else
                {
                    var dato = await ServiceConsumer.Service.InfraestructuraService.Update(Infraestructura);
                    await _message.Success("Se actualizo correctamente");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

    }
}
