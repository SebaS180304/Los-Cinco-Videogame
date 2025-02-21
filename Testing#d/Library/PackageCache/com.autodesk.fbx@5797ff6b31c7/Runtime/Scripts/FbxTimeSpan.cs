#if UNITY_EDITOR || FBXSDK_RUNTIME
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Autodesk.Fbx {

public class FbxTimeSpan : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxTimeSpan(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxTimeSpan obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxTimeSpan() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativeMethods.delete_FbxTimeSpan(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxTimeSpan() : this(NativeMethods.new_FbxTimeSpan__SWIG_0(), true) {
  }

  public FbxTimeSpan(FbxTime pStart, FbxTime pStop) : this(NativeMethods.new_FbxTimeSpan__SWIG_1(FbxTime.getCPtr(pStart), FbxTime.getCPtr(pStop)), true) {
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void Set(FbxTime pStart, FbxTime pStop) {
    NativeMethods.FbxTimeSpan_Set(swigCPtr, FbxTime.getCPtr(pStart), FbxTime.getCPtr(pStop));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetStart(FbxTime pStart) {
    NativeMethods.FbxTimeSpan_SetStart(swigCPtr, FbxTime.getCPtr(pStart));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetStop(FbxTime pStop) {
    NativeMethods.FbxTimeSpan_SetStop(swigCPtr, FbxTime.getCPtr(pStop));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public FbxTime GetStart() {
    FbxTime ret = new FbxTime(NativeMethods.FbxTimeSpan_GetStart(swigCPtr), true);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime GetStop() {
    FbxTime ret = new FbxTime(NativeMethods.FbxTimeSpan_GetStop(swigCPtr), true);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime GetDuration() {
    FbxTime ret = new FbxTime(NativeMethods.FbxTimeSpan_GetDuration(swigCPtr), true);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime GetSignedDuration() {
    FbxTime ret = new FbxTime(NativeMethods.FbxTimeSpan_GetSignedDuration(swigCPtr), true);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetDirection() {
    int ret = NativeMethods.FbxTimeSpan_GetDirection(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsInside(FbxTime pTime) {
    bool ret = NativeMethods.FbxTimeSpan_IsInside(swigCPtr, FbxTime.getCPtr(pTime));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTimeSpan Intersect(FbxTimeSpan pTime) {
    FbxTimeSpan ret = new FbxTimeSpan(NativeMethods.FbxTimeSpan_Intersect(swigCPtr, FbxTimeSpan.getCPtr(pTime)), true);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _equals(FbxTimeSpan pTime) {
    bool ret = NativeMethods.FbxTimeSpan__equals(swigCPtr, FbxTimeSpan.getCPtr(pTime));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void UnionAssignment(FbxTimeSpan pSpan, int pDirection) {
    NativeMethods.FbxTimeSpan_UnionAssignment__SWIG_0(swigCPtr, FbxTimeSpan.getCPtr(pSpan), pDirection);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void UnionAssignment(FbxTimeSpan pSpan) {
    NativeMethods.FbxTimeSpan_UnionAssignment__SWIG_1(swigCPtr, FbxTimeSpan.getCPtr(pSpan));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public bool Equals(FbxTimeSpan other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return _equals(other);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxTimeSpan;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxTimeSpan).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxTimeSpan a, FbxTimeSpan b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxTimeSpan a, FbxTimeSpan b) {
    return !(a == b);
  }

  public override int GetHashCode() {
    long a = GetStart().GetRaw();
    long b = GetStop().GetRaw();
    int hash = (int)a;
    hash = (hash << 9) | (hash >> 23);
    hash ^= (int)(a >> 32);
    hash = (hash << 9) | (hash >> 23);
    hash ^= (int)b;
    hash = (hash << 9) | (hash >> 23);
    hash ^= (int)(b >> 32);
    return hash;
  }

}

}

#endif // UNITY_EDITOR || FBXSDK_RUNTIME