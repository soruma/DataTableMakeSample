using System;
using System.Data;
using System.Reflection;
using System.Linq;
using System.Diagnostics;

namespace DataTableMakeSample
{
  class DataTableUtils
  {
    public static DataTable GetDataTable(Type type)
    {
      DataTable table = new DataTable(type.Name);

      foreach (Enum e in Enum.GetValues(type))
      {
        DataColumn column;
        column = new DataColumn();
        column.DataType = e.GetPropertyType();
        column.ColumnName = e.GetProperty();
        column.Caption = e.GetProperty();

        Boolean isIdentification = (e.GetProperty() == "Id" ? true : false);
        column.AutoIncrement = isIdentification;
        column.ReadOnly = isIdentification;
        column.Unique = isIdentification;

        table.Columns.Add(column);
      }

      return table;
    }

    public static String GetName(Type type, Enum name)
    {
      return Enum.GetName(type, name);
    }
  }
}