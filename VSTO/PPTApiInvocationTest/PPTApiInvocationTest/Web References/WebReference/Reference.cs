﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace PPTApiInvocationTest.WebReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PPTServiceSoap", Namespace="localhost")]
    public partial class PPTService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CreatePPTOperationCompleted;
        
        private System.Threading.SendOrPostCallback PPTHasGeneratedOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetImageByBase64OperationCompleted;
        
        private System.Threading.SendOrPostCallback CreatePDFOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateLeJiaPDFOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateKingPPTOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateCustomerPPTOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateLeJiaPPTOperationCompleted;
        
        private System.Threading.SendOrPostCallback XLSConvertToPDFOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PPTService() {
            this.Url = global::PPTApiInvocationTest.Properties.Settings.Default.PPTApiInvocationTest_WebReference_PPTService;
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
        public event CreatePPTCompletedEventHandler CreatePPTCompleted;
        
        /// <remarks/>
        public event PPTHasGeneratedCompletedEventHandler PPTHasGeneratedCompleted;
        
        /// <remarks/>
        public event GetImageByBase64CompletedEventHandler GetImageByBase64Completed;
        
        /// <remarks/>
        public event CreatePDFCompletedEventHandler CreatePDFCompleted;
        
        /// <remarks/>
        public event CreateLeJiaPDFCompletedEventHandler CreateLeJiaPDFCompleted;
        
        /// <remarks/>
        public event CreateKingPPTCompletedEventHandler CreateKingPPTCompleted;
        
        /// <remarks/>
        public event CreateCustomerPPTCompletedEventHandler CreateCustomerPPTCompleted;
        
        /// <remarks/>
        public event CreateLeJiaPPTCompletedEventHandler CreateLeJiaPPTCompleted;
        
        /// <remarks/>
        public event XLSConvertToPDFCompletedEventHandler XLSConvertToPDFCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/CreatePPT", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreatePPT(string xmlContent) {
            object[] results = this.Invoke("CreatePPT", new object[] {
                        xmlContent});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreatePPTAsync(string xmlContent) {
            this.CreatePPTAsync(xmlContent, null);
        }
        
        /// <remarks/>
        public void CreatePPTAsync(string xmlContent, object userState) {
            if ((this.CreatePPTOperationCompleted == null)) {
                this.CreatePPTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreatePPTOperationCompleted);
            }
            this.InvokeAsync("CreatePPT", new object[] {
                        xmlContent}, this.CreatePPTOperationCompleted, userState);
        }
        
        private void OnCreatePPTOperationCompleted(object arg) {
            if ((this.CreatePPTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreatePPTCompleted(this, new CreatePPTCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/PPTHasGenerated", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool PPTHasGenerated(string fullFileName) {
            object[] results = this.Invoke("PPTHasGenerated", new object[] {
                        fullFileName});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void PPTHasGeneratedAsync(string fullFileName) {
            this.PPTHasGeneratedAsync(fullFileName, null);
        }
        
        /// <remarks/>
        public void PPTHasGeneratedAsync(string fullFileName, object userState) {
            if ((this.PPTHasGeneratedOperationCompleted == null)) {
                this.PPTHasGeneratedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPPTHasGeneratedOperationCompleted);
            }
            this.InvokeAsync("PPTHasGenerated", new object[] {
                        fullFileName}, this.PPTHasGeneratedOperationCompleted, userState);
        }
        
        private void OnPPTHasGeneratedOperationCompleted(object arg) {
            if ((this.PPTHasGeneratedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PPTHasGeneratedCompleted(this, new PPTHasGeneratedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/GetImageByBase64", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetImageByBase64(string base64, string folderName, string fileName) {
            object[] results = this.Invoke("GetImageByBase64", new object[] {
                        base64,
                        folderName,
                        fileName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetImageByBase64Async(string base64, string folderName, string fileName) {
            this.GetImageByBase64Async(base64, folderName, fileName, null);
        }
        
        /// <remarks/>
        public void GetImageByBase64Async(string base64, string folderName, string fileName, object userState) {
            if ((this.GetImageByBase64OperationCompleted == null)) {
                this.GetImageByBase64OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetImageByBase64OperationCompleted);
            }
            this.InvokeAsync("GetImageByBase64", new object[] {
                        base64,
                        folderName,
                        fileName}, this.GetImageByBase64OperationCompleted, userState);
        }
        
        private void OnGetImageByBase64OperationCompleted(object arg) {
            if ((this.GetImageByBase64Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetImageByBase64Completed(this, new GetImageByBase64CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/CreatePDF", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreatePDF(string JsonContent) {
            object[] results = this.Invoke("CreatePDF", new object[] {
                        JsonContent});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreatePDFAsync(string JsonContent) {
            this.CreatePDFAsync(JsonContent, null);
        }
        
        /// <remarks/>
        public void CreatePDFAsync(string JsonContent, object userState) {
            if ((this.CreatePDFOperationCompleted == null)) {
                this.CreatePDFOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreatePDFOperationCompleted);
            }
            this.InvokeAsync("CreatePDF", new object[] {
                        JsonContent}, this.CreatePDFOperationCompleted, userState);
        }
        
        private void OnCreatePDFOperationCompleted(object arg) {
            if ((this.CreatePDFCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreatePDFCompleted(this, new CreatePDFCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/CreateLeJiaPDF", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateLeJiaPDF(string JsonContent) {
            object[] results = this.Invoke("CreateLeJiaPDF", new object[] {
                        JsonContent});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreateLeJiaPDFAsync(string JsonContent) {
            this.CreateLeJiaPDFAsync(JsonContent, null);
        }
        
        /// <remarks/>
        public void CreateLeJiaPDFAsync(string JsonContent, object userState) {
            if ((this.CreateLeJiaPDFOperationCompleted == null)) {
                this.CreateLeJiaPDFOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateLeJiaPDFOperationCompleted);
            }
            this.InvokeAsync("CreateLeJiaPDF", new object[] {
                        JsonContent}, this.CreateLeJiaPDFOperationCompleted, userState);
        }
        
        private void OnCreateLeJiaPDFOperationCompleted(object arg) {
            if ((this.CreateLeJiaPDFCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateLeJiaPDFCompleted(this, new CreateLeJiaPDFCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/CreateKingPPT", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateKingPPT(string JsonContent, string TempletName, string Index) {
            object[] results = this.Invoke("CreateKingPPT", new object[] {
                        JsonContent,
                        TempletName,
                        Index});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreateKingPPTAsync(string JsonContent, string TempletName, string Index) {
            this.CreateKingPPTAsync(JsonContent, TempletName, Index, null);
        }
        
        /// <remarks/>
        public void CreateKingPPTAsync(string JsonContent, string TempletName, string Index, object userState) {
            if ((this.CreateKingPPTOperationCompleted == null)) {
                this.CreateKingPPTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateKingPPTOperationCompleted);
            }
            this.InvokeAsync("CreateKingPPT", new object[] {
                        JsonContent,
                        TempletName,
                        Index}, this.CreateKingPPTOperationCompleted, userState);
        }
        
        private void OnCreateKingPPTOperationCompleted(object arg) {
            if ((this.CreateKingPPTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateKingPPTCompleted(this, new CreateKingPPTCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/CreateCustomerPPT", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateCustomerPPT(string JsonContent, string TempletName) {
            object[] results = this.Invoke("CreateCustomerPPT", new object[] {
                        JsonContent,
                        TempletName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreateCustomerPPTAsync(string JsonContent, string TempletName) {
            this.CreateCustomerPPTAsync(JsonContent, TempletName, null);
        }
        
        /// <remarks/>
        public void CreateCustomerPPTAsync(string JsonContent, string TempletName, object userState) {
            if ((this.CreateCustomerPPTOperationCompleted == null)) {
                this.CreateCustomerPPTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateCustomerPPTOperationCompleted);
            }
            this.InvokeAsync("CreateCustomerPPT", new object[] {
                        JsonContent,
                        TempletName}, this.CreateCustomerPPTOperationCompleted, userState);
        }
        
        private void OnCreateCustomerPPTOperationCompleted(object arg) {
            if ((this.CreateCustomerPPTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateCustomerPPTCompleted(this, new CreateCustomerPPTCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/CreateLeJiaPPT", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateLeJiaPPT(string JsonContent) {
            object[] results = this.Invoke("CreateLeJiaPPT", new object[] {
                        JsonContent});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreateLeJiaPPTAsync(string JsonContent) {
            this.CreateLeJiaPPTAsync(JsonContent, null);
        }
        
        /// <remarks/>
        public void CreateLeJiaPPTAsync(string JsonContent, object userState) {
            if ((this.CreateLeJiaPPTOperationCompleted == null)) {
                this.CreateLeJiaPPTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateLeJiaPPTOperationCompleted);
            }
            this.InvokeAsync("CreateLeJiaPPT", new object[] {
                        JsonContent}, this.CreateLeJiaPPTOperationCompleted, userState);
        }
        
        private void OnCreateLeJiaPPTOperationCompleted(object arg) {
            if ((this.CreateLeJiaPPTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateLeJiaPPTCompleted(this, new CreateLeJiaPPTCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/XLSConvertToPDF", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string XLSConvertToPDF(string JsonContent) {
            object[] results = this.Invoke("XLSConvertToPDF", new object[] {
                        JsonContent});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void XLSConvertToPDFAsync(string JsonContent) {
            this.XLSConvertToPDFAsync(JsonContent, null);
        }
        
        /// <remarks/>
        public void XLSConvertToPDFAsync(string JsonContent, object userState) {
            if ((this.XLSConvertToPDFOperationCompleted == null)) {
                this.XLSConvertToPDFOperationCompleted = new System.Threading.SendOrPostCallback(this.OnXLSConvertToPDFOperationCompleted);
            }
            this.InvokeAsync("XLSConvertToPDF", new object[] {
                        JsonContent}, this.XLSConvertToPDFOperationCompleted, userState);
        }
        
        private void OnXLSConvertToPDFOperationCompleted(object arg) {
            if ((this.XLSConvertToPDFCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.XLSConvertToPDFCompleted(this, new XLSConvertToPDFCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CreatePPTCompletedEventHandler(object sender, CreatePPTCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreatePPTCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreatePPTCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void PPTHasGeneratedCompletedEventHandler(object sender, PPTHasGeneratedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PPTHasGeneratedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PPTHasGeneratedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetImageByBase64CompletedEventHandler(object sender, GetImageByBase64CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetImageByBase64CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetImageByBase64CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CreatePDFCompletedEventHandler(object sender, CreatePDFCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreatePDFCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreatePDFCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CreateLeJiaPDFCompletedEventHandler(object sender, CreateLeJiaPDFCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateLeJiaPDFCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateLeJiaPDFCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CreateKingPPTCompletedEventHandler(object sender, CreateKingPPTCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateKingPPTCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateKingPPTCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CreateCustomerPPTCompletedEventHandler(object sender, CreateCustomerPPTCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateCustomerPPTCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateCustomerPPTCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void CreateLeJiaPPTCompletedEventHandler(object sender, CreateLeJiaPPTCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateLeJiaPPTCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateLeJiaPPTCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void XLSConvertToPDFCompletedEventHandler(object sender, XLSConvertToPDFCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class XLSConvertToPDFCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal XLSConvertToPDFCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591