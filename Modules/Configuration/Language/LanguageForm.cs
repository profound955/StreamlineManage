﻿// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Forms.LanguageForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;

namespace CVC.Configuration.Forms
{
  [FormScript("Configuration.Language")]
  [BasedOnRow(typeof (LanguageRow))]
  public class LanguageForm
  {
    public string LanguageId { get; set; }

    public string LanguageName { get; set; }
  }
}
