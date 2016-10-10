﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.DatabaseServices;

namespace Linq2Acad
{
  /// <summary>
  /// This class encapsulates a set of strings that can be used to add additional information to a DWG file.
  /// </summary>
  public class AcadSummaryInfo
  {
    private Database database;

    private ObservableDictionary customProperties;
    private string author;
    private string comments;
    private string hyperlinkBase;
    private string keywords;
    private string lastSavedBy;
    private string revisionNumber;
    private string subject;
    private string title;

    private bool customPropertiesChanged;
    private bool authorChanged;
    private bool commentsChanged;
    private bool hyperlinkBaseChanged;
    private bool keywordsChanged;
    private bool lastSavedByChanged;
    private bool revisionNumberChanged;
    private bool subjectChanged;
    private bool titleChanged;

    /// <summary>
    /// Creates a new instance of AcadSummaryInfo.
    /// </summary>
    /// <param name="database">The drawing database to use.</param>
    internal AcadSummaryInfo(Database database)
    {
      this.database = database;
    }

    /// <summary>
    /// True, if a property has changed. Else, false.
    /// </summary>
    internal bool Changed
    {
      get
      {
        return customPropertiesChanged ||
               authorChanged ||
               commentsChanged ||
               hyperlinkBaseChanged ||
               keywordsChanged ||
               lastSavedByChanged ||
               revisionNumberChanged ||
               subjectChanged ||
               titleChanged;
      }
    }

    /// <summary>
    /// Commits the changes made to the summary info.
    /// </summary>
    internal void Commit()
    {
      if (Changed)
      {
        var builder = new DatabaseSummaryInfoBuilder(database.SummaryInfo);

        if (customPropertiesChanged)
        {
          builder.CustomPropertyTable.Clear();

          foreach (var kvp in customProperties)
          {
            builder.CustomPropertyTable[kvp.Key] = kvp;
          }
        }

        if (authorChanged)
        {
          builder.Author = author;
        }

        if (commentsChanged)
        {
          builder.Comments = comments;
        }

        if (hyperlinkBaseChanged)
        {
          builder.HyperlinkBase = hyperlinkBase;
        }

        if (keywordsChanged)
        {
          builder.Keywords = keywords;
        }

        if (lastSavedByChanged)
        {
          builder.LastSavedBy = lastSavedBy;
        }

        if (revisionNumberChanged)
        {
          builder.RevisionNumber = revisionNumber;
        }

        if (subjectChanged)
        {
          builder.Subject = subject;
        }

        if (titleChanged)
        {
          builder.Title = title;
        }

        database.SummaryInfo = builder.ToDatabaseSummaryInfo();
      }
    }

    /// <summary>
    /// Accesses the custom properties property value.
    /// </summary>
    public IDictionary<object, object> CustomProperties
    {
      get
      {
        if (customProperties == null)
        {
          customProperties = new ObservableDictionary();

          while (database.SummaryInfo.CustomProperties.MoveNext())
          {
            customProperties[database.SummaryInfo.CustomProperties.Key] = database.SummaryInfo.CustomProperties;
          }

          customProperties.Changed += (sender, e) => customPropertiesChanged = true;
        }

        return customProperties;
      }
    }

    /// <summary>
    /// Accesses the author property value.
    /// </summary>
    public string Author
    {
      get
      {
        if (author == null)
        {
          author = database.SummaryInfo.Author;
        }

        return author;
      }
      set
      {
        author = value;
        authorChanged = true;
      }
    }

    /// <summary>
    /// Accesses the comments property value.
    /// </summary>
    public string Comments
    {
      get
      {
        if (comments == null)
        {
          comments = database.SummaryInfo.Comments;
        }

        return comments;
      }
      set
      {
        comments = value;
        commentsChanged = true;
      }
    }

    /// <summary>
    /// Accesses the hyperlink base property value.
    /// </summary>
    public string HyperlinkBase
    {
      get
      {
        if (hyperlinkBase == null)
        {
          hyperlinkBase = database.SummaryInfo.HyperlinkBase;
        }

        return hyperlinkBase;
      }
      set
      {
        hyperlinkBase = value;
        hyperlinkBaseChanged = true;
      }
    }

    /// <summary>
    /// Accesses the keywords property value.
    /// </summary>
    public string Keywords
    {
      get
      {
        if (keywords == null)
        {
          keywords = database.SummaryInfo.Keywords;
        }

        return keywords;
      }
      set
      {
        keywords = value;
        keywordsChanged = true;
      }
    }

    /// <summary>
    /// Accesses the last saved by property value.
    /// </summary>
    public string LastSavedBy
    {
      get
      {
        if (lastSavedBy == null)
        {
          lastSavedBy = database.SummaryInfo.LastSavedBy;
        }

        return lastSavedBy;
      }
      set
      {
        lastSavedBy = value;
        lastSavedByChanged = true;
      }
    }

    /// <summary>
    /// Accesses the revision number property value.
    /// </summary>
    public string RevisionNumber
    {
      get
      {
        if (revisionNumber == null)
        {
          revisionNumber = database.SummaryInfo.RevisionNumber;
        }

        return revisionNumber;
      }
      set
      {
        revisionNumber = value;
        revisionNumberChanged = true;
      }
    }

    /// <summary>
    /// Accesses the subject property value.
    /// </summary>
    public string Subject
    {
      get
      {
        if (subject == null)
        {
          subject = database.SummaryInfo.Subject;
        }

        return subject;
      }
      set
      {
        subject = value;
        subjectChanged = true;
      }
    }

    /// <summary>
    /// Accesses the title property value.
    /// </summary>
    public string Title
    {
      get
      {
        if (title == null)
        {
          title = database.SummaryInfo.Title;
        }

        return title;
      }
      set
      {
        title = value;
        titleChanged = true;
      }
    }

    #region Nested class ObservableDictionary

    private class ObservableDictionary : Dictionary<object, object>
    {
      #region Changed event

      public event EventHandler Changed;

      private void OnChanged()
      {
        if (Changed == null)
        {
          Changed(this, EventArgs.Empty);
        }
      }

      #endregion

      public new void Add(object key, object value)
      {
        base.Add(key, value);
        OnChanged();
      }

      public new void Remove(object key)
      {
        base.Remove(key);
        OnChanged();
      }

      public new void Clear()
      {
        base.Clear();
        OnChanged();
      }

      public new object this[object key]
      {
        get { return base[key]; }
        set
        {
          base[key] = value;
          OnChanged();
        }
      }
    }

    #endregion
  }
}