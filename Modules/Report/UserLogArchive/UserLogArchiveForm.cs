﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CVC.Report.Entities;
using Serenity.ComponentModel;

namespace CVC.Report.Forms
{
    [FormScript("Report.UserLogArchive")]
    [BasedOnRow(typeof(UserLogArchiveRow))]
    public class UserLogArchiveForm
    {
        public long UserLogArchiveId { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public Action Action { get; set; }

        public DateTime ChangedOn { get; set; }
    }
}