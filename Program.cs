using System;
using System.Diagnostics;
using System.Data;

namespace DataTableMakeSample
{
  class Program
  {
    static void Main(string[] args)
    {
      DataTable table = DataTableUtils.GetDataTable(typeof(PersonTable));

      for (int i = 0; i <= 10; i++)
      {
        DataRow row = table.NewRow();
        row[PersonTableSetting.Name] = "Name " + i;
        row[PersonTableSetting.Age] = 20 + i;
        table.Rows.Add(row);
      }

      foreach (DataRow row in table.Rows)
      {
        Debug.WriteLine("{0}: {1}", PersonTableSetting.Id,
                                    row[PersonTableSetting.Id]);
        Debug.WriteLine("{0}: {1}", PersonTableSetting.Name,
                                    row[PersonTableSetting.Name]);
        Debug.WriteLine("{0}: {1}", PersonTableSetting.Age,
                                    row[PersonTableSetting.Age]);
      }
    }
  }
}
