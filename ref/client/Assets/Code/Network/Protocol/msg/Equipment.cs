//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Equipment.proto
// Note: requires additional types generated from: Base.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipmentSlot")]
  public partial class EquipmentSlot : global::ProtoBuf.IExtensible
  {
    public EquipmentSlot() {}
    
    private fogs.proto.msg.EquipmentSlotID _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public fogs.proto.msg.EquipmentSlotID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _equipment_uuid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"equipment_uuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong equipment_uuid
    {
      get { return _equipment_uuid; }
      set { _equipment_uuid = value; }
    }
    private uint _equipment_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"equipment_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint equipment_id
    {
      get { return _equipment_id; }
      set { _equipment_id = value; }
    }
    private uint _equipment_level;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"equipment_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint equipment_level
    {
      get { return _equipment_level; }
      set { _equipment_level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipInfo")]
  public partial class EquipInfo : global::ProtoBuf.IExtensible
  {
    public EquipInfo() {}
    
    private fogs.proto.msg.FightStatus _pos;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public fogs.proto.msg.FightStatus pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.EquipmentSlot> _slot_info = new global::System.Collections.Generic.List<fogs.proto.msg.EquipmentSlot>();
    [global::ProtoBuf.ProtoMember(2, Name=@"slot_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.EquipmentSlot> slot_info
    {
      get { return _slot_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipOperation")]
  public partial class EquipOperation : global::ProtoBuf.IExtensible
  {
    public EquipOperation() {}
    
    private fogs.proto.msg.EquipmentOperationType _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public fogs.proto.msg.EquipmentOperationType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private fogs.proto.msg.EquipInfo _info = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public fogs.proto.msg.EquipInfo info
    {
      get { return _info; }
      set { _info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipOperationResp")]
  public partial class EquipOperationResp : global::ProtoBuf.IExtensible
  {
    public EquipOperationResp() {}
    
    private fogs.proto.msg.EquipmentOperationType _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public fogs.proto.msg.EquipmentOperationType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.EquipInfo> _info = new global::System.Collections.Generic.List<fogs.proto.msg.EquipInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.EquipInfo> info
    {
      get { return _info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"EquipmentType")]
    public enum EquipmentType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ET_HEAD", Value=1)]
      ET_HEAD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ET_CHEST", Value=2)]
      ET_CHEST = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ET_BRACER", Value=3)]
      ET_BRACER = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ET_PANTS", Value=4)]
      ET_PANTS = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ET_SHOE", Value=5)]
      ET_SHOE = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ET_EQUIPMENTPIECE", Value=6)]
      ET_EQUIPMENTPIECE = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ET_ALL", Value=7)]
      ET_ALL = 7
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EquipmentOperationType")]
    public enum EquipmentOperationType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EOT_EQUIP", Value=1)]
      EOT_EQUIP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EOT_UNEQUIP", Value=2)]
      EOT_UNEQUIP = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EOT_EXCHANGE", Value=3)]
      EOT_EXCHANGE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EOT_UPGRADE_SINGLE", Value=4)]
      EOT_UPGRADE_SINGLE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EOT_UPGRADE_AUTO", Value=5)]
      EOT_UPGRADE_AUTO = 5
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EquipmentSlotID")]
    public enum EquipmentSlotID
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ESID_HEAD", Value=1)]
      ESID_HEAD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ESID_CHEST", Value=2)]
      ESID_CHEST = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ESID_BRACER", Value=3)]
      ESID_BRACER = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ESID_PANTS", Value=4)]
      ESID_PANTS = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ESID_SHOE", Value=5)]
      ESID_SHOE = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ESID_ALL", Value=6)]
      ESID_ALL = 6
    }
  
}