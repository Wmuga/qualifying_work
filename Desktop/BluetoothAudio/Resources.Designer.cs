﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BluetoothAudio {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BluetoothAudio.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на Cannot connect to device &quot;{}&quot;.
        /// </summary>
        internal static string STR_CANT_CONNECT {
            get {
                return ResourceManager.GetString("STR_CANT_CONNECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Connected.
        /// </summary>
        internal static string STR_CONNECTED {
            get {
                return ResourceManager.GetString("STR_CONNECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Device &quot;{}&quot; disappeared from watcher&apos;s list.
        /// </summary>
        internal static string STR_LOST_DEVICE {
            get {
                return ResourceManager.GetString("STR_LOST_DEVICE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Device &quot;{}&quot; is not in watcher&apos;s list.
        /// </summary>
        internal static string STR_NOT_FOUND {
            get {
                return ResourceManager.GetString("STR_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на System denied.
        /// </summary>
        internal static string STR_SYS_DENIED {
            get {
                return ResourceManager.GetString("STR_SYS_DENIED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Timeout.
        /// </summary>
        internal static string STR_TIMEOUT {
            get {
                return ResourceManager.GetString("STR_TIMEOUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Unknown failure.
        /// </summary>
        internal static string STR_UNKNOWN_FAIL {
            get {
                return ResourceManager.GetString("STR_UNKNOWN_FAIL", resourceCulture);
            }
        }
    }
}