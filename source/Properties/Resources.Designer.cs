﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySQL.ForExcel.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MySQL.ForExcel.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MySQL For Excel.
        /// </summary>
        internal static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap ArrowDown {
            get {
                object obj = ResourceManager.GetObject("ArrowDown", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap ArrowRight {
            get {
                object obj = ResourceManager.GetObject("ArrowRight", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap clear_output {
            get {
                object obj = ResourceManager.GetObject("clear_output", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you want to create a new connection, please close MySQL Workbench..
        /// </summary>
        internal static string CloseWBAdviceToAdd {
            get {
                return ResourceManager.GetString("CloseWBAdviceToAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you want to remove a connection, please close MySQL Workbench..
        /// </summary>
        internal static string CloseWBAdviceToDelete {
            get {
                return ResourceManager.GetString("CloseWBAdviceToDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data in the current column is not unique..
        /// </summary>
        internal static string ColumnDataNotUniqueWarning {
            get {
                return ResourceManager.GetString("ColumnDataNotUniqueWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This column has already been mapped, do you want to exchange mappings on the two columns?.
        /// </summary>
        internal static string ColumnMappedExchangeDetailWarning {
            get {
                return ResourceManager.GetString("ColumnMappedExchangeDetailWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This column has already been mapped, do you want to overwrite existing mapping?.
        /// </summary>
        internal static string ColumnMappedOverwriteDetailWarning {
            get {
                return ResourceManager.GetString("ColumnMappedOverwriteDetailWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Column Already Mapped.
        /// </summary>
        internal static string ColumnMappedOverwriteTitleWarning {
            get {
                return ResourceManager.GetString("ColumnMappedOverwriteTitleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This column has already been mapped, do you want to remove it and its mapping?.
        /// </summary>
        internal static string ColumnMappedRemove {
            get {
                return ResourceManager.GetString("ColumnMappedRemove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Column mapping for all columns in Excel selection is incomplete. Do you want to proceed with the current mapped data only?.
        /// </summary>
        internal static string ColumnMappingIncompleteDetailWarning {
            get {
                return ResourceManager.GetString("ColumnMappingIncompleteDetailWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Column Mapping Incomplete.
        /// </summary>
        internal static string ColumnMappingIncompleteTitleWarning {
            get {
                return ResourceManager.GetString("ColumnMappingIncompleteTitleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection attempt failed.
        ///Please re-enter your password to try again..
        /// </summary>
        internal static string ConnectFailedDetailWarning {
            get {
                return ResourceManager.GetString("ConnectFailedDetailWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong Password.
        /// </summary>
        internal static string ConnectFailedTitleWarning {
            get {
                return ResourceManager.GetString("ConnectFailedTitleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MySQL Connection is closed, must be opened first to perform action.
        /// </summary>
        internal static string ConnectionClosedError {
            get {
                return ResourceManager.GetString("ConnectionClosedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to Connect to MySQL at {0}:{1} with user {2}.
        /// </summary>
        internal static string ConnectionDataDisplayFailed {
            get {
                return ResourceManager.GetString("ConnectionDataDisplayFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection at {0}:{1} with user {2}.
        /// </summary>
        internal static string ConnectionDataDisplaySuccess {
            get {
                return ResourceManager.GetString("ConnectionDataDisplaySuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t connect to MySQL server on &apos;{0}:{1}&apos;.
        /// </summary>
        internal static string ConnectionFailed {
            get {
                return ResourceManager.GetString("ConnectionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Workbench connections.xml file not found.
        /// </summary>
        internal static string ConnectionsFileNotFound {
            get {
                return ResourceManager.GetString("ConnectionsFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t open MySQL connection since connection string has not been set.
        /// </summary>
        internal static string ConnectionStringNotSet {
            get {
                return ResourceManager.GetString("ConnectionStringNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection parameters are correct..
        /// </summary>
        internal static string ConnectionSuccessfull {
            get {
                return ResourceManager.GetString("ConnectionSuccessfull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current changes will be lost, do you want to continue?.
        /// </summary>
        internal static string CurrentChangesLostConfirmation {
            get {
                return ResourceManager.GetString("CurrentChangesLostConfirmation", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap DeleteHS {
            get {
                object obj = ResourceManager.GetObject("DeleteHS", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {1}{0} rows have been updated successfully..
        /// </summary>
        internal static string EditCommitDetailsUdatedRows {
            get {
                return ResourceManager.GetString("EditCommitDetailsUdatedRows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating data rows...{0}{0}.
        /// </summary>
        internal static string EditCommitDetailsUpdatingRows {
            get {
                return ResourceManager.GetString("EditCommitDetailsUpdatingRows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edited data for Table {0} could not be committed to MySQL..
        /// </summary>
        internal static string EditCommitSummaryError {
            get {
                return ResourceManager.GetString("EditCommitSummaryError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edited data for Table {0} was committed to MySQL successfully..
        /// </summary>
        internal static string EditCommitSummarySuccessful {
            get {
                return ResourceManager.GetString("EditCommitSummarySuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to perform an UPDATE operation on the table data a primary key is needed. Without a primary key MySQL cannot guarantee that the correct rows in the table will be updated.
        ///
        ///For that reason it is advised to add a primary key to each MySQL table.
        ///To do that:
        ///
        ///1. Open MySQL Workbench, connect to the database with the SQL Editor and browse to the table.
        ///2. Click the table with the right mouse button and select ALTER TABLE.
        ///3. Check the PK checkbox of the column that uniquely identifies each row.        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EditOpenDetailsError {
            get {
                return ResourceManager.GetString("EditOpenDetailsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MySQL Table has no Primary Key.
        /// </summary>
        internal static string EditOpenSatusError {
            get {
                return ResourceManager.GetString("EditOpenSatusError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only MySQL tables that have a Primary Key defined can be edited.
        ///Please add a primary key to the table..
        /// </summary>
        internal static string EditOpenSummaryError {
            get {
                return ResourceManager.GetString("EditOpenSummaryError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred creating a new schema: {0}.
        /// </summary>
        internal static string ErrorCreatingNewSchema {
            get {
                return ResourceManager.GetString("ErrorCreatingNewSchema", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap ExcelAddinFilter {
            get {
                object obj = ResourceManager.GetObject("ExcelAddinFilter", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &lt;Alt + N&gt; to move to the next column and &lt;Alt + P&gt; to move to the previous one..
        /// </summary>
        internal static string ExportColumnsGridToolTipCaption {
            get {
                return ResourceManager.GetString("ExportColumnsGridToolTipCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no current data to export to the new table, do you want to proceed just with the table creation?.
        /// </summary>
        internal static string ExportDataNoDataToExportDetailWarning {
            get {
                return ResourceManager.GetString("ExportDataNoDataToExportDetailWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Data to Export.
        /// </summary>
        internal static string ExportDataNoDataToExportTitleWarning {
            get {
                return ResourceManager.GetString("ExportDataNoDataToExportTitleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected Data Type is not suitable for all the values in this column..
        /// </summary>
        internal static string ExportDataTypeNotSuitableWarning {
            get {
                return ResourceManager.GetString("ExportDataTypeNotSuitableWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entered Data Type is not a MySQL recognized data type..
        /// </summary>
        internal static string ExportDataTypeNotValidWarning {
            get {
                return ResourceManager.GetString("ExportDataTypeNotValidWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MySQL Error {0}:{1}.
        /// </summary>
        internal static string GenericMySQLError {
            get {
                return ResourceManager.GetString("GenericMySQLError", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_AppendDlg_Arrow_Down {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_AppendDlg_Arrow_Down", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_AppendDlg_ColumnMapping_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_AppendDlg_ColumnMapping_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_AppendDlg_ManualColumnMapping_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_AppendDlg_ManualColumnMapping_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_Cursor_Dragging_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_Cursor_Dragging_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_Cursor_Dropable_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_Cursor_Dropable_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_Cursor_Trash_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_Cursor_Trash_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_EditDataDlg_Sakila_16x16 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_EditDataDlg_Sakila_16x16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ExportDlg_ColumnOptions_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ExportDlg_ColumnOptions_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ExportDlg_PrimaryKey_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ExportDlg_PrimaryKey_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ExportDlg_TableName_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ExportDlg_TableName_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ImportRoutineDlg_Options_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ImportRoutineDlg_Options_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ImportRoutineDlg_Params_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ImportRoutineDlg_Params_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_InfoDlg_Error_64x64 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_InfoDlg_Error_64x64", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_InfoDlg_Success_64x64 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_InfoDlg_Success_64x64", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_InfoDlg_Warning_64x64 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_InfoDlg_Warning_64x64", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_Input_64x64 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_Input_64x64", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_Logo_48x48 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_Logo_48x48", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_Logo_64x64 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_Logo_64x64", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_AppendData_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_AppendData_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_AppendData_Disabled_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_AppendData_Disabled_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_EditData_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_EditData_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_EditData_Disabled_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_EditData_Disabled_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_ExportToMySQL_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_ExportToMySQL_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_ExportToMySQL_Disabled_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_ExportToMySQL_Disabled_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_ImportData_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_ImportData_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_ImportData_Disabled_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_ImportData_Disabled_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_ListItem_Routine_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_ListItem_Routine_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_ListItem_Table_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_ListItem_Table_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_ListItem_View_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_ListItem_View_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_ObjectPanel_SelectObject_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_ObjectPanel_SelectObject_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_SchemaPanel_ListItem_Schema_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_SchemaPanel_ListItem_Schema_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_SchemaPanel_NewSchema_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_SchemaPanel_NewSchema_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_SchemaPanel_Schemas_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_SchemaPanel_Schemas_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_Security {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_Security", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_Separator {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_Separator", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_WelcomePanel_Connection_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_WelcomePanel_Connection_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_WelcomePanel_Connection_Disabled_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_WelcomePanel_Connection_Disabled_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_WelcomePanel_ListItem_Connection_32x32 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_WelcomePanel_ListItem_Connection_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_WelcomePanel_ManageConnection_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_WelcomePanel_ManageConnection_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_WelcomePanel_NewConnection_24x24 {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_WelcomePanel_NewConnection_24x24", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap MySQLforExcel_WelcomePanel_Title {
            get {
                object obj = ResourceManager.GetObject("MySQLforExcel_WelcomePanel_Title", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is good practice to not use upper case letters or spaces..
        /// </summary>
        internal static string NamesWarning {
            get {
                return ResourceManager.GetString("NamesWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Primary Key column cannot be created because another column has the same name..
        /// </summary>
        internal static string PrimaryKeyColumnExistsWarning {
            get {
                return ResourceManager.GetString("PrimaryKeyColumnExistsWarning", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap refresh_sidebar {
            get {
                object obj = ResourceManager.GetObject("refresh_sidebar", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap remove_col_mapping {
            get {
                object obj = ResourceManager.GetObject("remove_col_mapping", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the selected column?.
        /// </summary>
        internal static string RemoveColumnConfirmation {
            get {
                return ResourceManager.GetString("RemoveColumnConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current changes will be lost, are you sure you want to revert the data?.
        /// </summary>
        internal static string RevertDataConfirmation {
            get {
                return ResourceManager.GetString("RevertDataConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected DB Object used for this action must be of Type =Table..
        /// </summary>
        internal static string SelectedDBObjectNotTable {
            get {
                return ResourceManager.GetString("SelectedDBObjectNotTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty or null DB Object used for this action.  A valid DB Object must be used..
        /// </summary>
        internal static string SelectedDBObjectNull {
            get {
                return ResourceManager.GetString("SelectedDBObjectNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty or null DB Schema used for this action.  A valid Schema must be used..
        /// </summary>
        internal static string SelectedDBSchemaNull {
            get {
                return ResourceManager.GetString("SelectedDBSchemaNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty or null Table used for this action.  A valid Table must be used..
        /// </summary>
        internal static string SelectedTableNull {
            get {
                return ResourceManager.GetString("SelectedTableNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A table with that name already exists in the database..
        /// </summary>
        internal static string TableNameExistsWarning {
            get {
                return ResourceManager.GetString("TableNameExistsWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Table must be new in order to create it in MySQL DB..
        /// </summary>
        internal static string TableNotNewInCreate {
            get {
                return ResourceManager.GetString("TableNotNewInCreate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Table {0} already has an Edit operation ongoing..
        /// </summary>
        internal static string TableWithOperationOngoingError {
            get {
                return ResourceManager.GetString("TableWithOperationOngoingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adding new connections is not allowed when MySQL Workbench is running..
        /// </summary>
        internal static string UnableToAddConnectionsWhenWBRunning {
            get {
                return ResourceManager.GetString("UnableToAddConnectionsWhenWBRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting connections is not allowed while MySQL Workbench is running..
        /// </summary>
        internal static string UnableToDeleteConnectionsWhenWBRunning {
            get {
                return ResourceManager.GetString("UnableToDeleteConnectionsWhenWBRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load databases for the given connection..
        /// </summary>
        internal static string UnableToLoadDatabases {
            get {
                return ResourceManager.GetString("UnableToLoadDatabases", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to retrieve data from &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToRetrieveData {
            get {
                return ResourceManager.GetString("UnableToRetrieveData", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap Warning {
            get {
                object obj = ResourceManager.GetObject("Warning", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
