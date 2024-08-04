using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EMedicineBE.Models;
using System.Data.SqlClient;

namespace EMedicineBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public MedicinesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("addToCart")]
        public Response updateProfile(Cart cart)  //it is for registering new users
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.addToCart(cart, connection);

            return response;
        }

        [HttpPost]
        [Route("placeOrder")]
        public Response placeOrder(Users users)  //it is for registering new users
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.placeOrder(users, connection);

            return response;
        }

        [HttpPost]
        [Route("orderList")]
        public Response orderList(Users users)  //it is for registering new users
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            Response response = dal.orderList(users, connection);

            return response;
        }



    }
}
