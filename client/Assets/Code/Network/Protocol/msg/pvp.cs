//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Pvp.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClientInput")]
  public partial class ClientInput : global::ProtoBuf.IExtensible
  {
    public ClientInput() {}
    
    private uint _dir = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"dir", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dir
    {
      get { return _dir; }
      set { _dir = value; }
    }
    private uint _cmd = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cmd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cmd
    {
      get { return _cmd; }
      set { _cmd = value; }
    }
    private uint _acc_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FrameInfo")]
  public partial class FrameInfo : global::ProtoBuf.IExtensible
  {
    public FrameInfo() {}
    
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.ClientInput> _info = new global::System.Collections.Generic.List<fogs.proto.msg.ClientInput>();
    [global::ProtoBuf.ProtoMember(1, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.ClientInput> info
    {
      get { return _info; }
    }
  
    private uint _frameNum = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"frameNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint frameNum
    {
      get { return _frameNum; }
      set { _frameNum = value; }
    }
    private double _time = default(double);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double time
    {
      get { return _time; }
      set { _time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SVector3")]
  public partial class SVector3 : global::ProtoBuf.IExtensible
  {
    public SVector3() {}
    
    private int _x;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }
    private int _y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }
    private int _z;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int z
    {
      get { return _z; }
      set { _z = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GameBeginReq")]
  public partial class GameBeginReq : global::ProtoBuf.IExtensible
  {
    public GameBeginReq() {}
    
    private uint _acc_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GameBeginResp")]
  public partial class GameBeginResp : global::ProtoBuf.IExtensible
  {
    public GameBeginResp() {}
    
    private readonly global::System.Collections.Generic.List<uint> _acc_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> acc_id
    {
      get { return _acc_id; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CheckFrame")]
  public partial class CheckFrame : global::ProtoBuf.IExtensible
  {
    public CheckFrame() {}
    
    private uint _frameNum = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"frameNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint frameNum
    {
      get { return _frameNum; }
      set { _frameNum = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.PlayerKeyState> _datas = new global::System.Collections.Generic.List<fogs.proto.msg.PlayerKeyState>();
    [global::ProtoBuf.ProtoMember(2, Name=@"datas", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.PlayerKeyState> datas
    {
      get { return _datas; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerKeyState")]
  public partial class PlayerKeyState : global::ProtoBuf.IExtensible
  {
    public PlayerKeyState() {}
    
    private uint _acc_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private fogs.proto.msg.SVector3 _position;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public fogs.proto.msg.SVector3 position
    {
      get { return _position; }
      set { _position = value; }
    }
    private int _velocity;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"velocity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int velocity
    {
      get { return _velocity; }
      set { _velocity = value; }
    }
    private int _hori_angle;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"hori_angle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hori_angle
    {
      get { return _hori_angle; }
      set { _hori_angle = value; }
    }
    private uint _state;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint state
    {
      get { return _state; }
      set { _state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EnterPlat")]
  public partial class EnterPlat : global::ProtoBuf.IExtensible
  {
    public EnterPlat() {}
    
    private uint _acc_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private ulong _session = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"session", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong session
    {
      get { return _session; }
      set { _session = value; }
    }
    private uint _login_index = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"login_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint login_index
    {
      get { return _login_index; }
      set { _login_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EnterPlatResp")]
  public partial class EnterPlatResp : global::ProtoBuf.IExtensible
  {
    public EnterPlatResp() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _acc_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}