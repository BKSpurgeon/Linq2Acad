﻿using Autodesk.AutoCAD.DatabaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2Acad
{
  public static class MlineStyleExtensions
  {
    public static MlineStyle GetItem(this IEnumerable<MlineStyle> source, string name)
    {
      return DBDictionaryHelpers.GetItem<MlineStyle>(source, sd => sd.GetAt(name));
    }

    public static bool Contains(this IEnumerable<MlineStyle> source, string name)
    {
      return DBDictionaryHelpers.Contains<MlineStyle>(source, sd => sd.Contains(name), s => s.Name == name);
    }

    public static bool Contains(this IEnumerable<MlineStyle> source, ObjectId id)
    {
      return DBDictionaryHelpers.Contains<MlineStyle>(source, sd => sd.Contains(id), s => s.ObjectId == id);
    }

    public static ObjectId Add(this IEnumerable<MlineStyle> source, string name, MlineStyle item)
    {
      return DBDictionaryHelpers.Add<MlineStyle>(source, name, item);
    }

    public static IEnumerable<ObjectId> Add(this IEnumerable<MlineStyle> source, IEnumerable<string> names, IEnumerable<MlineStyle> items)
    {
      return DBDictionaryHelpers.AddRange<MlineStyle>(source, names, items);
    }

    public static ObjectId Create(this IEnumerable<MlineStyle> source, string name)
    {
      return DBDictionaryHelpers.Add<MlineStyle>(source, name, new MlineStyle());
    }

    public static IEnumerable<ObjectId> Create(this IEnumerable<MlineStyle> source, IEnumerable<string> names)
    {
      return DBDictionaryHelpers.AddRange<MlineStyle>(source, names, names.Select(n => new MlineStyle()));
    }
  }
}
