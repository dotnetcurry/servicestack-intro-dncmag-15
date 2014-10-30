using Funq;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStack.Razor;
using StudentReports.Models;
using StudentReports.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace StudentReports.Startup
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Student report Service", typeof(StudentService).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            ServiceStack.Text.JsConfig.EmitCamelCaseNames = true;
            Plugins.Add(new RazorFormat());

            var ormLiteConnectionFactory = new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["studentDbConn"].ConnectionString,
                                                                            ServiceStack.OrmLite.SqlServer.SqlServerOrmLiteDialectProvider.Instance);

            
            container.Register<IDbConnectionFactory>(ormLiteConnectionFactory);
            container.Register(c => new StudentDbRepository()).ReusedWithin(ReuseScope.Request);

            container.RegisterAutoWired<StudentDbRepository>();

            DbInitializer.InitializeDb(ormLiteConnectionFactory);
        }
    }
}