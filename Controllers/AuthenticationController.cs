
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using WorkshopWebApi.Models;

namespace WorkshopWebApi.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class AuthenticationController : ControllerBase
  {
    private IConfiguration _config;

    public AuthenticationController(IConfiguration config)
    {
      _config = config;
    }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult Login([FromBody] AuthenticationData userInfo)
    {
      IActionResult response = Unauthorized();
      if (string.IsNullOrEmpty(userInfo.Username) || string.IsNullOrEmpty(userInfo.Password))
        return response;

      var tokenString = GenerateJSONWebToken(userInfo);
      response = Ok(new { token = tokenString });

      return response;
    }

    private string GenerateJSONWebToken(AuthenticationData userInfo)
    {
      var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
      var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

      var token = new JwtSecurityToken(_config["Jwt:Issuer"],
        _config["Jwt:Issuer"],
        null,
        expires: DateTime.Now.AddMinutes(120),
        signingCredentials: credentials);

      return new JwtSecurityTokenHandler().WriteToken(token);
    }
  }
}