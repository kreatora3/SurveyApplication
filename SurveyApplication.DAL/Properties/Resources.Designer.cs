//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SurveyApplication.DAL.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SurveyApplication.DAL.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {&quot;id&quot;:12,&quot;name&quot;:&quot;Sample Form&quot;,&quot;description&quot;:&quot;&lt;p&gt;This is a sample form&lt;br/&gt;description can have &lt;strong&gt;html encoded&lt;/strong&gt;&lt;/p&gt;&quot;,&quot;properties&quot;:{&quot;firstName&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;label&quot;:&quot;First Name&quot;,&quot;required&quot;:true},&quot;lastName&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;label&quot;:&quot;Last Name&quot;,&quot;required&quot;:true},&quot;email&quot;:{&quot;type&quot;:&quot;email&quot;,&quot;label&quot;:&quot;Email&quot;,&quot;required&quot;:true},&quot;age&quot;:{&quot;type&quot;:&quot;number&quot;,&quot;label&quot;:&quot;Your Age&quot;,&quot;required&quot;:false,&quot;minValue&quot;:18,&quot;maxValue&quot;:135}}}.
        /// </summary>
        internal static string details {
            get {
                return ResourceManager.GetString("details", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{&quot;id&quot;:12,&quot;name&quot;:&quot;Sample Form&quot;},{&quot;id&quot;:12,&quot;name&quot;:&quot;Another Sample Form with same Id&quot;},{&quot;id&quot;:12,&quot;name&quot;:&quot;Yet Another Sample Form with same Id&quot;}].
        /// </summary>
        internal static string list {
            get {
                return ResourceManager.GetString("list", resourceCulture);
            }
        }
    }
}
