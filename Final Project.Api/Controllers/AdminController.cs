using FinalProject.Core.Dtos.AdminDto;
using FinalProject.Core.Dtos.EmployeeDots;
using FinalProject.Core.Models;
using FinalProject.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using FinalProject.Core.Dtos.CollegeDots;
using FinalProject.EF.Migrations;
using Microsoft.AspNetCore.Http;

using System.Collections.Generic;
using FinalProject.EF;
using FinalProject.Core;

namespace FinalProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdminController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("/Create_Admin")]
        public async Task<IActionResult> Create(AddAdminDto AdminDto)
        {
            var admin = new Admin()
            {
                Name = AdminDto.Name,
                Email = AdminDto.Email,
                Password = AdminDto.Password,
            };
            var AddAdmin = await _unitOfWork.Admins.AddAsync(admin);
            if (AddAdmin == null) return BadRequest("Admin creation failed");


            await _unitOfWork.CompleteAsync();
            return Ok(admin);
        }

        [HttpGet("/Admin_Login")]
        public async Task<IActionResult> Login(AdminLoginDto adminDto)
        {
            var AdminLogin = await _unitOfWork.Admins.AdminLogin(adminDto.Email, adminDto.Password);
            if (AdminLogin == null) return BadRequest("Admin Login failed");

            return Ok(AdminLogin);
        }

    }
}
