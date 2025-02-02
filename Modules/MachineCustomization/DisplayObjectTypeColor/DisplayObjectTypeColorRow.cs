﻿
namespace CVC.MachineCustomization.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("MachineCustomization"), TableName("[dbo].[DisplayObjectTypeColor]")]
    [DisplayName("Display Object Type Color"), InstanceName("Display Object Type Color")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class DisplayObjectTypeColorRow : Row, IIdRow, INameRow
    {
        [DisplayName("Dot Color Id"), Column("DOTColorId"), Identity]
        public Int32? DotColorId
        {
            get { return Fields.DotColorId[this]; }
            set { Fields.DotColorId[this] = value; }
        }

        [DisplayName("Dot Color"), Column("DOTColor"), Size(50), NotNull, QuickSearch]
        public String DotColor
        {
            get { return Fields.DotColor[this]; }
            set { Fields.DotColor[this] = value; }
        }

        [DisplayName("Min"), NotNull]
        public Double? Min
        {
            get { return Fields.Min[this]; }
            set { Fields.Min[this] = value; }
        }

        [DisplayName("Max"), NotNull]
        public Double? Max
        {
            get { return Fields.Max[this]; }
            set { Fields.Max[this] = value; }
        }

        [DisplayName("Display Object Type Id"), NotNull]
        public Int32? DisplayObjectTypeId
        {
            get { return Fields.DisplayObjectTypeId[this]; }
            set { Fields.DisplayObjectTypeId[this] = value; }
        }

        [DisplayName("Sub Type Id"), NotNull]
        public Int32? SubTypeId
        {
            get { return Fields.SubTypeId[this]; }
            set { Fields.SubTypeId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.DotColorId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.DotColor; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DisplayObjectTypeColorRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DotColorId;
            public StringField DotColor;
            public DoubleField Min;
            public DoubleField Max;
            public Int32Field DisplayObjectTypeId;
            public Int32Field SubTypeId;
        }
    }
}
