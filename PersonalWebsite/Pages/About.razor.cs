using MatBlazor;
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
        MatTheme DefaultTheme = new MatTheme()
        {
            Primary = "#1565c0",
            Secondary = "#0d47a1"
        };
        private List<WorkExperience> experiences;
        private List<WorkExperienceHead> head;

        protected override async Task OnInitializedAsync()
        {
            experiences = await _data.LoadData<WorkExperience, dynamic>("SELECT * FROM WorkExperience", new { }, _config.GetConnectionString("DefaultConnection"));
            head = await _data.LoadData<WorkExperienceHead, dynamic>("SELECT * FROM WorkExperienceHead", new { }, _config.GetConnectionString("DefaultConnection"));
        }
    }
}
