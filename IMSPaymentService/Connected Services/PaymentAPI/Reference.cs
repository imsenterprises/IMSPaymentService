﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMSPaymentService.PaymentAPI {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://countyprocessing.com/paymentAPI/service/", ConfigurationName="PaymentAPI.PaymentServicePortType")]
    public interface PaymentServicePortType {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://soapinterop.org/) of message testRequest does not match the default value (https://countyprocessing.com/paymentAPI/service/)
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/test", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        IMSPaymentService.PaymentAPI.testResponse test(IMSPaymentService.PaymentAPI.testRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/test", ReplyAction="*")]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.testResponse> testAsync(IMSPaymentService.PaymentAPI.testRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://soapinterop.org/) of message newTransRequest does not match the default value (https://countyprocessing.com/paymentAPI/service/)
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/newTrans", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        IMSPaymentService.PaymentAPI.newTransResponse newTrans(IMSPaymentService.PaymentAPI.newTransRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/newTrans", ReplyAction="*")]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.newTransResponse> newTransAsync(IMSPaymentService.PaymentAPI.newTransRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/updateTrans", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        IMSPaymentService.PaymentAPI.updateTransResponse updateTrans(IMSPaymentService.PaymentAPI.updateTransRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/updateTrans", ReplyAction="*")]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.updateTransResponse> updateTransAsync(IMSPaymentService.PaymentAPI.updateTransRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://soapinterop.org/) of message getTransRequest does not match the default value (https://countyprocessing.com/paymentAPI/service/)
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/getTrans", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        IMSPaymentService.PaymentAPI.getTransResponse getTrans(IMSPaymentService.PaymentAPI.getTransRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/getTrans", ReplyAction="*")]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.getTransResponse> getTransAsync(IMSPaymentService.PaymentAPI.getTransRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://soapinterop.org/) of message getJSRequest does not match the default value (https://countyprocessing.com/paymentAPI/service/)
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/getJS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        IMSPaymentService.PaymentAPI.getJSResponse getJS(IMSPaymentService.PaymentAPI.getJSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/getJS", ReplyAction="*")]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.getJSResponse> getJSAsync(IMSPaymentService.PaymentAPI.getJSRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://soapinterop.org/) of message getPaymentFormRequest does not match the default value (https://countyprocessing.com/paymentAPI/service/)
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/getPaymentForm", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        IMSPaymentService.PaymentAPI.getPaymentFormResponse getPaymentForm(IMSPaymentService.PaymentAPI.getPaymentFormRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/getPaymentForm", ReplyAction="*")]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.getPaymentFormResponse> getPaymentFormAsync(IMSPaymentService.PaymentAPI.getPaymentFormRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://soapinterop.org/) of message setRenewalOptionRequest does not match the default value (https://countyprocessing.com/paymentAPI/service/)
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/setRenewalOption", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        IMSPaymentService.PaymentAPI.setRenewalOptionResponse setRenewalOption(IMSPaymentService.PaymentAPI.setRenewalOptionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://countyprocessing.com/paymentAPI/service/createwsdl.php/setRenewalOption", ReplyAction="*")]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.setRenewalOptionResponse> setRenewalOptionAsync(IMSPaymentService.PaymentAPI.setRenewalOptionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="test", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class testRequest {
        
        public testRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="testResponse", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class testResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string Transaction;
        
        public testResponse() {
        }
        
        public testResponse(string Transaction) {
            this.Transaction = Transaction;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="https://countyprocessing.com/paymentAPI/service/")]
    public partial class Transaction : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string transIDField;
        
        private string statusField;
        
        private int statusCodeField;
        
        private float amountField;
        
        private float cCFeeField;
        
        private float checkFeeField;
        
        private string authCodeField;
        
        private string feeAuthCodeField;
        
        private PayType payTypeField;
        
        private int refNumberField;
        
        /// <remarks/>
        public string TransID {
            get {
                return this.transIDField;
            }
            set {
                this.transIDField = value;
                this.RaisePropertyChanged("TransID");
            }
        }
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        public int StatusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
                this.RaisePropertyChanged("StatusCode");
            }
        }
        
        /// <remarks/>
        public float Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("Amount");
            }
        }
        
        /// <remarks/>
        public float CCFee {
            get {
                return this.cCFeeField;
            }
            set {
                this.cCFeeField = value;
                this.RaisePropertyChanged("CCFee");
            }
        }
        
        /// <remarks/>
        public float CheckFee {
            get {
                return this.checkFeeField;
            }
            set {
                this.checkFeeField = value;
                this.RaisePropertyChanged("CheckFee");
            }
        }
        
        /// <remarks/>
        public string AuthCode {
            get {
                return this.authCodeField;
            }
            set {
                this.authCodeField = value;
                this.RaisePropertyChanged("AuthCode");
            }
        }
        
        /// <remarks/>
        public string FeeAuthCode {
            get {
                return this.feeAuthCodeField;
            }
            set {
                this.feeAuthCodeField = value;
                this.RaisePropertyChanged("FeeAuthCode");
            }
        }
        
        /// <remarks/>
        public PayType PayType {
            get {
                return this.payTypeField;
            }
            set {
                this.payTypeField = value;
                this.RaisePropertyChanged("PayType");
            }
        }
        
        /// <remarks/>
        public int RefNumber {
            get {
                return this.refNumberField;
            }
            set {
                this.refNumberField = value;
                this.RaisePropertyChanged("RefNumber");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="https://countyprocessing.com/paymentAPI/service/")]
    public enum PayType {
        
        /// <remarks/>
        na,
        
        /// <remarks/>
        cc,
        
        /// <remarks/>
        check,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="newTrans", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class newTransRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string TransID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public float Amount;
        
        public newTransRequest() {
        }
        
        public newTransRequest(string TransID, float Amount) {
            this.TransID = TransID;
            this.Amount = Amount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="newTransResponse", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class newTransResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public IMSPaymentService.PaymentAPI.Transaction Transaction;
        
        public newTransResponse() {
        }
        
        public newTransResponse(IMSPaymentService.PaymentAPI.Transaction Transaction) {
            this.Transaction = Transaction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateTrans", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class updateTransRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public IMSPaymentService.PaymentAPI.Transaction Transaction;
        
        public updateTransRequest() {
        }
        
        public updateTransRequest(IMSPaymentService.PaymentAPI.Transaction Transaction) {
            this.Transaction = Transaction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateTransResponse", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class updateTransResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public IMSPaymentService.PaymentAPI.Transaction Transaction;
        
        public updateTransResponse() {
        }
        
        public updateTransResponse(IMSPaymentService.PaymentAPI.Transaction Transaction) {
            this.Transaction = Transaction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTrans", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class getTransRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string TransID;
        
        public getTransRequest() {
        }
        
        public getTransRequest(string TransID) {
            this.TransID = TransID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTransResponse", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class getTransResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public IMSPaymentService.PaymentAPI.Transaction Transaction;
        
        public getTransResponse() {
        }
        
        public getTransResponse(IMSPaymentService.PaymentAPI.Transaction Transaction) {
            this.Transaction = Transaction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getJS", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class getJSRequest {
        
        public getJSRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getJSResponse", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class getJSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string JS;
        
        public getJSResponse() {
        }
        
        public getJSResponse(string JS) {
            this.JS = JS;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPaymentForm", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class getPaymentFormRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string TransID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public float Amount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string Stylesheet;
        
        public getPaymentFormRequest() {
        }
        
        public getPaymentFormRequest(string TransID, float Amount, string Stylesheet) {
            this.TransID = TransID;
            this.Amount = Amount;
            this.Stylesheet = Stylesheet;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPaymentFormResponse", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class getPaymentFormResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string Form;
        
        public getPaymentFormResponse() {
        }
        
        public getPaymentFormResponse(string Form) {
            this.Form = Form;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setRenewalOption", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class setRenewalOptionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string TransID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string Key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string Value;
        
        public setRenewalOptionRequest() {
        }
        
        public setRenewalOptionRequest(string TransID, string Key, string Value) {
            this.TransID = TransID;
            this.Key = Key;
            this.Value = Value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setRenewalOptionResponse", WrapperNamespace="http://soapinterop.org/", IsWrapped=true)]
    public partial class setRenewalOptionResponse {
        
        public setRenewalOptionResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PaymentServicePortTypeChannel : IMSPaymentService.PaymentAPI.PaymentServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaymentServicePortTypeClient : System.ServiceModel.ClientBase<IMSPaymentService.PaymentAPI.PaymentServicePortType>, IMSPaymentService.PaymentAPI.PaymentServicePortType {
        
        public PaymentServicePortTypeClient() {
        }
        
        public PaymentServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaymentServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        IMSPaymentService.PaymentAPI.testResponse IMSPaymentService.PaymentAPI.PaymentServicePortType.test(IMSPaymentService.PaymentAPI.testRequest request) {
            return base.Channel.test(request);
        }
        
        public string test() {
            IMSPaymentService.PaymentAPI.testRequest inValue = new IMSPaymentService.PaymentAPI.testRequest();
            IMSPaymentService.PaymentAPI.testResponse retVal = ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).test(inValue);
            return retVal.Transaction;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.testResponse> IMSPaymentService.PaymentAPI.PaymentServicePortType.testAsync(IMSPaymentService.PaymentAPI.testRequest request) {
            return base.Channel.testAsync(request);
        }
        
        public System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.testResponse> testAsync() {
            IMSPaymentService.PaymentAPI.testRequest inValue = new IMSPaymentService.PaymentAPI.testRequest();
            return ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).testAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        IMSPaymentService.PaymentAPI.newTransResponse IMSPaymentService.PaymentAPI.PaymentServicePortType.newTrans(IMSPaymentService.PaymentAPI.newTransRequest request) {
            return base.Channel.newTrans(request);
        }
        
        public IMSPaymentService.PaymentAPI.Transaction newTrans(string TransID, float Amount) {
            IMSPaymentService.PaymentAPI.newTransRequest inValue = new IMSPaymentService.PaymentAPI.newTransRequest();
            inValue.TransID = TransID;
            inValue.Amount = Amount;
            IMSPaymentService.PaymentAPI.newTransResponse retVal = ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).newTrans(inValue);
            return retVal.Transaction;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.newTransResponse> IMSPaymentService.PaymentAPI.PaymentServicePortType.newTransAsync(IMSPaymentService.PaymentAPI.newTransRequest request) {
            return base.Channel.newTransAsync(request);
        }
        
        public System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.newTransResponse> newTransAsync(string TransID, float Amount) {
            IMSPaymentService.PaymentAPI.newTransRequest inValue = new IMSPaymentService.PaymentAPI.newTransRequest();
            inValue.TransID = TransID;
            inValue.Amount = Amount;
            return ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).newTransAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        IMSPaymentService.PaymentAPI.updateTransResponse IMSPaymentService.PaymentAPI.PaymentServicePortType.updateTrans(IMSPaymentService.PaymentAPI.updateTransRequest request) {
            return base.Channel.updateTrans(request);
        }
        
        public void updateTrans(ref IMSPaymentService.PaymentAPI.Transaction Transaction) {
            IMSPaymentService.PaymentAPI.updateTransRequest inValue = new IMSPaymentService.PaymentAPI.updateTransRequest();
            inValue.Transaction = Transaction;
            IMSPaymentService.PaymentAPI.updateTransResponse retVal = ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).updateTrans(inValue);
            Transaction = retVal.Transaction;
        }
        
        public System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.updateTransResponse> updateTransAsync(IMSPaymentService.PaymentAPI.updateTransRequest request) {
            return base.Channel.updateTransAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        IMSPaymentService.PaymentAPI.getTransResponse IMSPaymentService.PaymentAPI.PaymentServicePortType.getTrans(IMSPaymentService.PaymentAPI.getTransRequest request) {
            return base.Channel.getTrans(request);
        }
        
        public IMSPaymentService.PaymentAPI.Transaction getTrans(string TransID) {
            IMSPaymentService.PaymentAPI.getTransRequest inValue = new IMSPaymentService.PaymentAPI.getTransRequest();
            inValue.TransID = TransID;
            IMSPaymentService.PaymentAPI.getTransResponse retVal = ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).getTrans(inValue);
            return retVal.Transaction;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.getTransResponse> IMSPaymentService.PaymentAPI.PaymentServicePortType.getTransAsync(IMSPaymentService.PaymentAPI.getTransRequest request) {
            return base.Channel.getTransAsync(request);
        }
        
        public System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.getTransResponse> getTransAsync(string TransID) {
            IMSPaymentService.PaymentAPI.getTransRequest inValue = new IMSPaymentService.PaymentAPI.getTransRequest();
            inValue.TransID = TransID;
            return ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).getTransAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        IMSPaymentService.PaymentAPI.getJSResponse IMSPaymentService.PaymentAPI.PaymentServicePortType.getJS(IMSPaymentService.PaymentAPI.getJSRequest request) {
            return base.Channel.getJS(request);
        }
        
        public string getJS() {
            IMSPaymentService.PaymentAPI.getJSRequest inValue = new IMSPaymentService.PaymentAPI.getJSRequest();
            IMSPaymentService.PaymentAPI.getJSResponse retVal = ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).getJS(inValue);
            return retVal.JS;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.getJSResponse> IMSPaymentService.PaymentAPI.PaymentServicePortType.getJSAsync(IMSPaymentService.PaymentAPI.getJSRequest request) {
            return base.Channel.getJSAsync(request);
        }
        
        public System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.getJSResponse> getJSAsync() {
            IMSPaymentService.PaymentAPI.getJSRequest inValue = new IMSPaymentService.PaymentAPI.getJSRequest();
            return ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).getJSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        IMSPaymentService.PaymentAPI.getPaymentFormResponse IMSPaymentService.PaymentAPI.PaymentServicePortType.getPaymentForm(IMSPaymentService.PaymentAPI.getPaymentFormRequest request) {
            return base.Channel.getPaymentForm(request);
        }
        
        public string getPaymentForm(string TransID, float Amount, string Stylesheet) {
            IMSPaymentService.PaymentAPI.getPaymentFormRequest inValue = new IMSPaymentService.PaymentAPI.getPaymentFormRequest();
            inValue.TransID = TransID;
            inValue.Amount = Amount;
            inValue.Stylesheet = Stylesheet;
            IMSPaymentService.PaymentAPI.getPaymentFormResponse retVal = ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).getPaymentForm(inValue);
            return retVal.Form;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.getPaymentFormResponse> IMSPaymentService.PaymentAPI.PaymentServicePortType.getPaymentFormAsync(IMSPaymentService.PaymentAPI.getPaymentFormRequest request) {
            return base.Channel.getPaymentFormAsync(request);
        }
        
        public System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.getPaymentFormResponse> getPaymentFormAsync(string TransID, float Amount, string Stylesheet) {
            IMSPaymentService.PaymentAPI.getPaymentFormRequest inValue = new IMSPaymentService.PaymentAPI.getPaymentFormRequest();
            inValue.TransID = TransID;
            inValue.Amount = Amount;
            inValue.Stylesheet = Stylesheet;
            return ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).getPaymentFormAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        IMSPaymentService.PaymentAPI.setRenewalOptionResponse IMSPaymentService.PaymentAPI.PaymentServicePortType.setRenewalOption(IMSPaymentService.PaymentAPI.setRenewalOptionRequest request) {
            return base.Channel.setRenewalOption(request);
        }
        
        public void setRenewalOption(string TransID, string Key, string Value) {
            IMSPaymentService.PaymentAPI.setRenewalOptionRequest inValue = new IMSPaymentService.PaymentAPI.setRenewalOptionRequest();
            inValue.TransID = TransID;
            inValue.Key = Key;
            inValue.Value = Value;
            IMSPaymentService.PaymentAPI.setRenewalOptionResponse retVal = ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).setRenewalOption(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.setRenewalOptionResponse> IMSPaymentService.PaymentAPI.PaymentServicePortType.setRenewalOptionAsync(IMSPaymentService.PaymentAPI.setRenewalOptionRequest request) {
            return base.Channel.setRenewalOptionAsync(request);
        }
        
        public System.Threading.Tasks.Task<IMSPaymentService.PaymentAPI.setRenewalOptionResponse> setRenewalOptionAsync(string TransID, string Key, string Value) {
            IMSPaymentService.PaymentAPI.setRenewalOptionRequest inValue = new IMSPaymentService.PaymentAPI.setRenewalOptionRequest();
            inValue.TransID = TransID;
            inValue.Key = Key;
            inValue.Value = Value;
            return ((IMSPaymentService.PaymentAPI.PaymentServicePortType)(this)).setRenewalOptionAsync(inValue);
        }
    }
}
