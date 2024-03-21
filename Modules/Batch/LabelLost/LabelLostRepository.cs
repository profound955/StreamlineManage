﻿// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Repositories.LabelLostRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Batch.Repositories
{
  public class LabelLostRepository
  {
    private static LabelLostRow.RowFields fld
    {
      get
      {
        return LabelLostRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<LabelLostRow> request)
    {
      return new LabelLostRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<LabelLostRow> request)
    {
      return new LabelLostRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new LabelLostRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<LabelLostRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new LabelLostRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<LabelLostRow> List(IDbConnection connection, ListRequest request)
    {
      return new LabelLostRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<LabelLostRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<LabelLostRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<LabelLostRow>
    {
    }

    private class MyListHandler : ListRequestHandler<LabelLostRow>
    {
    }
  }
}
