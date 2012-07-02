﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MySQL.ForExcel
{
  public partial class AutoStyleableBaseForm : Form
  {
    [Category("Appearance"), DefaultValue(true), Description("Indicates whether or not the form automatically uses the system default font.")]
    public bool UseSystemFont { get; set; }

    [Category("Appearance"), DefaultValue(true), Description("Applies the System Font to all controls in the InheritFontToControlsList.")]
    public bool InheritSystemFontToControls { get; set; }

    [Category("Appearance"), Description("List of control names that should inherit the System Font; when null all controls will inherit it.")]
    public List<string> InheritFontToControlsList { get; set; }

    [Category("Appearance"), Description("List of control names that should NOT inherit the System Font.")]
    public List<string> InheritFontToControlsExceptionList { get; set; }

    public AutoStyleableBaseForm()
    {
      InitializeComponent();

      UseSystemFont = true;
      InheritSystemFontToControls = true;
      InheritFontToControlsList = new List<string>();
      InheritFontToControlsExceptionList = new List<string>();
    }

    protected virtual void InheritFontToControls(Control.ControlCollection controls)
    {
      if (!InheritSystemFontToControls || controls == null || controls.Count == 0)
        return;

      foreach (Control c in controls)
      {
        if (InheritFontToControlsList != null && !InheritFontToControlsList.Contains(c.Name))
          return;
        if (InheritFontToControlsExceptionList != null && InheritFontToControlsExceptionList.Contains(c.Name))
          return;
        if (c.Font.Name != Font.Name)
          c.Font = new Font(Font.FontFamily, c.Font.Size, c.Font.Style);
        InheritFontToControls(c.Controls);
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      if (!DesignMode && UseSystemFont)
      {
        Font = System.Drawing.SystemFonts.IconTitleFont;
        Microsoft.Win32.SystemEvents.UserPreferenceChanged += new Microsoft.Win32.UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
      }
      InheritFontToControls(Controls);
      base.OnLoad(e);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      base.OnFormClosed(e);
      Microsoft.Win32.SystemEvents.UserPreferenceChanged -= new Microsoft.Win32.UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
    }

    private void SystemEvents_UserPreferenceChanged(object sender, Microsoft.Win32.UserPreferenceChangedEventArgs e)
    {
      if (e.Category == Microsoft.Win32.UserPreferenceCategory.Window && UseSystemFont)
        this.Font = System.Drawing.SystemFonts.IconTitleFont;
    }
  }
}