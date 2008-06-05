/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.35
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace FreeSWITCH.Native {

using System;
using System.Runtime.InteropServices;

public class switch_io_event_hook_write_frame : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal switch_io_event_hook_write_frame(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(switch_io_event_hook_write_frame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~switch_io_event_hook_write_frame() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        freeswitchPINVOKE.delete_switch_io_event_hook_write_frame(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_f_p_switch_core_session_p_switch_frame_unsigned_long_int__switch_status_t write_frame {
    set {
      freeswitchPINVOKE.switch_io_event_hook_write_frame_write_frame_set(swigCPtr, SWIGTYPE_p_f_p_switch_core_session_p_switch_frame_unsigned_long_int__switch_status_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = freeswitchPINVOKE.switch_io_event_hook_write_frame_write_frame_get(swigCPtr);
      SWIGTYPE_p_f_p_switch_core_session_p_switch_frame_unsigned_long_int__switch_status_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_switch_core_session_p_switch_frame_unsigned_long_int__switch_status_t(cPtr, false);
      return ret;
    } 
  }

  public switch_io_event_hook_write_frame next {
    set {
      freeswitchPINVOKE.switch_io_event_hook_write_frame_next_set(swigCPtr, switch_io_event_hook_write_frame.getCPtr(value));
    } 
    get {
      IntPtr cPtr = freeswitchPINVOKE.switch_io_event_hook_write_frame_next_get(swigCPtr);
      switch_io_event_hook_write_frame ret = (cPtr == IntPtr.Zero) ? null : new switch_io_event_hook_write_frame(cPtr, false);
      return ret;
    } 
  }

  public switch_io_event_hook_write_frame() : this(freeswitchPINVOKE.new_switch_io_event_hook_write_frame(), true) {
  }

}

}
