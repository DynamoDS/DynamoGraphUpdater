﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamoGraphMigrationAssistant.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DynamoGraphMigrationAssistant.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        public static string CancelButtonText {
            get {
                return ResourceManager.GetString("CancelButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap checkmark {
            get {
                object obj = ResourceManager.GetObject("checkmark", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target Dynamo Version:.
        /// </summary>
        public static string DynamoVersionsMsg {
            get {
                return ResourceManager.GetString("DynamoVersionsMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Note: Graphs in target version already, will simply be copied..
        /// </summary>
        public static string DynamoVersionsTooltip {
            get {
                return ResourceManager.GetString("DynamoVersionsTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export.
        /// </summary>
        public static string ExportButtonText {
            get {
                return ResourceManager.GetString("ExportButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dynamo Graph Migration Assistant.
        /// </summary>
        public static string ExtensionName {
            get {
                return ResourceManager.GetString("ExtensionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully migrated {0} graphs.
        /// </summary>
        public static string FinishMsg {
            get {
                return ResourceManager.GetString("FinishMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Migration finished..
        /// </summary>
        public static string FinishMsgTitle {
            get {
                return ResourceManager.GetString("FinishMsgTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully exported {0} image..
        /// </summary>
        public static string FinishSingleMsg {
            get {
                return ResourceManager.GetString("FinishSingleMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Swap Linebreaks to Pinned Notes.
        /// </summary>
        public static string FixInputLinebreaksCheckboxMsg {
            get {
                return ResourceManager.GetString("FixInputLinebreaksCheckboxMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This will split the node name (by new line) to two chunks of text. The first chunk will be a pinned note, the second chunk will be the node name..
        /// </summary>
        public static string FixInputLinebreaksCheckboxTooltip {
            get {
                return ResourceManager.GetString("FixInputLinebreaksCheckboxTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fix input order.
        /// </summary>
        public static string FixInputOrderCheckboxMsg {
            get {
                return ResourceManager.GetString("FixInputOrderCheckboxMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Force order of nodes marked as input by appending a prefix. (Nodes are sorted by Y location values).
        /// </summary>
        public static string FixInputOrderCheckboxTooltip {
            get {
                return ResourceManager.GetString("FixInputOrderCheckboxTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fix node spacing..
        /// </summary>
        public static string FixNodeSpacingCheckboxMsg {
            get {
                return ResourceManager.GetString("FixNodeSpacingCheckboxMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Account for the spacing of the larger nodes in Dynamo 2.13+ UI..
        /// </summary>
        public static string FixNodeSpacingTooltip {
            get {
                return ResourceManager.GetString("FixNodeSpacingTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Graphs in Target Version.
        /// </summary>
        public static string GraphsInTargetVersionMsg {
            get {
                return ResourceManager.GetString("GraphsInTargetVersionMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to graphs selected for update..
        /// </summary>
        public static string GraphsSelectedText {
            get {
                return ResourceManager.GetString("GraphsSelectedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dynamo Graph Migration Assistant.
        /// </summary>
        public static string HeaderText {
            get {
                return ResourceManager.GetString("HeaderText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} if nodes migrated to refactored if..
        /// </summary>
        public static string IfNodeReplacementLogMessage {
            get {
                return ResourceManager.GetString("IfNodeReplacementLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keep folder structure..
        /// </summary>
        public static string KeepFolderStructureCheckboxMsg {
            get {
                return ResourceManager.GetString("KeepFolderStructureCheckboxMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retains the original folder/subfolder structure for graphs location..
        /// </summary>
        public static string KeepFolderStructureTooltip {
            get {
                return ResourceManager.GetString("KeepFolderStructureTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Graphs to Migrate.
        /// </summary>
        public static string MigrateGraphMsg {
            get {
                return ResourceManager.GetString("MigrateGraphMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General Settings.
        /// </summary>
        public static string MiscSettingsMsg {
            get {
                return ResourceManager.GetString("MiscSettingsMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} nodes and notes moved to prevent overlap..
        /// </summary>
        public static string NodesMovedLogMessage {
            get {
                return ResourceManager.GetString("NodesMovedLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target folder contains {0} Dynamo graphs..
        /// </summary>
        public static string NotificationMsg {
            get {
                return ResourceManager.GetString("NotificationMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional Migration Tasks.
        /// </summary>
        public static string OptionalFixesMsg {
            get {
                return ResourceManager.GetString("OptionalFixesMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These migrations tasks are optional as they are more user-specific..
        /// </summary>
        public static string OptionalFixesTooltip {
            get {
                return ResourceManager.GetString("OptionalFixesTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processed {0} out of {1} graphs..
        /// </summary>
        public static string ProcessMsg {
            get {
                return ResourceManager.GetString("ProcessMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap Progress_circle {
            get {
                object obj = ResourceManager.GetObject("Progress_circle", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Migrate if nodes.
        /// </summary>
        public static string ReplaceIfNodesCheckboxMsg {
            get {
                return ResourceManager.GetString("ReplaceIfNodesCheckboxMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Migrates if nodes from previous version to the refactored version..
        /// </summary>
        public static string ReplaceIfNodesCheckboxTooltip {
            get {
                return ResourceManager.GetString("ReplaceIfNodesCheckboxTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resume previous session..
        /// </summary>
        public static string ResumeCheckboxMsg {
            get {
                return ResourceManager.GetString("ResumeCheckboxMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempts to resume the progress from a previous run. The progress is stored within the &apos;log.txt&apos; file in the root Target folder..
        /// </summary>
        public static string ResumeTooltip {
            get {
                return ResourceManager.GetString("ResumeTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select folder ...
        /// </summary>
        public static string SelectFolderMsg {
            get {
                return ResourceManager.GetString("SelectFolderMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export current graph..
        /// </summary>
        public static string SingleExportCheckboxMsg {
            get {
                return ResourceManager.GetString("SingleExportCheckboxMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allows the migration of the current graph..
        /// </summary>
        public static string SingleExportTooltip {
            get {
                return ResourceManager.GetString("SingleExportTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source folder.
        /// </summary>
        public static string SourceFolderMsg {
            get {
                return ResourceManager.GetString("SourceFolderMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Suggested Migration Tasks.
        /// </summary>
        public static string SuggestedFixesMsg {
            get {
                return ResourceManager.GetString("SuggestedFixesMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These tasks are suggested based on the Dynamo version selected..
        /// </summary>
        public static string SuggestedFixesTooltip {
            get {
                return ResourceManager.GetString("SuggestedFixesTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target folder.
        /// </summary>
        public static string TargetFolderMsg {
            get {
                return ResourceManager.GetString("TargetFolderMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select folder..
        /// </summary>
        public static string UpdatePathTooltip {
            get {
                return ResourceManager.GetString("UpdatePathTooltip", resourceCulture);
            }
        }
    }
}
