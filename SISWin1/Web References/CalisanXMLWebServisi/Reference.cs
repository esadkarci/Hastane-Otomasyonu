﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace SISWin1.CalisanXMLWebServisi {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CalisanServisiSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Kisi))]
    public partial class CalisanServisi : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback KullaniciGirisiniDogrulaOperationCompleted;
        
        private System.Threading.SendOrPostCallback CalisanGetirOperationCompleted;
        
        private System.Threading.SendOrPostCallback parolaDegistirOperationCompleted;
        
        private System.Threading.SendOrPostCallback parolaSifirlaOperationCompleted;
        
        private System.Threading.SendOrPostCallback KaydetOperationCompleted;
        
        private System.Threading.SendOrPostCallback CalisanlariListeleOperationCompleted;
        
        private System.Threading.SendOrPostCallback UzmanlariListeleOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CalisanServisi() {
            this.Url = global::SISWin1.Properties.Settings.Default.SISWin1_CalisanXMLWebServisi_CalisanServisi;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event KullaniciGirisiniDogrulaCompletedEventHandler KullaniciGirisiniDogrulaCompleted;
        
        /// <remarks/>
        public event CalisanGetirCompletedEventHandler CalisanGetirCompleted;
        
        /// <remarks/>
        public event parolaDegistirCompletedEventHandler parolaDegistirCompleted;
        
        /// <remarks/>
        public event parolaSifirlaCompletedEventHandler parolaSifirlaCompleted;
        
        /// <remarks/>
        public event KaydetCompletedEventHandler KaydetCompleted;
        
        /// <remarks/>
        public event CalisanlariListeleCompletedEventHandler CalisanlariListeleCompleted;
        
        /// <remarks/>
        public event UzmanlariListeleCompletedEventHandler UzmanlariListeleCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KullaniciGirisiniDogrula", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int KullaniciGirisiniDogrula(string ePosta, string parola) {
            object[] results = this.Invoke("KullaniciGirisiniDogrula", new object[] {
                        ePosta,
                        parola});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void KullaniciGirisiniDogrulaAsync(string ePosta, string parola) {
            this.KullaniciGirisiniDogrulaAsync(ePosta, parola, null);
        }
        
        /// <remarks/>
        public void KullaniciGirisiniDogrulaAsync(string ePosta, string parola, object userState) {
            if ((this.KullaniciGirisiniDogrulaOperationCompleted == null)) {
                this.KullaniciGirisiniDogrulaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKullaniciGirisiniDogrulaOperationCompleted);
            }
            this.InvokeAsync("KullaniciGirisiniDogrula", new object[] {
                        ePosta,
                        parola}, this.KullaniciGirisiniDogrulaOperationCompleted, userState);
        }
        
        private void OnKullaniciGirisiniDogrulaOperationCompleted(object arg) {
            if ((this.KullaniciGirisiniDogrulaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KullaniciGirisiniDogrulaCompleted(this, new KullaniciGirisiniDogrulaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalisanGetir", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Calisan CalisanGetir(int calisanNo) {
            object[] results = this.Invoke("CalisanGetir", new object[] {
                        calisanNo});
            return ((Calisan)(results[0]));
        }
        
        /// <remarks/>
        public void CalisanGetirAsync(int calisanNo) {
            this.CalisanGetirAsync(calisanNo, null);
        }
        
        /// <remarks/>
        public void CalisanGetirAsync(int calisanNo, object userState) {
            if ((this.CalisanGetirOperationCompleted == null)) {
                this.CalisanGetirOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalisanGetirOperationCompleted);
            }
            this.InvokeAsync("CalisanGetir", new object[] {
                        calisanNo}, this.CalisanGetirOperationCompleted, userState);
        }
        
        private void OnCalisanGetirOperationCompleted(object arg) {
            if ((this.CalisanGetirCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalisanGetirCompleted(this, new CalisanGetirCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/parolaDegistir", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool parolaDegistir(int calisanNo, string yeniParola) {
            object[] results = this.Invoke("parolaDegistir", new object[] {
                        calisanNo,
                        yeniParola});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void parolaDegistirAsync(int calisanNo, string yeniParola) {
            this.parolaDegistirAsync(calisanNo, yeniParola, null);
        }
        
        /// <remarks/>
        public void parolaDegistirAsync(int calisanNo, string yeniParola, object userState) {
            if ((this.parolaDegistirOperationCompleted == null)) {
                this.parolaDegistirOperationCompleted = new System.Threading.SendOrPostCallback(this.OnparolaDegistirOperationCompleted);
            }
            this.InvokeAsync("parolaDegistir", new object[] {
                        calisanNo,
                        yeniParola}, this.parolaDegistirOperationCompleted, userState);
        }
        
        private void OnparolaDegistirOperationCompleted(object arg) {
            if ((this.parolaDegistirCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.parolaDegistirCompleted(this, new parolaDegistirCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/parolaSifirla", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool parolaSifirla(string ePosta, string parola) {
            object[] results = this.Invoke("parolaSifirla", new object[] {
                        ePosta,
                        parola});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void parolaSifirlaAsync(string ePosta, string parola) {
            this.parolaSifirlaAsync(ePosta, parola, null);
        }
        
        /// <remarks/>
        public void parolaSifirlaAsync(string ePosta, string parola, object userState) {
            if ((this.parolaSifirlaOperationCompleted == null)) {
                this.parolaSifirlaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnparolaSifirlaOperationCompleted);
            }
            this.InvokeAsync("parolaSifirla", new object[] {
                        ePosta,
                        parola}, this.parolaSifirlaOperationCompleted, userState);
        }
        
        private void OnparolaSifirlaOperationCompleted(object arg) {
            if ((this.parolaSifirlaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.parolaSifirlaCompleted(this, new parolaSifirlaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Kaydet", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Kaydet(Calisan calisan) {
            object[] results = this.Invoke("Kaydet", new object[] {
                        calisan});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void KaydetAsync(Calisan calisan) {
            this.KaydetAsync(calisan, null);
        }
        
        /// <remarks/>
        public void KaydetAsync(Calisan calisan, object userState) {
            if ((this.KaydetOperationCompleted == null)) {
                this.KaydetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKaydetOperationCompleted);
            }
            this.InvokeAsync("Kaydet", new object[] {
                        calisan}, this.KaydetOperationCompleted, userState);
        }
        
        private void OnKaydetOperationCompleted(object arg) {
            if ((this.KaydetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KaydetCompleted(this, new KaydetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalisanlariListele", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Calisan[] CalisanlariListele(string ad, string soyad) {
            object[] results = this.Invoke("CalisanlariListele", new object[] {
                        ad,
                        soyad});
            return ((Calisan[])(results[0]));
        }
        
        /// <remarks/>
        public void CalisanlariListeleAsync(string ad, string soyad) {
            this.CalisanlariListeleAsync(ad, soyad, null);
        }
        
        /// <remarks/>
        public void CalisanlariListeleAsync(string ad, string soyad, object userState) {
            if ((this.CalisanlariListeleOperationCompleted == null)) {
                this.CalisanlariListeleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalisanlariListeleOperationCompleted);
            }
            this.InvokeAsync("CalisanlariListele", new object[] {
                        ad,
                        soyad}, this.CalisanlariListeleOperationCompleted, userState);
        }
        
        private void OnCalisanlariListeleOperationCompleted(object arg) {
            if ((this.CalisanlariListeleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalisanlariListeleCompleted(this, new CalisanlariListeleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UzmanlariListele", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Calisan[] UzmanlariListele() {
            object[] results = this.Invoke("UzmanlariListele", new object[0]);
            return ((Calisan[])(results[0]));
        }
        
        /// <remarks/>
        public void UzmanlariListeleAsync() {
            this.UzmanlariListeleAsync(null);
        }
        
        /// <remarks/>
        public void UzmanlariListeleAsync(object userState) {
            if ((this.UzmanlariListeleOperationCompleted == null)) {
                this.UzmanlariListeleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUzmanlariListeleOperationCompleted);
            }
            this.InvokeAsync("UzmanlariListele", new object[0], this.UzmanlariListeleOperationCompleted, userState);
        }
        
        private void OnUzmanlariListeleOperationCompleted(object arg) {
            if ((this.UzmanlariListeleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UzmanlariListeleCompleted(this, new UzmanlariListeleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Calisan : Kisi {
        
        private string unvanField;
        
        private string parolaField;
        
        private CalisanTipleri calisanTipiField;
        
        /// <remarks/>
        public string Unvan {
            get {
                return this.unvanField;
            }
            set {
                this.unvanField = value;
            }
        }
        
        /// <remarks/>
        public string Parola {
            get {
                return this.parolaField;
            }
            set {
                this.parolaField = value;
            }
        }
        
        /// <remarks/>
        public CalisanTipleri CalisanTipi {
            get {
                return this.calisanTipiField;
            }
            set {
                this.calisanTipiField = value;
            }
        }

        
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum CalisanTipleri {
        
        /// <remarks/>
        SistemYoneticisi,
        
        /// <remarks/>
        Sekreter,
        
        /// <remarks/>
        Uzman,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Calisan))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Kisi {
        
        private int noField;
        
        private string tCKimlikNoField;
        
        private string adField;
        
        private string soyadField;
        
        private string epostaField;
        
        private string cepTelField;
        
        private string evTelField;
        
        /// <remarks/>
        public int No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string TCKimlikNo {
            get {
                return this.tCKimlikNoField;
            }
            set {
                this.tCKimlikNoField = value;
            }
        }
        
        /// <remarks/>
        public string Ad {
            get {
                return this.adField;
            }
            set {
                this.adField = value;
            }
        }
        
        /// <remarks/>
        public string Soyad {
            get {
                return this.soyadField;
            }
            set {
                this.soyadField = value;
            }
        }
        
        /// <remarks/>
        public string Eposta {
            get {
                return this.epostaField;
            }
            set {
                this.epostaField = value;
            }
        }
        
        /// <remarks/>
        public string CepTel {
            get {
                return this.cepTelField;
            }
            set {
                this.cepTelField = value;
            }
        }
        
        /// <remarks/>
        public string EvTel {
            get {
                return this.evTelField;
            }
            set {
                this.evTelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void KullaniciGirisiniDogrulaCompletedEventHandler(object sender, KullaniciGirisiniDogrulaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KullaniciGirisiniDogrulaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KullaniciGirisiniDogrulaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CalisanGetirCompletedEventHandler(object sender, CalisanGetirCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalisanGetirCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalisanGetirCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Calisan Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Calisan)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void parolaDegistirCompletedEventHandler(object sender, parolaDegistirCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class parolaDegistirCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal parolaDegistirCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void parolaSifirlaCompletedEventHandler(object sender, parolaSifirlaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class parolaSifirlaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal parolaSifirlaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void KaydetCompletedEventHandler(object sender, KaydetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KaydetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KaydetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CalisanlariListeleCompletedEventHandler(object sender, CalisanlariListeleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalisanlariListeleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalisanlariListeleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Calisan[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Calisan[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UzmanlariListeleCompletedEventHandler(object sender, UzmanlariListeleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UzmanlariListeleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UzmanlariListeleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Calisan[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Calisan[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591