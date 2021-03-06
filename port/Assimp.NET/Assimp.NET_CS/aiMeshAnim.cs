/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiMeshAnim : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMeshAnim(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiMeshAnim obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMeshAnim() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiMeshAnim(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiMeshKeyVector mKeys { get { return GetmKeys(); } }

  public aiString mName {
    set {
      AssimpPINVOKE.aiMeshAnim_mName_set(swigCPtr, aiString.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiMeshAnim_mName_get(swigCPtr);
      aiString ret = (cPtr == IntPtr.Zero) ? null : new aiString(cPtr, false);
      return ret;
    } 
  }

  public uint mNumKeys {
    set {
      AssimpPINVOKE.aiMeshAnim_mNumKeys_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMeshAnim_mNumKeys_get(swigCPtr);
      return ret;
    } 
  }

  public aiMeshAnim() : this(AssimpPINVOKE.new_aiMeshAnim(), true) {
  }

  private aiMeshKeyVector GetmKeys() {
    IntPtr cPtr = AssimpPINVOKE.aiMeshAnim_GetmKeys(swigCPtr);
    aiMeshKeyVector ret = (cPtr == IntPtr.Zero) ? null : new aiMeshKeyVector(cPtr, true);
    return ret;
  }

}
