//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Lottery.proto
// Note: requires additional types generated from: Base.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BuyLotteryReq")]
  public partial class BuyLotteryReq : global::ProtoBuf.IExtensible
  {
    public BuyLotteryReq() {}
    
    private uint _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint count
    {
      get { return _count; }
      set { _count = value; }
    }
    private uint _is_free = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"is_free", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint is_free
    {
      get { return _is_free; }
      set { _is_free = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BuyLotteryResp")]
  public partial class BuyLotteryResp : global::ProtoBuf.IExtensible
  {
    public BuyLotteryResp() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _count;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint count
    {
      get { return _count; }
      set { _count = value; }
    }
    private uint _is_free = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"is_free", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint is_free
    {
      get { return _is_free; }
      set { _is_free = value; }
    }
    private uint _free_times = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"free_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint free_times
    {
      get { return _free_times; }
      set { _free_times = value; }
    }
    private uint _last_time = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"last_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint last_time
    {
      get { return _last_time; }
      set { _last_time = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.KeyValueData> _prizes = new global::System.Collections.Generic.List<fogs.proto.msg.KeyValueData>();
    [global::ProtoBuf.ProtoMember(7, Name=@"prizes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.KeyValueData> prizes
    {
      get { return _prizes; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}