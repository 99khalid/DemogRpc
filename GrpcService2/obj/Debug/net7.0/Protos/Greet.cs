// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcService2 {

  /// <summary>Holder for reflection information generated from Protos/greet.proto</summary>
  public static partial class GreetReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/greet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GreetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvZ3JlZXQucHJvdG8SBWdyZWV0Gh9nb29nbGUvcHJvdG9idWYv",
            "dGltZXN0YW1wLnByb3RvIpQBCgxIZWxsb1JlcXVlc3QSDAoEbmFtZRgBIAEo",
            "CRINCgVteUludBgCIAEoBRIQCghteVN0cmluZxgDIAEoCRIvCgtteVRpbWVz",
            "dGFtcBgEIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASDgoGbXlH",
            "dWlkGAUgASgJEhQKDG15U3RyaW5nTGlzdBgGIAMoCSKVAQoKSGVsbG9SZXBs",
            "eRIPCgdtZXNzYWdlGAEgASgJEg0KBW15SW50GAIgASgFEhAKCG15U3RyaW5n",
            "GAMgASgJEi8KC215VGltZXN0YW1wGAQgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcBIOCgZteUd1aWQYBSABKAkSFAoMbXlTdHJpbmdMaXN0GAYg",
            "AygJMj0KB0dyZWV0ZXISMgoIU2F5SGVsbG8SEy5ncmVldC5IZWxsb1JlcXVl",
            "c3QaES5ncmVldC5IZWxsb1JlcGx5Qg+qAgxHcnBjU2VydmljZTJiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService2.HelloRequest), global::GrpcService2.HelloRequest.Parser, new[]{ "Name", "MyInt", "MyString", "MyTimestamp", "MyGuid", "MyStringList" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService2.HelloReply), global::GrpcService2.HelloReply.Parser, new[]{ "Message", "MyInt", "MyString", "MyTimestamp", "MyGuid", "MyStringList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message containing the user's name.
  /// </summary>
  public sealed partial class HelloRequest : pb::IMessage<HelloRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HelloRequest> _parser = new pb::MessageParser<HelloRequest>(() => new HelloRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HelloRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService2.GreetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloRequest(HelloRequest other) : this() {
      name_ = other.name_;
      myInt_ = other.myInt_;
      myString_ = other.myString_;
      myTimestamp_ = other.myTimestamp_ != null ? other.myTimestamp_.Clone() : null;
      myGuid_ = other.myGuid_;
      myStringList_ = other.myStringList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloRequest Clone() {
      return new HelloRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "myInt" field.</summary>
    public const int MyIntFieldNumber = 2;
    private int myInt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyInt {
      get { return myInt_; }
      set {
        myInt_ = value;
      }
    }

    /// <summary>Field number for the "myString" field.</summary>
    public const int MyStringFieldNumber = 3;
    private string myString_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MyString {
      get { return myString_; }
      set {
        myString_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "myTimestamp" field.</summary>
    public const int MyTimestampFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp myTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp MyTimestamp {
      get { return myTimestamp_; }
      set {
        myTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "myGuid" field.</summary>
    public const int MyGuidFieldNumber = 5;
    private string myGuid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MyGuid {
      get { return myGuid_; }
      set {
        myGuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "myStringList" field.</summary>
    public const int MyStringListFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_myStringList_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> myStringList_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> MyStringList {
      get { return myStringList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HelloRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HelloRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (MyInt != other.MyInt) return false;
      if (MyString != other.MyString) return false;
      if (!object.Equals(MyTimestamp, other.MyTimestamp)) return false;
      if (MyGuid != other.MyGuid) return false;
      if(!myStringList_.Equals(other.myStringList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (MyInt != 0) hash ^= MyInt.GetHashCode();
      if (MyString.Length != 0) hash ^= MyString.GetHashCode();
      if (myTimestamp_ != null) hash ^= MyTimestamp.GetHashCode();
      if (MyGuid.Length != 0) hash ^= MyGuid.GetHashCode();
      hash ^= myStringList_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (MyInt != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MyInt);
      }
      if (MyString.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MyString);
      }
      if (myTimestamp_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MyTimestamp);
      }
      if (MyGuid.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MyGuid);
      }
      myStringList_.WriteTo(output, _repeated_myStringList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (MyInt != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MyInt);
      }
      if (MyString.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MyString);
      }
      if (myTimestamp_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MyTimestamp);
      }
      if (MyGuid.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MyGuid);
      }
      myStringList_.WriteTo(ref output, _repeated_myStringList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (MyInt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyInt);
      }
      if (MyString.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MyString);
      }
      if (myTimestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MyTimestamp);
      }
      if (MyGuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MyGuid);
      }
      size += myStringList_.CalculateSize(_repeated_myStringList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HelloRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.MyInt != 0) {
        MyInt = other.MyInt;
      }
      if (other.MyString.Length != 0) {
        MyString = other.MyString;
      }
      if (other.myTimestamp_ != null) {
        if (myTimestamp_ == null) {
          MyTimestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        MyTimestamp.MergeFrom(other.MyTimestamp);
      }
      if (other.MyGuid.Length != 0) {
        MyGuid = other.MyGuid;
      }
      myStringList_.Add(other.myStringList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            MyInt = input.ReadInt32();
            break;
          }
          case 26: {
            MyString = input.ReadString();
            break;
          }
          case 34: {
            if (myTimestamp_ == null) {
              MyTimestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(MyTimestamp);
            break;
          }
          case 42: {
            MyGuid = input.ReadString();
            break;
          }
          case 50: {
            myStringList_.AddEntriesFrom(input, _repeated_myStringList_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            MyInt = input.ReadInt32();
            break;
          }
          case 26: {
            MyString = input.ReadString();
            break;
          }
          case 34: {
            if (myTimestamp_ == null) {
              MyTimestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(MyTimestamp);
            break;
          }
          case 42: {
            MyGuid = input.ReadString();
            break;
          }
          case 50: {
            myStringList_.AddEntriesFrom(ref input, _repeated_myStringList_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The response message containing the greetings.
  /// </summary>
  public sealed partial class HelloReply : pb::IMessage<HelloReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HelloReply> _parser = new pb::MessageParser<HelloReply>(() => new HelloReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HelloReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService2.GreetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloReply(HelloReply other) : this() {
      message_ = other.message_;
      myInt_ = other.myInt_;
      myString_ = other.myString_;
      myTimestamp_ = other.myTimestamp_ != null ? other.myTimestamp_.Clone() : null;
      myGuid_ = other.myGuid_;
      myStringList_ = other.myStringList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloReply Clone() {
      return new HelloReply(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "myInt" field.</summary>
    public const int MyIntFieldNumber = 2;
    private int myInt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyInt {
      get { return myInt_; }
      set {
        myInt_ = value;
      }
    }

    /// <summary>Field number for the "myString" field.</summary>
    public const int MyStringFieldNumber = 3;
    private string myString_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MyString {
      get { return myString_; }
      set {
        myString_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "myTimestamp" field.</summary>
    public const int MyTimestampFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp myTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp MyTimestamp {
      get { return myTimestamp_; }
      set {
        myTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "myGuid" field.</summary>
    public const int MyGuidFieldNumber = 5;
    private string myGuid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MyGuid {
      get { return myGuid_; }
      set {
        myGuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "myStringList" field.</summary>
    public const int MyStringListFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_myStringList_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> myStringList_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> MyStringList {
      get { return myStringList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HelloReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HelloReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (MyInt != other.MyInt) return false;
      if (MyString != other.MyString) return false;
      if (!object.Equals(MyTimestamp, other.MyTimestamp)) return false;
      if (MyGuid != other.MyGuid) return false;
      if(!myStringList_.Equals(other.myStringList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (MyInt != 0) hash ^= MyInt.GetHashCode();
      if (MyString.Length != 0) hash ^= MyString.GetHashCode();
      if (myTimestamp_ != null) hash ^= MyTimestamp.GetHashCode();
      if (MyGuid.Length != 0) hash ^= MyGuid.GetHashCode();
      hash ^= myStringList_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (MyInt != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MyInt);
      }
      if (MyString.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MyString);
      }
      if (myTimestamp_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MyTimestamp);
      }
      if (MyGuid.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MyGuid);
      }
      myStringList_.WriteTo(output, _repeated_myStringList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (MyInt != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MyInt);
      }
      if (MyString.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MyString);
      }
      if (myTimestamp_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MyTimestamp);
      }
      if (MyGuid.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MyGuid);
      }
      myStringList_.WriteTo(ref output, _repeated_myStringList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (MyInt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyInt);
      }
      if (MyString.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MyString);
      }
      if (myTimestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MyTimestamp);
      }
      if (MyGuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MyGuid);
      }
      size += myStringList_.CalculateSize(_repeated_myStringList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HelloReply other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.MyInt != 0) {
        MyInt = other.MyInt;
      }
      if (other.MyString.Length != 0) {
        MyString = other.MyString;
      }
      if (other.myTimestamp_ != null) {
        if (myTimestamp_ == null) {
          MyTimestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        MyTimestamp.MergeFrom(other.MyTimestamp);
      }
      if (other.MyGuid.Length != 0) {
        MyGuid = other.MyGuid;
      }
      myStringList_.Add(other.myStringList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 16: {
            MyInt = input.ReadInt32();
            break;
          }
          case 26: {
            MyString = input.ReadString();
            break;
          }
          case 34: {
            if (myTimestamp_ == null) {
              MyTimestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(MyTimestamp);
            break;
          }
          case 42: {
            MyGuid = input.ReadString();
            break;
          }
          case 50: {
            myStringList_.AddEntriesFrom(input, _repeated_myStringList_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 16: {
            MyInt = input.ReadInt32();
            break;
          }
          case 26: {
            MyString = input.ReadString();
            break;
          }
          case 34: {
            if (myTimestamp_ == null) {
              MyTimestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(MyTimestamp);
            break;
          }
          case 42: {
            MyGuid = input.ReadString();
            break;
          }
          case 50: {
            myStringList_.AddEntriesFrom(ref input, _repeated_myStringList_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
