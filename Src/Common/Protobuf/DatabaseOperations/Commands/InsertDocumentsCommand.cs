// /*
// * Copyright (c) 2016, Alachisoft. All Rights Reserved.
// *
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// *
// * http://www.apache.org/licenses/LICENSE-2.0
// *
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// */
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Alachisoft.NosDB.Common.Protobuf {
  
  namespace Proto {
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class InsertDocumentsCommand {
    
      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_Alachisoft_NosDB_Common_Protobuf_InsertDocumentsCommand__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::Alachisoft.NosDB.Common.Protobuf.InsertDocumentsCommand, global::Alachisoft.NosDB.Common.Protobuf.InsertDocumentsCommand.Builder> internal__static_Alachisoft_NosDB_Common_Protobuf_InsertDocumentsCommand__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;
      
      static InsertDocumentsCommand() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "ChxJbnNlcnREb2N1bWVudHNDb21tYW5kLnByb3RvEiBBbGFjaGlzb2Z0Lk5v", 
              "c0RCLkNvbW1vbi5Qcm90b2J1ZiIrChZJbnNlcnREb2N1bWVudHNDb21tYW5k", 
              "EhEKCWRvY3VtZW50cxgBIAMoCUJGCiRjb20uYWxhY2hpc29mdC5ub3NkYi5j", 
              "b21tb24ucHJvdG9idWZCHkluc2VydERvY3VtZW50c0NvbW1hbmRQcm90b2Nv", 
            "bA=="));
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_Alachisoft_NosDB_Common_Protobuf_InsertDocumentsCommand__Descriptor = Descriptor.MessageTypes[0];
          internal__static_Alachisoft_NosDB_Common_Protobuf_InsertDocumentsCommand__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::Alachisoft.NosDB.Common.Protobuf.InsertDocumentsCommand, global::Alachisoft.NosDB.Common.Protobuf.InsertDocumentsCommand.Builder>(internal__static_Alachisoft_NosDB_Common_Protobuf_InsertDocumentsCommand__Descriptor,
                  new string[] { "Documents", });
          return null;
        };
        pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbd::FileDescriptor[] {
            }, assigner);
      }
      #endregion
      
    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class InsertDocumentsCommand : pb::GeneratedMessage<InsertDocumentsCommand, InsertDocumentsCommand.Builder> {
    private InsertDocumentsCommand() { }
    private static readonly InsertDocumentsCommand defaultInstance = new InsertDocumentsCommand().MakeReadOnly();
    private static readonly string[] _insertDocumentsCommandFieldNames = new string[] { "documents" };
    private static readonly uint[] _insertDocumentsCommandFieldTags = new uint[] { 10 };
    public static InsertDocumentsCommand DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override InsertDocumentsCommand DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override InsertDocumentsCommand ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Alachisoft.NosDB.Common.Protobuf.Proto.InsertDocumentsCommand.internal__static_Alachisoft_NosDB_Common_Protobuf_InsertDocumentsCommand__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<InsertDocumentsCommand, InsertDocumentsCommand.Builder> InternalFieldAccessors {
      get { return global::Alachisoft.NosDB.Common.Protobuf.Proto.InsertDocumentsCommand.internal__static_Alachisoft_NosDB_Common_Protobuf_InsertDocumentsCommand__FieldAccessorTable; }
    }
    
    public const int DocumentsFieldNumber = 1;
    private pbc::PopsicleList<string> documents_ = new pbc::PopsicleList<string>();
    public scg::IList<string> DocumentsList {
      get { return pbc::Lists.AsReadOnly(documents_); }
    }
    public int DocumentsCount {
      get { return documents_.Count; }
    }
    public string GetDocuments(int index) {
      return documents_[index];
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _insertDocumentsCommandFieldNames;
      if (documents_.Count > 0) {
        output.WriteStringArray(1, field_names[0], documents_);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }
    
    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;
      
      size = 0;
      {
        int dataSize = 0;
        foreach (string element in DocumentsList) {
          dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(element);
        }
        size += dataSize;
        size += 1 * documents_.Count;
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static InsertDocumentsCommand ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static InsertDocumentsCommand ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static InsertDocumentsCommand ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static InsertDocumentsCommand ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static InsertDocumentsCommand ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static InsertDocumentsCommand ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static InsertDocumentsCommand ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static InsertDocumentsCommand ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static InsertDocumentsCommand ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static InsertDocumentsCommand ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private InsertDocumentsCommand MakeReadOnly() {
      documents_.MakeReadOnly();
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(InsertDocumentsCommand prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<InsertDocumentsCommand, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(InsertDocumentsCommand cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private InsertDocumentsCommand result;
      
      private InsertDocumentsCommand PrepareBuilder() {
        if (resultIsReadOnly) {
          InsertDocumentsCommand original = result;
          result = new InsertDocumentsCommand();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override InsertDocumentsCommand MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Alachisoft.NosDB.Common.Protobuf.InsertDocumentsCommand.Descriptor; }
      }
      
      public override InsertDocumentsCommand DefaultInstanceForType {
        get { return global::Alachisoft.NosDB.Common.Protobuf.InsertDocumentsCommand.DefaultInstance; }
      }
      
      public override InsertDocumentsCommand BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is InsertDocumentsCommand) {
          return MergeFrom((InsertDocumentsCommand) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(InsertDocumentsCommand other) {
        if (other == global::Alachisoft.NosDB.Common.Protobuf.InsertDocumentsCommand.DefaultInstance) return this;
        PrepareBuilder();
        if (other.documents_.Count != 0) {
          result.documents_.Add(other.documents_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_insertDocumentsCommandFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _insertDocumentsCommandFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              input.ReadStringArray(tag, field_name, result.documents_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public pbc::IPopsicleList<string> DocumentsList {
        get { return PrepareBuilder().documents_; }
      }
      public int DocumentsCount {
        get { return result.DocumentsCount; }
      }
      public string GetDocuments(int index) {
        return result.GetDocuments(index);
      }
      public Builder SetDocuments(int index, string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.documents_[index] = value;
        return this;
      }
      public Builder AddDocuments(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.documents_.Add(value);
        return this;
      }
      public Builder AddRangeDocuments(scg::IEnumerable<string> values) {
        PrepareBuilder();
        result.documents_.Add(values);
        return this;
      }
      public Builder ClearDocuments() {
        PrepareBuilder();
        result.documents_.Clear();
        return this;
      }
    }
    static InsertDocumentsCommand() {
      object.ReferenceEquals(global::Alachisoft.NosDB.Common.Protobuf.Proto.InsertDocumentsCommand.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
