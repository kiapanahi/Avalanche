namespace Avalanche.Host.Services
{


    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContract(Namespace = "http://webservice.smsrelay.armaghan.net/", ConfigurationName = "ArmaghanService.MessageRelay")]
    public interface MessageRelay
    {

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/getUserInfoRequest", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/getUserInfoResponse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<getUserInfoResponse> getUserInfoAsync(getUserInfo request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageOneToManyRequest", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageOneToManyResponse" +
            "")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<sendMessageOneToManyResponse> sendMessageOneToManyAsync(sendMessageOneToMany request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/pullReceivedMessagesRequest", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/pullReceivedMessagesResponse" +
            "")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<pullReceivedMessagesResponse> pullReceivedMessagesAsync(pullReceivedMessages request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/getReceivedMessageCountReque" +
            "st", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/getReceivedMessageCountRespo" +
            "nse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<getReceivedMessageCountResponse> getReceivedMessageCountAsync(getReceivedMessageCount request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageBinaryUDHOneToMan" +
            "yRequest", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageBinaryUDHOneToMan" +
            "yResponse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<sendMessageBinaryUDHOneToManyResponse> sendMessageBinaryUDHOneToManyAsync(sendMessageBinaryUDHOneToMany request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageBinaryUDHManyToMa" +
            "nyRequest", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageBinaryUDHManyToMa" +
            "nyResponse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<sendMessageBinaryUDHManyToManyResponse> sendMessageBinaryUDHManyToManyAsync(sendMessageBinaryUDHManyToMany request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageUDHOneToManyReque" +
            "st", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageUDHOneToManyRespo" +
            "nse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<sendMessageUDHOneToManyResponse> sendMessageUDHOneToManyAsync(sendMessageUDHOneToMany request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageBinaryPortManyToM" +
            "anyRequest", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageBinaryPortManyToM" +
            "anyResponse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<sendMessageBinaryPortManyToManyResponse> sendMessageBinaryPortManyToManyAsync(sendMessageBinaryPortManyToMany request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageManyToManyRequest" +
            "", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageManyToManyRespons" +
            "e")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<sendMessageManyToManyResponse> sendMessageManyToManyAsync(sendMessageManyToMany request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessagePortManyToManyReq" +
            "uest", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessagePortManyToManyRes" +
            "ponse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<sendMessagePortManyToManyResponse> sendMessagePortManyToManyAsync(sendMessagePortManyToMany request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessagePortOneToManyRequ" +
            "est", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessagePortOneToManyResp" +
            "onse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<sendMessagePortOneToManyResponse> sendMessagePortOneToManyAsync(sendMessagePortOneToMany request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageUDHManyToManyRequ" +
            "est", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageUDHManyToManyResp" +
            "onse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<sendMessageUDHManyToManyResponse> sendMessageUDHManyToManyAsync(sendMessageUDHManyToMany request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/getMessageStateRequest", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/getMessageStateResponse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<getMessageStateResponse> getMessageStateAsync(getMessageState request);

        [System.ServiceModel.OperationContract(Action = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageBinaryPortOneToMa" +
            "nyRequest", ReplyAction = "http://webservice.smsrelay.armaghan.net/MessageRelay/sendMessageBinaryPortOneToMa" +
            "nyResponse")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<sendMessageBinaryPortOneToManyResponse> sendMessageBinaryPortOneToManyAsync(sendMessageBinaryPortOneToMany request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://webservice.smsrelay.armaghan.net/")]
    public partial class userResult
    {

        private user userField;

        private error errorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public user user
        {
            get
            {
                return userField;
            }
            set
            {
                userField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public error error
        {
            get
            {
                return errorField;
            }
            set
            {
                errorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://webservice.smsrelay.armaghan.net/")]
    public partial class user
    {

        private string usernameField;

        private double creditField;

        private string deliveryUrlField;

        private string receiveUrlField;

        private System.DateTime expirationDateField;

        private string[] iPsField;

        private string[] numbersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string username
        {
            get
            {
                return usernameField;
            }
            set
            {
                usernameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public double credit
        {
            get
            {
                return creditField;
            }
            set
            {
                creditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 2)]
        public string deliveryUrl
        {
            get
            {
                return deliveryUrlField;
            }
            set
            {
                deliveryUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 3)]
        public string receiveUrl
        {
            get
            {
                return receiveUrlField;
            }
            set
            {
                receiveUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public System.DateTime expirationDate
        {
            get
            {
                return expirationDateField;
            }
            set
            {
                expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("IPs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string[] IPs
        {
            get
            {
                return iPsField;
            }
            set
            {
                iPsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("numbers", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string[] numbers
        {
            get
            {
                return numbersField;
            }
            set
            {
                numbersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://webservice.smsrelay.armaghan.net/")]
    public partial class messageState
    {

        private long idField;

        private int stateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public long id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public int state
        {
            get
            {
                return stateField;
            }
            set
            {
                stateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://webservice.smsrelay.armaghan.net/")]
    public partial class messageStateResult
    {

        private messageState[] statesField;

        private error errorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("states", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public messageState[] states
        {
            get
            {
                return statesField;
            }
            set
            {
                statesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public error error
        {
            get
            {
                return errorField;
            }
            set
            {
                errorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://webservice.smsrelay.armaghan.net/")]
    public partial class error
    {

        private int errorCodeField;

        private System.DateTime timestampField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int errorCode
        {
            get
            {
                return errorCodeField;
            }
            set
            {
                errorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public System.DateTime timestamp
        {
            get
            {
                return timestampField;
            }
            set
            {
                timestampField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://webservice.smsrelay.armaghan.net/")]
    public partial class countResult
    {

        private int countField;

        private error errorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int count
        {
            get
            {
                return countField;
            }
            set
            {
                countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public error error
        {
            get
            {
                return errorField;
            }
            set
            {
                errorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://webservice.smsrelay.armaghan.net/")]
    public partial class message
    {

        private string originatorField;

        private string destinationField;

        private string contentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string originator
        {
            get
            {
                return originatorField;
            }
            set
            {
                originatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string destination
        {
            get
            {
                return destinationField;
            }
            set
            {
                destinationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string content
        {
            get
            {
                return contentField;
            }
            set
            {
                contentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://webservice.smsrelay.armaghan.net/")]
    public partial class messageResult
    {

        private message[] messagesField;

        private error errorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("messages", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public message[] messages
        {
            get
            {
                return messagesField;
            }
            set
            {
                messagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public error error
        {
            get
            {
                return errorField;
            }
            set
            {
                errorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://webservice.smsrelay.armaghan.net/")]
    public partial class referenceResult
    {

        private long?[] referencesField;

        private error errorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("references", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true, Order = 0)]
        public long?[] references
        {
            get
            {
                return referencesField;
            }
            set
            {
                referencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public error error
        {
            get
            {
                return errorField;
            }
            set
            {
                errorField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "getUserInfo", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class getUserInfo
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        public getUserInfo()
        {
        }

        public getUserInfo(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "getUserInfoResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class getUserInfoResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public userResult @return;

        public getUserInfoResponse()
        {
        }

        public getUserInfoResponse(userResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageOneToMany", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageOneToMany
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string originator;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 3)]
        [System.Xml.Serialization.XmlElement("destination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destination;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 4)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string content;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 5)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long userSuppliedId;

        public sendMessageOneToMany()
        {
        }

        public sendMessageOneToMany(string username, string password, string originator, string[] destination, string content, long userSuppliedId)
        {
            this.username = username;
            this.password = password;
            this.originator = originator;
            this.destination = destination;
            this.content = content;
            this.userSuppliedId = userSuppliedId;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageOneToManyResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageOneToManyResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public referenceResult @return;

        public sendMessageOneToManyResponse()
        {
        }

        public sendMessageOneToManyResponse(referenceResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "pullReceivedMessages", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class pullReceivedMessages
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        public pullReceivedMessages()
        {
        }

        public pullReceivedMessages(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "pullReceivedMessagesResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class pullReceivedMessagesResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public messageResult @return;

        public pullReceivedMessagesResponse()
        {
        }

        public pullReceivedMessagesResponse(messageResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "getReceivedMessageCount", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class getReceivedMessageCount
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        public getReceivedMessageCount()
        {
        }

        public getReceivedMessageCount(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "getReceivedMessageCountResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class getReceivedMessageCountResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public countResult @return;

        public getReceivedMessageCountResponse()
        {
        }

        public getReceivedMessageCountResponse(countResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageBinaryUDHOneToMany", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageBinaryUDHOneToMany
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string originator;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 3)]
        [System.Xml.Serialization.XmlElement("destination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destination;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 4)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string content;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 5)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string udh;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 6)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mClass;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 7)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long userSuppliedId;

        public sendMessageBinaryUDHOneToMany()
        {
        }

        public sendMessageBinaryUDHOneToMany(string username, string password, string originator, string[] destination, string content, string udh, string mClass, long userSuppliedId)
        {
            this.username = username;
            this.password = password;
            this.originator = originator;
            this.destination = destination;
            this.content = content;
            this.udh = udh;
            this.mClass = mClass;
            this.userSuppliedId = userSuppliedId;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageBinaryUDHOneToManyResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageBinaryUDHOneToManyResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public referenceResult @return;

        public sendMessageBinaryUDHOneToManyResponse()
        {
        }

        public sendMessageBinaryUDHOneToManyResponse(referenceResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageBinaryUDHManyToMany", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageBinaryUDHManyToMany
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement("originator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] originator;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 3)]
        [System.Xml.Serialization.XmlElement("destination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destination;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 4)]
        [System.Xml.Serialization.XmlElement("content", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] content;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 5)]
        [System.Xml.Serialization.XmlElement("udh", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] udh;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 6)]
        [System.Xml.Serialization.XmlElement("mClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] mClass;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 7)]
        [System.Xml.Serialization.XmlElement("userSuppliedId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long[] userSuppliedId;

        public sendMessageBinaryUDHManyToMany()
        {
        }

        public sendMessageBinaryUDHManyToMany(string username, string password, string[] originator, string[] destination, string[] content, string[] udh, string[] mClass, long[] userSuppliedId)
        {
            this.username = username;
            this.password = password;
            this.originator = originator;
            this.destination = destination;
            this.content = content;
            this.udh = udh;
            this.mClass = mClass;
            this.userSuppliedId = userSuppliedId;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageBinaryUDHManyToManyResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageBinaryUDHManyToManyResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public referenceResult @return;

        public sendMessageBinaryUDHManyToManyResponse()
        {
        }

        public sendMessageBinaryUDHManyToManyResponse(referenceResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageUDHOneToMany", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageUDHOneToMany
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string originator;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 3)]
        [System.Xml.Serialization.XmlElement("destination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destination;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 4)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string content;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 5)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string udh;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 6)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mClass;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 7)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long userSuppliedId;

        public sendMessageUDHOneToMany()
        {
        }

        public sendMessageUDHOneToMany(string username, string password, string originator, string[] destination, string content, string udh, string mClass, long userSuppliedId)
        {
            this.username = username;
            this.password = password;
            this.originator = originator;
            this.destination = destination;
            this.content = content;
            this.udh = udh;
            this.mClass = mClass;
            this.userSuppliedId = userSuppliedId;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageUDHOneToManyResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageUDHOneToManyResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public referenceResult @return;

        public sendMessageUDHOneToManyResponse()
        {
        }

        public sendMessageUDHOneToManyResponse(referenceResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageBinaryPortManyToMany", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageBinaryPortManyToMany
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement("originator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] originator;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 3)]
        [System.Xml.Serialization.XmlElement("destination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destination;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 4)]
        [System.Xml.Serialization.XmlElement("content", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] content;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 5)]
        [System.Xml.Serialization.XmlElement("destinationPort", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destinationPort;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 6)]
        [System.Xml.Serialization.XmlElement("sourcePort", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] sourcePort;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 7)]
        [System.Xml.Serialization.XmlElement("mClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] mClass;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 8)]
        [System.Xml.Serialization.XmlElement("userSuppliedId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long[] userSuppliedId;

        public sendMessageBinaryPortManyToMany()
        {
        }

        public sendMessageBinaryPortManyToMany(string username, string password, string[] originator, string[] destination, string[] content, string[] destinationPort, string[] sourcePort, string[] mClass, long[] userSuppliedId)
        {
            this.username = username;
            this.password = password;
            this.originator = originator;
            this.destination = destination;
            this.content = content;
            this.destinationPort = destinationPort;
            this.sourcePort = sourcePort;
            this.mClass = mClass;
            this.userSuppliedId = userSuppliedId;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageBinaryPortManyToManyResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageBinaryPortManyToManyResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public referenceResult @return;

        public sendMessageBinaryPortManyToManyResponse()
        {
        }

        public sendMessageBinaryPortManyToManyResponse(referenceResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageManyToMany", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageManyToMany
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement("originator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] originator;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 3)]
        [System.Xml.Serialization.XmlElement("destination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destination;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 4)]
        [System.Xml.Serialization.XmlElement("content", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] content;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 5)]
        [System.Xml.Serialization.XmlElement("userSuppliedId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long[] userSuppliedId;

        public sendMessageManyToMany()
        {
        }

        public sendMessageManyToMany(string username, string password, string[] originator, string[] destination, string[] content, long[] userSuppliedId)
        {
            this.username = username;
            this.password = password;
            this.originator = originator;
            this.destination = destination;
            this.content = content;
            this.userSuppliedId = userSuppliedId;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageManyToManyResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageManyToManyResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public referenceResult @return;

        public sendMessageManyToManyResponse()
        {
        }

        public sendMessageManyToManyResponse(referenceResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessagePortManyToMany", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessagePortManyToMany
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement("originator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] originator;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 3)]
        [System.Xml.Serialization.XmlElement("destination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destination;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 4)]
        [System.Xml.Serialization.XmlElement("content", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] content;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 5)]
        [System.Xml.Serialization.XmlElement("destinationPort", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destinationPort;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 6)]
        [System.Xml.Serialization.XmlElement("sourcePort", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] sourcePort;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 7)]
        [System.Xml.Serialization.XmlElement("mClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] mClass;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 8)]
        [System.Xml.Serialization.XmlElement("userSuppliedId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long[] userSuppliedId;

        public sendMessagePortManyToMany()
        {
        }

        public sendMessagePortManyToMany(string username, string password, string[] originator, string[] destination, string[] content, string[] destinationPort, string[] sourcePort, string[] mClass, long[] userSuppliedId)
        {
            this.username = username;
            this.password = password;
            this.originator = originator;
            this.destination = destination;
            this.content = content;
            this.destinationPort = destinationPort;
            this.sourcePort = sourcePort;
            this.mClass = mClass;
            this.userSuppliedId = userSuppliedId;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessagePortManyToManyResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessagePortManyToManyResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public referenceResult @return;

        public sendMessagePortManyToManyResponse()
        {
        }

        public sendMessagePortManyToManyResponse(referenceResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessagePortOneToMany", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessagePortOneToMany
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string originator;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 3)]
        [System.Xml.Serialization.XmlElement("destination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destination;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 4)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string content;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 5)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string destinationPort;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 6)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sourcePort;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 7)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mClass;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 8)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long userSuppliedId;

        public sendMessagePortOneToMany()
        {
        }

        public sendMessagePortOneToMany(string username, string password, string originator, string[] destination, string content, string destinationPort, string sourcePort, string mClass, long userSuppliedId)
        {
            this.username = username;
            this.password = password;
            this.originator = originator;
            this.destination = destination;
            this.content = content;
            this.destinationPort = destinationPort;
            this.sourcePort = sourcePort;
            this.mClass = mClass;
            this.userSuppliedId = userSuppliedId;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessagePortOneToManyResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessagePortOneToManyResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public referenceResult @return;

        public sendMessagePortOneToManyResponse()
        {
        }

        public sendMessagePortOneToManyResponse(referenceResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageUDHManyToMany", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageUDHManyToMany
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement("originator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] originator;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 3)]
        [System.Xml.Serialization.XmlElement("destination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destination;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 4)]
        [System.Xml.Serialization.XmlElement("content", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] content;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 5)]
        [System.Xml.Serialization.XmlElement("udh", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] udh;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 6)]
        [System.Xml.Serialization.XmlElement("mClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] mClass;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 7)]
        [System.Xml.Serialization.XmlElement("userSuppliedId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long[] userSuppliedId;

        public sendMessageUDHManyToMany()
        {
        }

        public sendMessageUDHManyToMany(string username, string password, string[] originator, string[] destination, string[] content, string[] udh, string[] mClass, long[] userSuppliedId)
        {
            this.username = username;
            this.password = password;
            this.originator = originator;
            this.destination = destination;
            this.content = content;
            this.udh = udh;
            this.mClass = mClass;
            this.userSuppliedId = userSuppliedId;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageUDHManyToManyResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageUDHManyToManyResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public referenceResult @return;

        public sendMessageUDHManyToManyResponse()
        {
        }

        public sendMessageUDHManyToManyResponse(referenceResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "getMessageState", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class getMessageState
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement("id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long[] id;

        public getMessageState()
        {
        }

        public getMessageState(string username, string password, long[] id)
        {
            this.username = username;
            this.password = password;
            this.id = id;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "getMessageStateResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class getMessageStateResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public messageStateResult @return;

        public getMessageStateResponse()
        {
        }

        public getMessageStateResponse(messageStateResult @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageBinaryPortOneToMany", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageBinaryPortOneToMany
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 1)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 2)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string originator;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 3)]
        [System.Xml.Serialization.XmlElement("destination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] destination;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 4)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string content;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 5)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string destinationPort;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 6)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sourcePort;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 7)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mClass;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 8)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long userSuppliedId;

        public sendMessageBinaryPortOneToMany()
        {
        }

        public sendMessageBinaryPortOneToMany(string username, string password, string originator, string[] destination, string content, string destinationPort, string sourcePort, string mClass, long userSuppliedId)
        {
            this.username = username;
            this.password = password;
            this.originator = originator;
            this.destination = destination;
            this.content = content;
            this.destinationPort = destinationPort;
            this.sourcePort = sourcePort;
            this.mClass = mClass;
            this.userSuppliedId = userSuppliedId;
        }
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContract(WrapperName = "sendMessageBinaryPortOneToManyResponse", WrapperNamespace = "http://webservice.smsrelay.armaghan.net/", IsWrapped = true)]
    public partial class sendMessageBinaryPortOneToManyResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://webservice.smsrelay.armaghan.net/", Order = 0)]
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public referenceResult @return;

        public sendMessageBinaryPortOneToManyResponse()
        {
        }

        public sendMessageBinaryPortOneToManyResponse(referenceResult @return)
        {
            this.@return = @return;
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface MessageRelayChannel : MessageRelay, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MessageRelayClient : System.ServiceModel.ClientBase<MessageRelay>, MessageRelay
    {

        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public MessageRelayClient() :
                base(GetDefaultBinding(), GetDefaultEndpointAddress())
        {
            Endpoint.Name = EndpointConfiguration.MessageRelayPort.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public MessageRelayClient(EndpointConfiguration endpointConfiguration) :
                base(GetBindingForEndpoint(endpointConfiguration), GetEndpointAddress(endpointConfiguration))
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public MessageRelayClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public MessageRelayClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(Endpoint, ClientCredentials);
        }

        public MessageRelayClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public System.Threading.Tasks.Task<getUserInfoResponse> getUserInfoAsync(getUserInfo request)
        {
            return Channel.getUserInfoAsync(request);
        }

        public System.Threading.Tasks.Task<sendMessageOneToManyResponse> sendMessageOneToManyAsync(sendMessageOneToMany request)
        {
            return Channel.sendMessageOneToManyAsync(request);
        }

        public System.Threading.Tasks.Task<pullReceivedMessagesResponse> pullReceivedMessagesAsync(pullReceivedMessages request)
        {
            return Channel.pullReceivedMessagesAsync(request);
        }

        public System.Threading.Tasks.Task<getReceivedMessageCountResponse> getReceivedMessageCountAsync(getReceivedMessageCount request)
        {
            return Channel.getReceivedMessageCountAsync(request);
        }

        public System.Threading.Tasks.Task<sendMessageBinaryUDHOneToManyResponse> sendMessageBinaryUDHOneToManyAsync(sendMessageBinaryUDHOneToMany request)
        {
            return Channel.sendMessageBinaryUDHOneToManyAsync(request);
        }

        public System.Threading.Tasks.Task<sendMessageBinaryUDHManyToManyResponse> sendMessageBinaryUDHManyToManyAsync(sendMessageBinaryUDHManyToMany request)
        {
            return Channel.sendMessageBinaryUDHManyToManyAsync(request);
        }

        public System.Threading.Tasks.Task<sendMessageUDHOneToManyResponse> sendMessageUDHOneToManyAsync(sendMessageUDHOneToMany request)
        {
            return Channel.sendMessageUDHOneToManyAsync(request);
        }

        public System.Threading.Tasks.Task<sendMessageBinaryPortManyToManyResponse> sendMessageBinaryPortManyToManyAsync(sendMessageBinaryPortManyToMany request)
        {
            return Channel.sendMessageBinaryPortManyToManyAsync(request);
        }

        public System.Threading.Tasks.Task<sendMessageManyToManyResponse> sendMessageManyToManyAsync(sendMessageManyToMany request)
        {
            return Channel.sendMessageManyToManyAsync(request);
        }

        public System.Threading.Tasks.Task<sendMessagePortManyToManyResponse> sendMessagePortManyToManyAsync(sendMessagePortManyToMany request)
        {
            return Channel.sendMessagePortManyToManyAsync(request);
        }

        public System.Threading.Tasks.Task<sendMessagePortOneToManyResponse> sendMessagePortOneToManyAsync(sendMessagePortOneToMany request)
        {
            return Channel.sendMessagePortOneToManyAsync(request);
        }

        public System.Threading.Tasks.Task<sendMessageUDHManyToManyResponse> sendMessageUDHManyToManyAsync(sendMessageUDHManyToMany request)
        {
            return Channel.sendMessageUDHManyToManyAsync(request);
        }

        public System.Threading.Tasks.Task<getMessageStateResponse> getMessageStateAsync(getMessageState request)
        {
            return Channel.getMessageStateAsync(request);
        }

        public System.Threading.Tasks.Task<sendMessageBinaryPortOneToManyResponse> sendMessageBinaryPortOneToManyAsync(sendMessageBinaryPortOneToMany request)
        {
            return Channel.sendMessageBinaryPortOneToManyAsync(request);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)this).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)this).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)this).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)this).EndClose));
        }

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if (endpointConfiguration == EndpointConfiguration.MessageRelayPort)
            {
                var result = new System.ServiceModel.Channels.CustomBinding();
                var textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                var httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if (endpointConfiguration == EndpointConfiguration.MessageRelayPort)
            {
                return new System.ServiceModel.EndpointAddress("http://vesal.armaghan.net:8080/core/MessageRelayService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return GetBindingForEndpoint(EndpointConfiguration.MessageRelayPort);
        }

        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return GetEndpointAddress(EndpointConfiguration.MessageRelayPort);
        }

        public enum EndpointConfiguration
        {

            MessageRelayPort,
        }
    }
}
