﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Data
{
    public class WorkExperienceHead
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }

    public class WorkExperience
    {
        public int ID { get; set; }

        public int HeadID { get; set; }

        public string Header { get; set; }

        public string Description { get; set; }
    }
}
