using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOIService
{
    public class WebModule : Module
    {
        /*private readonly string _connectionString;
    	private readonly string _migrationAssemblyName;
   ;

    	public WebModule(string connectionStringName, string migrationAssemblyName)
    	{
        	_connectionString = connectionStringName;
        	_migrationAssemblyName = migrationAssemblyName;
        	
    	}*/

        protected override void Load(ContainerBuilder builder)
        {

            //builder.RegisterType<TracksModel>().AsSelf();

            //builder.RegisterType<CourseBatchModel>().AsSelf();

            //builder.RegisterType<ReferralModel>().AsSelf();

            //builder.RegisterType<CourseModel>().AsSelf();

            //builder.RegisterType<DataTablesAjaxRequestModel>().As<IDataTablesAjaxRequestModel>()
            //    .InstancePerLifetimeScope();

            base.Load(builder);

        }
    }
}
