using GomoiuWeb.Shared.Data.DB;
using Microsoft.OData.Edm;
using OdataToEntity;
using OdataToEntity.EfCore;
using OdataToEntity.Query;
using OdataToEntity.Query.Builder;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ODat
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Create adapter data access, where OrderContext your DbContext
            var dataAdapter = new OeEfCoreDataAdapter<AppDBContext>();
            IEdmModel edmModel = dataAdapter.BuildEdmModelFromEfCoreModel();
            var modelBoundBuilder = new OeModelBoundFluentBuilder(edmModel);
            modelBoundBuilder.EntitySet<ClientAppointments>("ClientAppointments").EntityType.Select(SelectExpandType.Disabled, "Id", "DoctorId");
            //Create query parser
            var parser = new OeParser(new Uri("http://dummy"), edmModel, modelBoundBuilder.BuildProvider());
            //Query
            var uri = new Uri("http://dummy/Doctors?$expand=ClientAppointments&$select=Name,ClientAppointments");
            //The result of the query
            var response = new MemoryStream();
            //Execute query
            await parser.ExecuteGetAsync(uri, OeRequestHeaders.JsonDefault, response, CancellationToken.None);
            var s = Encoding.ASCII.GetString(response.ToArray());
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
