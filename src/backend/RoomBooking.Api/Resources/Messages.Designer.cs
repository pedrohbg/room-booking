﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoomBooking.Api.Resources {
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
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RoomBooking.Api.Resources.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to Não foi possível alterar sua senha neste momento. Tente novamente mais tarde..
        /// </summary>
        public static string ChangePasswordFail {
            get {
                return ResourceManager.GetString("ChangePasswordFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Senha alterada com sucesso..
        /// </summary>
        public static string ChangePasswordSuccess {
            get {
                return ResourceManager.GetString("ChangePasswordSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Falha ao criar usuário. Tente novamente mais tarde..
        /// </summary>
        public static string FailedToCreateNewUser {
            get {
                return ResourceManager.GetString("FailedToCreateNewUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Falha ao obter informações do usuário..
        /// </summary>
        public static string FailedToRetrieveUserInformation {
            get {
                return ResourceManager.GetString("FailedToRetrieveUserInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sua senha não pode ser restaurada. Tente novamente mais tarde..
        /// </summary>
        public static string ResetPasswordFail {
            get {
                return ResourceManager.GetString("ResetPasswordFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Senha resetada com sucesso. Sua nova senha foi enviada para {0}..
        /// </summary>
        public static string ResetPasswordSuccess {
            get {
                return ResourceManager.GetString("ResetPasswordSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Falha ao atualizar perfil. Tente novamente mais tarde..
        /// </summary>
        public static string UpdateProfileFail {
            get {
                return ResourceManager.GetString("UpdateProfileFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Perfil atualizado com sucesso..
        /// </summary>
        public static string UpdateProfileSuccess {
            get {
                return ResourceManager.GetString("UpdateProfileSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuário ou senha inválidos..
        /// </summary>
        public static string UsernameOrPasswordIsInvalid {
            get {
                return ResourceManager.GetString("UsernameOrPasswordIsInvalid", resourceCulture);
            }
        }
    }
}
