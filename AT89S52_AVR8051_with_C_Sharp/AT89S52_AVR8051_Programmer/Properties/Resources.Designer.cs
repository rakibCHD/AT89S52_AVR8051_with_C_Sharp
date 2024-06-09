﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AT89S52_AVR8051_Programmer.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AT89S52_AVR8051_Programmer.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The AT89S52 is an 8-bit microcontroller from Microchip Technology (previously by Atmel). It is a part of the 8051 family of microcontrollers,
        ///known for their simplicity and widespread use in embedded systems. 
        ///
        ///    Core:
        ///        8-bit 8051 Compatible Microcontroller
        ///        CPU clock frequency up to 33 MHz
        ///    Memory:
        ///        8 KB of In-System Programmable (ISP) Flash memory
        ///        256 Bytes of RAM
        ///        4 KB of EEPROM (Electrically Erasable Programmable Read-Only Memory)
        ///    I/O Ports:
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AT89S52_about {
            get {
                return ResourceManager.GetString("AT89S52_about", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap At89S52Chip {
            get {
                object obj = ResourceManager.GetObject("At89S52Chip", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon chip {
            get {
                object obj = ResourceManager.GetObject("chip", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Firstly, you must have to upload a dedicated ISP HEX file to make your Arduino Board as a Programmer.
        ///
        ///Click the &quot;Upload (.hex)&quot; button.
        ///
        ///If your Arduino Board is already Connected, you will be asked to disconnect.
        ///
        ///If your Arduino Board is already Disconnected, stay disconnected.
        ///
        ///Browse the necessary files (Avrdude.exe, Avrdude.conf, ISP.hex) properly.
        ///
        ///Then click the &quot;Find Port&quot; button. 
        ///
        ///A message will appear and ask you to connect your Arduino Board within 30 seconds.
        ///
        ///If you don&apos;t connec [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GuideLine {
            get {
                return ResourceManager.GetString("GuideLine", resourceCulture);
            }
        }
    }
}