using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritorio
{

    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.loc.gov/zing/srw/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.loc.gov/zing/srw/", IsNullable = false)]
    public partial class searchRetrieveResponse
    {

        private decimal versionField;

        private byte numberOfRecordsField;

        private string resultSetIdField;

        public searchRetrieveResponseRecord[] recordsField;

        private searchRetrieveResponseEchoedSearchRetrieveRequest echoedSearchRetrieveRequestField;

        private diagnostics diagnosticsField;

        private searchRetrieveResponseExtraResponseData extraResponseDataField;

        /// <remarks/>
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public byte numberOfRecords
        {
            get
            {
                return this.numberOfRecordsField;
            }
            set
            {
                this.numberOfRecordsField = value;
            }
        }

        /// <remarks/>
        public string resultSetId
        {
            get
            {
                return this.resultSetIdField;
            }
            set
            {
                this.resultSetIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("record", IsNullable = false)]
        public searchRetrieveResponseRecord[] records
        {
            get
            {
                return this.recordsField;
            }
            set
            {
                this.recordsField = value;
            }
        }

        /// <remarks/>
        public searchRetrieveResponseEchoedSearchRetrieveRequest echoedSearchRetrieveRequest
        {
            get
            {
                return this.echoedSearchRetrieveRequestField;
            }
            set
            {
                this.echoedSearchRetrieveRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.loc.gov/zing/srw/diagnostic/")]
        public diagnostics diagnostics
        {
            get
            {
                return this.diagnosticsField;
            }
            set
            {
                this.diagnosticsField = value;
            }
        }

        /// <remarks/>
        public searchRetrieveResponseExtraResponseData extraResponseData
        {
            get
            {
                return this.extraResponseDataField;
            }
            set
            {
                this.extraResponseDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.loc.gov/zing/srw/")]
    public partial class searchRetrieveResponseRecord
    {

        private string recordSchemaField;

        private string recordPackingField;

        private searchRetrieveResponseRecordRecordData recordDataField;

        private byte recordPositionField;

        /// <remarks/>
        public string recordSchema
        {
            get
            {
                return this.recordSchemaField;
            }
            set
            {
                this.recordSchemaField = value;
            }
        }

        /// <remarks/>
        public string recordPacking
        {
            get
            {
                return this.recordPackingField;
            }
            set
            {
                this.recordPackingField = value;
            }
        }

        /// <remarks/>
        public searchRetrieveResponseRecordRecordData recordData
        {
            get
            {
                return this.recordDataField;
            }
            set
            {
                this.recordDataField = value;
            }
        }

        /// <remarks/>
        public byte recordPosition
        {
            get
            {
                return this.recordPositionField;
            }
            set
            {
                this.recordPositionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.loc.gov/zing/srw/")]
    public partial class searchRetrieveResponseRecordRecordData
    {

        private responseRecord responseRecordField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public responseRecord responseRecord
        {
            get
            {
                return this.responseRecordField;
            }
            set
            {
                this.responseRecordField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class responseRecord
    {

        private responseRecordISNIAssigned iSNIAssignedField;

        /// <remarks/>
        public responseRecordISNIAssigned ISNIAssigned
        {
            get
            {
                return this.iSNIAssignedField;
            }
            set
            {
                this.iSNIAssignedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssigned
    {

        private string isniUnformattedField;

        private string isniURIField;

        private uint mergedISNIField;

        private bool mergedISNIFieldSpecified;

        private byte dataConfidenceField;

        private responseRecordISNIAssignedISNIMetadata iSNIMetadataField;

        /// <remarks/>
        public string isniUnformatted
        {
            get
            {
                return this.isniUnformattedField;
            }
            set
            {
                this.isniUnformattedField = value;
            }
        }

        /// <remarks/>
        public string isniURI
        {
            get
            {
                return this.isniURIField;
            }
            set
            {
                this.isniURIField = value;
            }
        }

        /// <remarks/>
        public uint mergedISNI
        {
            get
            {
                return this.mergedISNIField;
            }
            set
            {
                this.mergedISNIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mergedISNISpecified
        {
            get
            {
                return this.mergedISNIFieldSpecified;
            }
            set
            {
                this.mergedISNIFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte dataConfidence
        {
            get
            {
                return this.dataConfidenceField;
            }
            set
            {
                this.dataConfidenceField = value;
            }
        }

        /// <remarks/>
        public responseRecordISNIAssignedISNIMetadata ISNIMetadata
        {
            get
            {
                return this.iSNIMetadataField;
            }
            set
            {
                this.iSNIMetadataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadata
    {

        private responseRecordISNIAssignedISNIMetadataIdentity identityField;

        private responseRecordISNIAssignedISNIMetadataOtherIdentifierOfIdentity otherIdentifierOfIdentityField;

        private responseRecordISNIAssignedISNIMetadataSources[] sourcesField;

        private responseRecordISNIAssignedISNIMetadataExternalInformation[] externalInformationField;

        /// <remarks/>
        public responseRecordISNIAssignedISNIMetadataIdentity identity
        {
            get
            {
                return this.identityField;
            }
            set
            {
                this.identityField = value;
            }
        }

        /// <remarks/>
        public responseRecordISNIAssignedISNIMetadataOtherIdentifierOfIdentity otherIdentifierOfIdentity
        {
            get
            {
                return this.otherIdentifierOfIdentityField;
            }
            set
            {
                this.otherIdentifierOfIdentityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sources")]
        public responseRecordISNIAssignedISNIMetadataSources[] sources
        {
            get
            {
                return this.sourcesField;
            }
            set
            {
                this.sourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalInformation")]
        public responseRecordISNIAssignedISNIMetadataExternalInformation[] externalInformation
        {
            get
            {
                return this.externalInformationField;
            }
            set
            {
                this.externalInformationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataIdentity
    {

        private responseRecordISNIAssignedISNIMetadataIdentityPersonOrFiction personOrFictionField;

        /// <remarks/>
        public responseRecordISNIAssignedISNIMetadataIdentityPersonOrFiction personOrFiction
        {
            get
            {
                return this.personOrFictionField;
            }
            set
            {
                this.personOrFictionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataIdentityPersonOrFiction
    {

        private responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionPersonalName[] personalNameField;

        private responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivity creativeActivityField;

        private responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionPersonalNameVariant[] personalNameVariantField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("personalName")]
        public responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionPersonalName[] personalName
        {
            get
            {
                return this.personalNameField;
            }
            set
            {
                this.personalNameField = value;
            }
        }

        /// <remarks/>
        public responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivity creativeActivity
        {
            get
            {
                return this.creativeActivityField;
            }
            set
            {
                this.creativeActivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("personalNameVariant")]
        public responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionPersonalNameVariant[] personalNameVariant
        {
            get
            {
                return this.personalNameVariantField;
            }
            set
            {
                this.personalNameVariantField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionPersonalName
    {

        private string scriptField;

        private string forenameField;

        private string surnameField;

        private string marcDateField;

        private string nameUseField;

        private string[] sourceField;

        private string subsourceIdentifierField;

        /// <remarks/>
        public string script
        {
            get
            {
                return this.scriptField;
            }
            set
            {
                this.scriptField = value;
            }
        }

        /// <remarks/>
        public string forename
        {
            get
            {
                return this.forenameField;
            }
            set
            {
                this.forenameField = value;
            }
        }

        /// <remarks/>
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }

        /// <remarks/>
        public string marcDate
        {
            get
            {
                return this.marcDateField;
            }
            set
            {
                this.marcDateField = value;
            }
        }

        /// <remarks/>
        public string nameUse
        {
            get
            {
                return this.nameUseField;
            }
            set
            {
                this.nameUseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public string[] source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        public string subsourceIdentifier
        {
            get
            {
                return this.subsourceIdentifierField;
            }
            set
            {
                this.subsourceIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivity
    {

        private responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityCreationRole[] creationRoleField;

        private responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityCreationClass[] creationClassField;

        private responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityTitleOfWork[] titleOfWorkField;

        private responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityIdentifier[] identifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("creationRole")]
        public responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityCreationRole[] creationRole
        {
            get
            {
                return this.creationRoleField;
            }
            set
            {
                this.creationRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("creationClass")]
        public responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityCreationClass[] creationClass
        {
            get
            {
                return this.creationClassField;
            }
            set
            {
                this.creationClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("titleOfWork")]
        public responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityTitleOfWork[] titleOfWork
        {
            get
            {
                return this.titleOfWorkField;
            }
            set
            {
                this.titleOfWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("identifier")]
        public responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityIdentifier[] identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityCreationRole
    {

        private string sourceField;

        private string subsourceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subsource
        {
            get
            {
                return this.subsourceField;
            }
            set
            {
                this.subsourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityCreationClass
    {

        private string sourceField;

        private string subsourceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subsource
        {
            get
            {
                return this.subsourceField;
            }
            set
            {
                this.subsourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityTitleOfWork
    {

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string sourceField;

        private string subsourceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("statementOfResponsibility", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("subtitle", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subsource
        {
            get
            {
                return this.subsourceField;
            }
            set
            {
                this.subsourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        statementOfResponsibility,

        /// <remarks/>
        subtitle,

        /// <remarks/>
        title,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionCreativeActivityIdentifier
    {

        private string identifierTypeField;

        private ulong identifierValueField;

        private string[] sourceField;

        /// <remarks/>
        public string identifierType
        {
            get
            {
                return this.identifierTypeField;
            }
            set
            {
                this.identifierTypeField = value;
            }
        }

        /// <remarks/>
        public ulong identifierValue
        {
            get
            {
                return this.identifierValueField;
            }
            set
            {
                this.identifierValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public string[] source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionPersonalNameVariant
    {

        private string scriptField;

        private string forenameField;

        private string surnameField;

        private string nameTitleField;

        private string marcDateField;

        private string nameUseField;

        private string[] sourceField;

        /// <remarks/>
        public string script
        {
            get
            {
                return this.scriptField;
            }
            set
            {
                this.scriptField = value;
            }
        }

        /// <remarks/>
        public string forename
        {
            get
            {
                return this.forenameField;
            }
            set
            {
                this.forenameField = value;
            }
        }

        /// <remarks/>
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }

        /// <remarks/>
        public string nameTitle
        {
            get
            {
                return this.nameTitleField;
            }
            set
            {
                this.nameTitleField = value;
            }
        }

        /// <remarks/>
        public string marcDate
        {
            get
            {
                return this.marcDateField;
            }
            set
            {
                this.marcDateField = value;
            }
        }

        /// <remarks/>
        public string nameUse
        {
            get
            {
                return this.nameUseField;
            }
            set
            {
                this.nameUseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public string[] source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataOtherIdentifierOfIdentity
    {

        private string typeField;

        private string identifierField;

        private string sourceField;

        /// <remarks/>
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataSources
    {

        private string codeOfSourceField;

        private string sourceIdentifierField;

        private responseRecordISNIAssignedISNIMetadataSourcesReference referenceField;

        /// <remarks/>
        public string codeOfSource
        {
            get
            {
                return this.codeOfSourceField;
            }
            set
            {
                this.codeOfSourceField = value;
            }
        }

        /// <remarks/>
        public string sourceIdentifier
        {
            get
            {
                return this.sourceIdentifierField;
            }
            set
            {
                this.sourceIdentifierField = value;
            }
        }

        /// <remarks/>
        public responseRecordISNIAssignedISNIMetadataSourcesReference reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataSourcesReference
    {

        private string classField;

        private string roleField;

        private string uRIField;

        /// <remarks/>
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseRecordISNIAssignedISNIMetadataExternalInformation
    {

        private string informationField;

        private string uRIField;

        /// <remarks/>
        public string information
        {
            get
            {
                return this.informationField;
            }
            set
            {
                this.informationField = value;
            }
        }

        /// <remarks/>
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.loc.gov/zing/srw/")]
    public partial class searchRetrieveResponseEchoedSearchRetrieveRequest
    {

        private decimal versionField;

        private string queryField;

        private searchRetrieveResponseEchoedSearchRetrieveRequestXQuery xQueryField;

        private byte startRecordField;

        private byte maximumRecordsField;

        private string recordPackingField;

        private string recordSchemaField;

        private string stylesheetField;

        /// <remarks/>
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }

        /// <remarks/>
        public searchRetrieveResponseEchoedSearchRetrieveRequestXQuery xQuery
        {
            get
            {
                return this.xQueryField;
            }
            set
            {
                this.xQueryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public byte startRecord
        {
            get
            {
                return this.startRecordField;
            }
            set
            {
                this.startRecordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public byte maximumRecords
        {
            get
            {
                return this.maximumRecordsField;
            }
            set
            {
                this.maximumRecordsField = value;
            }
        }

        /// <remarks/>
        public string recordPacking
        {
            get
            {
                return this.recordPackingField;
            }
            set
            {
                this.recordPackingField = value;
            }
        }

        /// <remarks/>
        public string recordSchema
        {
            get
            {
                return this.recordSchemaField;
            }
            set
            {
                this.recordSchemaField = value;
            }
        }

        /// <remarks/>
        public string stylesheet
        {
            get
            {
                return this.stylesheetField;
            }
            set
            {
                this.stylesheetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.loc.gov/zing/srw/")]
    public partial class searchRetrieveResponseEchoedSearchRetrieveRequestXQuery
    {

        private searchClause searchClauseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.loc.gov/zing/cql/xcql/")]
        public searchClause searchClause
        {
            get
            {
                return this.searchClauseField;
            }
            set
            {
                this.searchClauseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.loc.gov/zing/cql/xcql/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.loc.gov/zing/cql/xcql/", IsNullable = false)]
    public partial class searchClause
    {

        private string indexField;

        private searchClauseRelation relationField;

        private string termField;

        /// <remarks/>
        public string index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        public searchClauseRelation relation
        {
            get
            {
                return this.relationField;
            }
            set
            {
                this.relationField = value;
            }
        }

        /// <remarks/>
        public string term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.loc.gov/zing/cql/xcql/")]
    public partial class searchClauseRelation
    {

        private string valueField;

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.loc.gov/zing/srw/diagnostic/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.loc.gov/zing/srw/diagnostic/", IsNullable = false)]
    public partial class diagnostics
    {

        private string uriField;

        /// <remarks/>
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.loc.gov/zing/srw/")]
    public partial class searchRetrieveResponseExtraResponseData
    {

        private string authenticationTokenField;

        private resultGroupingGrouping[] resultGroupingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "info:srw/extension/2/auth-1.0")]
        public string authenticationToken
        {
            get
            {
                return this.authenticationTokenField;
            }
            set
            {
                this.authenticationTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "info:srw/extension/5/metadata-grouping-v1.0")]
        [System.Xml.Serialization.XmlArrayItemAttribute("grouping", IsNullable = false)]
        public resultGroupingGrouping[] resultGrouping
        {
            get
            {
                return this.resultGroupingField;
            }
            set
            {
                this.resultGroupingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "info:srw/extension/5/metadata-grouping-v1.0")]
    public partial class resultGroupingGrouping
    {

        private ushort keyField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "info:srw/extension/5/metadata-grouping-v1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "info:srw/extension/5/metadata-grouping-v1.0", IsNullable = false)]
    public partial class resultGrouping
    {

        private resultGroupingGrouping[] groupingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("grouping")]
        public resultGroupingGrouping[] grouping
        {
            get
            {
                return this.groupingField;
            }
            set
            {
                this.groupingField = value;
            }
        }
    }


}
