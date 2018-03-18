using System;

namespace DataTableMakeSample
{
  enum PersonTable
  {
    Id,
    Name,
    Age
  }

  static class PersonTableSetting
  {
    public const String Id = "Id";
    public const String Name = "Name";
    public const String Age = "Age";

    private static Type Id_Type = typeof(Int32);
    private static Type Name_Type = typeof(String);
    private static Type Age_Type = typeof(Int32);

    public static string GetProperty(this Enum type)
    {
      switch (type)
      {
        case PersonTable.Id:
          return Id;
        case PersonTable.Name:
          return Name;
        case PersonTable.Age:
          return Age;
      }

      return String.Empty;
    }

    public static Type GetPropertyType(this Enum type)
    {
      switch (type)
      {
        case PersonTable.Id:
          return Id_Type;
        case PersonTable.Name:
          return Name_Type;
        case PersonTable.Age:
          return Age_Type;
      }

      return typeof(Object);
    }

  }

}