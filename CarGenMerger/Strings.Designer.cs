﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarGenMerger {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CarGenMerger.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Combines together car generators from multiple GTA3/VC saves. Car generators in the target save are replaced with differing car generators from one or more source saves. Car generators in the target save are replaced at random unless a priority list is specified..
        /// </summary>
        public static string AppDescription {
            get {
                return ResourceManager.GetString("AppDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cgmerge.
        /// </summary>
        public static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GTA Car Generator Merger Tool.
        /// </summary>
        public static string AppTitle {
            get {
                return ResourceManager.GetString("AppTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cgmerge [options] target source [source2 [...]].
        /// </summary>
        public static string AppUsage {
            get {
                return ResourceManager.GetString("AppUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage.
        /// </summary>
        public static string AppUsagePrefix {
            get {
                return ResourceManager.GetString("AppUsagePrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Bad value for &apos;{0}&apos;..
        /// </summary>
        public static string ErrorText_BadOptionValue {
            get {
                return ResourceManager.GetString("ErrorText_BadOptionValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Failed to open file. ({0}).
        /// </summary>
        public static string ErrorText_FailedToOpenFile {
            get {
                return ResourceManager.GetString("ErrorText_FailedToOpenFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Missing value for &apos;{0}&apos;..
        /// </summary>
        public static string ErrorText_MissingOptionValue {
            get {
                return ResourceManager.GetString("ErrorText_MissingOptionValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Missing required option &apos;{0}&apos;..
        /// </summary>
        public static string ErrorText_MissingRequiredOption {
            get {
                return ResourceManager.GetString("ErrorText_MissingRequiredOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Missing required argument..
        /// </summary>
        public static string ErrorText_MissingRequiredPositional {
            get {
                return ResourceManager.GetString("ErrorText_MissingRequiredPositional", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Multiple values for option &apos;{0}&apos; have been provided..
        /// </summary>
        public static string ErrorText_RepeatedOption {
            get {
                return ResourceManager.GetString("ErrorText_RepeatedOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Unknown error. ({0}).
        /// </summary>
        public static string ErrorText_UnknownError {
            get {
                return ResourceManager.GetString("ErrorText_UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Unknown option &apos;{0}&apos;..
        /// </summary>
        public static string ErrorText_UnknownOption {
            get {
                return ResourceManager.GetString("ErrorText_UnknownOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The save type..
        /// </summary>
        public static string HelpText_Mode {
            get {
                return ResourceManager.GetString("HelpText_Mode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path to the resulting save. If not provided, the target save will be overwritten..
        /// </summary>
        public static string HelpText_Output {
            get {
                return ResourceManager.GetString("HelpText_Output", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A CSV file specifying the order in which car generators in the target save should be replaced. The columns are (priority,index) where 0 is the highest priority and index refers to the index of a car generator in the target save&apos;s car generator list. If multiple entries share the same priority, the index for this priority will be chosen at random. A negative priority excludes the car generator from being replaced. Lines beginning with &apos;#&apos; are ignored..
        /// </summary>
        public static string HelpText_PriorityList {
            get {
                return ResourceManager.GetString("HelpText_PriorityList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the collision radius. If two car generators are found within the collision radius, the process will be aborted. (TODO: change to skip car conflicts rather than abort?).
        /// </summary>
        public static string HelpText_Radius {
            get {
                return ResourceManager.GetString("HelpText_Radius", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the output save&apos;s in-game title..
        /// </summary>
        public static string HelpText_Title {
            get {
                return ResourceManager.GetString("HelpText_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable verbose output..
        /// </summary>
        public static string HelpText_Verbose {
            get {
                return ResourceManager.GetString("HelpText_Verbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}:{1}: Index exceeds maximum value of {2}..
        /// </summary>
        public static string WarningText_PriorityListIndexExceedsMaximum {
            get {
                return ResourceManager.GetString("WarningText_PriorityListIndexExceedsMaximum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}:{1}: Line is malformatted..
        /// </summary>
        public static string WarningText_PriorityListMalformedLine {
            get {
                return ResourceManager.GetString("WarningText_PriorityListMalformedLine", resourceCulture);
            }
        }
    }
}
