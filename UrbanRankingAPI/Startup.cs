using UrbanRankingAPI.Services;
using UrbanRankingAPI.AddLogic;
using UrbanRankingAPI.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2;
using Amazon;
using Amazon.Runtime;


namespace UrbanRankingAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //registering requests to a public api's via httpclient (teleport + geodb)
            services.AddHttpClient<ITeleportApiService, TeleportApiService>(c =>
            {
                c.BaseAddress = new Uri("https://api.teleport.org/api/");
                c.DefaultRequestHeaders.Add("Accept", "application/.json");
            });

            services.AddHttpClient<ICityDBApiService, CityDBApiService>(c =>
            {
                c.BaseAddress = new Uri("https://wft-geo-db.p.rapidapi.com/v1/");
                c.DefaultRequestHeaders.Add("Accept", "application/.json");
                c.DefaultRequestHeaders.Add("x-rapidapi-key", Constants.GeoDbApiKey);
                c.DefaultRequestHeaders.Add("x-rapidapi-host", Constants.GeoDbAdress);
            });

            services.AddControllers();
          
            //registering AddLogic class
            services.AddSingleton<AddLogicMethods>();

            //registering amazon dynamodb
            var credentials = new BasicAWSCredentials(Constants.AmazonDynamoDbAccessKey, Constants.AmazonDynamoDbSecretValue);
            var config = new AmazonDynamoDBConfig()
            {
                RegionEndpoint = RegionEndpoint.EUNorth1
            };
            var client = new AmazonDynamoDBClient(credentials, config);
            services.AddSingleton<IAmazonDynamoDB>(client); 
            services.AddSingleton<IDynamoDBContext, DynamoDBContext>();
            services.AddScoped<ICityRepository, CityRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
          
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
