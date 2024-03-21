﻿// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Columns.ViewsColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ModuleManagement.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.ModuleManagement.Columns
{
  [ColumnsScript("ModuleManagement.Views")]
  [BasedOnRow(typeof (ViewsRow))]
  public class ViewsColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int ViewsId { get; set; }

    public string ModuleModuleName { get; set; }

    [EditLink]
    public string ViewName { get; set; }

    //public short IsAccessFieldWise { get; set; }

    public string StatusStatusName { get; set; }

    //public string CreatedByEmployeeId { get; set; }

    //public DateTime CreatedDate { get; set; }

    //public string UpdatedByEmployeeId { get; set; }

    //public DateTime UpdatedDate { get; set; }
  }
}
