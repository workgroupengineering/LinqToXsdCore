//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToXsd.Schemas.Test.DateTimeOffsetTest {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Linq;
    using Xml.Schema.Linq;
    
    
    /// <summary>
    /// <para>
    /// Regular expression: (edatetime)
    /// </para>
    /// </summary>
    public partial class root : XTypedElement, IXMetaData {
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static root Load(string xmlFile) {
            return XTypedServices.Load<root>(xmlFile);
        }
        
        public static root Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<root>(xmlFile);
        }
        
        public static root Parse(string xml) {
            return XTypedServices.Parse<root>(xml);
        }
        
		public static explicit operator root(XElement xe) { return XTypedServices.ToXTypedElement<root>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<root>(this);
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (edatetime)
        /// </para>
        /// </summary>
        public root() {
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static readonly System.Xml.Linq.XName edatetimeXName = System.Xml.Linq.XName.Get("e-datetime", "http://linqtoxsd.schemas.org/test/datetimeoffset-test.xsd");
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (edatetime)
        /// </para>
        /// </summary>
        public virtual System.DateTimeOffset edatetime {
            get {
                XElement x = this.GetElement(edatetimeXName);
                return XTypedServices.ParseValue<System.DateTimeOffset>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
            }
            set {
                this.SetElement(edatetimeXName, value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static readonly System.Xml.Linq.XName adatetimeXName = System.Xml.Linq.XName.Get("a-datetime", "");
        
        /// <summary>
        /// <para>
        /// Occurrence: optional
        /// </para>
        /// </summary>
        public virtual System.DateTimeOffset? adatetime {
            get {
                XAttribute x = this.Attribute(adatetimeXName);
                if ((x == null)) {
                    return null;
                }
                return XTypedServices.ParseValue<System.DateTimeOffset>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
            }
            set {
                this.SetAttribute(adatetimeXName, value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.DateTime).Datatype);
            }
        }
        
        private static readonly System.Xml.Linq.XName xName = System.Xml.Linq.XName.Get("root", "http://linqtoxsd.schemas.org/test/datetimeoffset-test.xsd");
        
        static root() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(edatetimeXName));
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static Dictionary<System.Xml.Linq.XName, System.Type> localElementDictionary = new Dictionary<System.Xml.Linq.XName, System.Type>();
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(edatetimeXName, typeof(System.DateTimeOffset));
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<System.Xml.Linq.XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        System.Xml.Linq.XName IXMetaData.SchemaName {
            get {
                return xName;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
    }
    
    public class LinqToXsdTypeManager : ILinqToXsdTypeManager {
        
        private LinqToXsdTypeManager() {
        }
        
        private static Dictionary<System.Xml.Linq.XName, System.Type> elementDictionary = new Dictionary<System.Xml.Linq.XName, System.Type>();
        
        private static void BuildElementDictionary() {
            elementDictionary.Add(System.Xml.Linq.XName.Get("root", "http://linqtoxsd.schemas.org/test/datetimeoffset-test.xsd"), typeof(global::LinqToXsd.Schemas.Test.DateTimeOffsetTest.root));
        }
        
        private static XmlSchemaSet schemaSet;
        
        XmlSchemaSet ILinqToXsdTypeManager.Schemas {
            get {
                if ((schemaSet == null)) {
                    XmlSchemaSet tempSet = new XmlSchemaSet();
                    System.Threading.Interlocked.CompareExchange(ref schemaSet, tempSet, null);
                }
                return schemaSet;
            }
            set {
                schemaSet = value;
            }
        }
        
        protected internal static void AddSchemas(XmlSchemaSet schemas) {
            schemas.Add(schemaSet);
        }
        
        Dictionary<System.Xml.Linq.XName, System.Type> ILinqToXsdTypeManager.GlobalTypeDictionary {
            get {
                return XTypedServices.EmptyDictionary;
            }
        }
        
        Dictionary<System.Xml.Linq.XName, System.Type> ILinqToXsdTypeManager.GlobalElementDictionary {
            get {
                return elementDictionary;
            }
        }
        
        Dictionary<System.Type, System.Type> ILinqToXsdTypeManager.RootContentTypeMapping {
            get {
                return XTypedServices.EmptyTypeMappingDictionary;
            }
        }
        
        static LinqToXsdTypeManager() {
            BuildElementDictionary();
        }
        
        public static System.Type GetRootType() {
            return elementDictionary[System.Xml.Linq.XName.Get("root", "http://linqtoxsd.schemas.org/test/datetimeoffset-test.xsd")];
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static LinqToXsdTypeManager typeManagerSingleton = new LinqToXsdTypeManager();
        
        public static LinqToXsdTypeManager Instance {
            get {
                return typeManagerSingleton;
            }
        }
    }
    
    public partial class XRootNamespace {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XDocument doc;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedElement rootObject;
        
        private XRootNamespace() {
        }
        
        public static XRootNamespace Load(string xmlFile) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(xmlFile);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(string xmlFile, LoadOptions options) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(xmlFile, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(TextReader textReader) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(textReader);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(TextReader textReader, LoadOptions options) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(textReader, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(XmlReader xmlReader) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(xmlReader);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Parse(string text) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Parse(text);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Parse(string text, LoadOptions options) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Parse(text, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public virtual void Save(string fileName) {
            doc.Save(fileName);
        }
        
        public virtual void Save(TextWriter textWriter) {
            doc.Save(textWriter);
        }
        
        public virtual void Save(XmlWriter writer) {
            doc.Save(writer);
        }
        
        public virtual void Save(TextWriter textWriter, SaveOptions options) {
            doc.Save(textWriter, options);
        }
        
        public virtual void Save(string fileName, SaveOptions options) {
            doc.Save(fileName, options);
        }
        
        public virtual XDocument XDocument {
            get {
                return doc;
            }
        }
        
        public virtual XTypedElement Root {
            get {
                return rootObject;
            }
        }
        
        public XRootNamespace(root root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        

		public root root1 {  get {return rootObject as root; } }
    }
    
    public partial class XRoot {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XDocument doc;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedElement rootObject;
        
        private XRoot() {
        }
        
        public static XRoot Load(string xmlFile) {
            XRoot root = new XRoot();
            root.doc = XDocument.Load(xmlFile);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Load(string xmlFile, LoadOptions options) {
            XRoot root = new XRoot();
            root.doc = XDocument.Load(xmlFile, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Load(TextReader textReader) {
            XRoot root = new XRoot();
            root.doc = XDocument.Load(textReader);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Load(TextReader textReader, LoadOptions options) {
            XRoot root = new XRoot();
            root.doc = XDocument.Load(textReader, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Load(XmlReader xmlReader) {
            XRoot root = new XRoot();
            root.doc = XDocument.Load(xmlReader);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Parse(string text) {
            XRoot root = new XRoot();
            root.doc = XDocument.Parse(text);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Parse(string text, LoadOptions options) {
            XRoot root = new XRoot();
            root.doc = XDocument.Parse(text, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public virtual void Save(string fileName) {
            doc.Save(fileName);
        }
        
        public virtual void Save(TextWriter textWriter) {
            doc.Save(textWriter);
        }
        
        public virtual void Save(XmlWriter writer) {
            doc.Save(writer);
        }
        
        public virtual void Save(TextWriter textWriter, SaveOptions options) {
            doc.Save(textWriter, options);
        }
        
        public virtual void Save(string fileName, SaveOptions options) {
            doc.Save(fileName, options);
        }
        
        public virtual XDocument XDocument {
            get {
                return doc;
            }
        }
        
        public virtual XTypedElement Root {
            get {
                return rootObject;
            }
        }
        
        public XRoot(global::LinqToXsd.Schemas.Test.DateTimeOffsetTest.root root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        

		public global::LinqToXsd.Schemas.Test.DateTimeOffsetTest.root root1 {  get {return rootObject as global::LinqToXsd.Schemas.Test.DateTimeOffsetTest.root; } }
    }
}
