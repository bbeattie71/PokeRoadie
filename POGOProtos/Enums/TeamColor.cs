// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Enums/TeamColor.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/TeamColor.proto</summary>
  public static partial class TeamColorReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/TeamColor.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TeamColorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQT0dPUHJvdG9zL0VudW1zL1RlYW1Db2xvci5wcm90bxIQUE9HT1Byb3Rv",
            "cy5FbnVtcyo3CglUZWFtQ29sb3ISCwoHTkVVVFJBTBAAEggKBEJMVUUQARIH",
            "CgNSRUQQAhIKCgZZRUxMT1cQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.TeamColor), }, null));
    }
    #endregion

  }
  #region Enums
  public enum TeamColor {
    [pbr::OriginalName("NEUTRAL")] Neutral = 0,
    [pbr::OriginalName("BLUE")] Blue = 1,
    [pbr::OriginalName("RED")] Red = 2,
    [pbr::OriginalName("YELLOW")] Yellow = 3,
  }

  #endregion

}

#endregion Designer generated code
