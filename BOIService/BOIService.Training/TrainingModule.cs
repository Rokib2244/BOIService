using Autofac;
using BOIService.Training.Repositories;
using BOIService.Training.UnitOfWorks;
using BOIService.Training.Contexts;
using BOIService.Training.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOIService.Training
{
    public class TrainingModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;


        public TrainingModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;

        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TrainingContext>().AsSelf()
                            .WithParameter("connectionString", _connectionString)
                            .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                            .InstancePerLifetimeScope();
            builder.RegisterType<TrainingContext>().As<ITrainingContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            //builder.RegisterType<CourseModel>().AsSelf();
            builder.RegisterType<CustomerService>().As<ICustomerService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<InvoiceService>().As<IInvoiceService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<InvoiceRepository>().As<IInvoiceRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<TrainingUnitOfWork>().As<ITrainingUnitOfWork>()
                .InstancePerLifetimeScope();

            //builder.RegisterType<DataTablesAjaxRequestModel>().As<IDataTablesAjaxRequestModel>()
            //    .InstancePerLifetimeScope();

            base.Load(builder);

        }
    }
}
