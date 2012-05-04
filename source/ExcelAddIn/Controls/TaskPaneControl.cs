﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using MySQL.Utility;

namespace MySQL.ExcelAddIn
{
  public partial class TaskPaneControl : UserControl
  {
    private Excel.Application excelApplication;
    private MySqlWorkbenchConnection connection;
    //private MySQLSchemaInfo schemaInfo;

    public Excel.Worksheet ActiveWorksheet
    {
      get { return ((Excel.Worksheet)excelApplication.ActiveSheet); }
    }

    public TaskPaneControl(Excel.Application app)
    {
      excelApplication = app;
      excelApplication.SheetSelectionChange += new Excel.AppEvents_SheetSelectionChangeEventHandler(excelApplication_SheetSelectionChange);
      InitializeComponent();
    }

    void excelApplication_SheetSelectionChange(object Sh, Excel.Range Target)
    {
      if (!this.Visible)
        return;

      int selectedCellsCount = Target.Count;
      int blankCellsInRangeCount = Target.SpecialCells(Excel.XlCellType.xlCellTypeBlanks).Count;
      bool emptyRange = selectedCellsCount == blankCellsInRangeCount;
      dbObjectSelectionPanel1.ExportDataActionEnabled = !emptyRange;
    }

    public void OpenConnection(MySqlWorkbenchConnection connection)
    {
      this.connection = connection;
      if (connection.Password == null)
      {
        PasswordDialog dlg = new PasswordDialog();
        dlg.HostIdentifier = connection.HostIdentifier;
        dlg.UserName = connection.UserName;
        dlg.PasswordText = String.Empty;
        if (dlg.ShowDialog() == DialogResult.Cancel) return;
        connection.Password = dlg.PasswordText;
      }
      schemaSelectionPanel1.SetConnection(connection);
      schemaSelectionPanel1.BringToFront();
    }

    public void CloseConnection()
    {
      welcomePanel1.BringToFront();
      connection = null;
    }

    public void OpenSchema(string schema)
    {
      connection.Schema = schema;
      dbObjectSelectionPanel1.SetConnection(connection);
      dbObjectSelectionPanel1.BringToFront();
    }

    public void CloseSchema()
    {
      schemaSelectionPanel1.BringToFront();
    }

    //bool dbObjectSelectionPanel1_DBObjectSelectionPanelLeaving(object sender, DBObjectSelectionPanelLeavingArgs args)
    //{
    //  bool success = false;

    //  switch (args.SelectedAction)
    //  {
    //    case DBObjectSelectionPanelLeavingAction.Back:
    //      schemaInfo.CurrentSchema = String.Empty;
    //      welcomePanel1.Visible = false;
    //      schemaSelectionPanel1.Visible = true;
    //      dbObjectSelectionPanel1.Visible = false;
    //      success = true;
    //      break;
    //    case DBObjectSelectionPanelLeavingAction.Close:
    //      CloseAddIn();
    //      success = true;
    //      break;
    //    case DBObjectSelectionPanelLeavingAction.Import:
    //      success = importDataToExcel(args.DataForExcel);
    //      break;
    //    case DBObjectSelectionPanelLeavingAction.Edit:
    //      break;
    //    case DBObjectSelectionPanelLeavingAction.Append:
    //      success = appendDataToTable();
    //      break;
    //  }

    //  return success;
    //}

    public void ImportDataToExcel(DataTable dt, List<string> headersList)
    {
      if (dt != null && dt.Rows.Count > 0)
      {
        int rowsCount = dt.Rows.Count;
        int colsCount = dt.Columns.Count;
        bool containsHeaders = headersList != null && headersList.Count > 0;
        int startingRow = (containsHeaders ? 1 : 0);

        Excel.Worksheet currentSheet = excelApplication.ActiveSheet as Excel.Worksheet;
        Excel.Range currentCell = excelApplication.ActiveCell;
        Excel.Range fillingRange = currentCell.get_Resize(rowsCount, colsCount);
        string[,] fillingArray = new string[rowsCount + startingRow, colsCount];

        if (containsHeaders)
        {
          for (int currCol = 0; currCol < colsCount; currCol++)
          {
            fillingArray[0, currCol] = headersList[currCol];
          }
        }

        for (int currRow = startingRow; currRow < rowsCount; currRow++)
        {
          for (int currCol = 0; currCol < colsCount; currCol++)
          {
            fillingArray[currRow, currCol] = dt.Rows[currRow][currCol].ToString();
          }
        }
        fillingRange.set_Value(Type.Missing, fillingArray);
      }
    }

    public void AppendDataToTable(string toTableName)
    {
      ExportDataToTableDialog exportDataForm = new ExportDataToTableDialog(connection, connection.Schema, toTableName, excelApplication.Selection as Excel.Range);
      DialogResult dr = exportDataForm.ShowDialog();
    }

    public void CloseAddIn()
    {
      //      Globals.ThisAddIn.TaskPane.Visible = false;
      welcomePanel1.Visible = true;
      schemaSelectionPanel1.Visible = false;
      dbObjectSelectionPanel1.Visible = false;
    }
  }

}
