﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Day5 {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Day5.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to [N]     [Q]         [N]            
        ///[R]     [F] [Q]     [G] [M]        
        ///[J]     [Z] [T]     [R] [H] [J]    
        ///[T] [H] [G] [R]     [B] [N] [T]    
        ///[Z] [J] [J] [G] [F] [Z] [S] [M]    
        ///[B] [N] [N] [N] [Q] [W] [L] [Q] [S]
        ///[D] [S] [R] [V] [T] [C] [C] [N] [G]
        ///[F] [R] [C] [F] [L] [Q] [F] [D] [P]
        /// 1   2   3   4   5   6   7   8   9 
        ///
        ///move 3 from 9 to 4
        ///move 2 from 5 to 2
        ///move 8 from 1 to 9
        ///move 4 from 7 to 1
        ///move 5 from 3 to 8
        ///move 3 from 3 to 7
        ///move 11 from 8 to 3
        ///move 7 from 3 to 6
        ///move 2 from 5 to [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Input {
            get {
                return ResourceManager.GetString("Input", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     [D]    
        ///[N] [C]    
        ///[Z] [M] [P]
        /// 1   2   3 
        ///
        ///move 1 from 2 to 1
        ///move 3 from 1 to 3
        ///move 2 from 2 to 1
        ///move 1 from 1 to 2.
        /// </summary>
        internal static string Sample {
            get {
                return ResourceManager.GetString("Sample", resourceCulture);
            }
        }
    }
}
