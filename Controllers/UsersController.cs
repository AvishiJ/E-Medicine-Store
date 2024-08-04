using EMedicineBE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace EMedicineBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        

        public UsersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        [Route("registration")]
        public Response register(Users users)  //it is for registering new users
        {
            Response response = new Response();
            DAL dal= new DAL();

            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            response = dal.register(users, connection);
           
            return response;
        }
        [HttpPost]
        [Route("login")]

        public Response login(Users users)  //it is for registering new users
        {
            Response response = new Response();
            DAL dal = new DAL();

            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            response = dal.login(users, connection);

            return response;
        }


        [HttpPost]
        [Route("viewUser")]
        public Response viewUser(Users users)  //it is for registering new users
        {
          
            DAL dal = new DAL();

            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.viewUser(users, connection);

            return response;
        }

        [HttpPost]
        [Route("updateProfile")]
        public Response updateProfile(Users users)  //it is for registering new users
        {
            
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.updateProfile(users, connection);

            return response;
        }




    }
}
