using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using PersonalWebsite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PersonalWebsite.Pages
{
    public partial class About
    {
        List<WorkExperience> experiences { get; set; }

        protected override async Task OnInitializedAsync()
        {
            string query = "SELECT * FROM WorkExperience";
            experiences = await _data.LoadData<WorkExperience, dynamic>(query, new { }, _config.GetConnectionString("DefaultConnection"));
        }

    }
}
