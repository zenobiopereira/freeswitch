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

public class switch_caller_profile : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal switch_caller_profile(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(switch_caller_profile obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~switch_caller_profile() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        freeswitchPINVOKE.delete_switch_caller_profile(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public string username {
    set {
      freeswitchPINVOKE.switch_caller_profile_username_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_username_get(swigCPtr);
      return ret;
    } 
  }

  public string dialplan {
    set {
      freeswitchPINVOKE.switch_caller_profile_dialplan_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_dialplan_get(swigCPtr);
      return ret;
    } 
  }

  public string caller_id_name {
    set {
      freeswitchPINVOKE.switch_caller_profile_caller_id_name_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_caller_id_name_get(swigCPtr);
      return ret;
    } 
  }

  public string caller_id_number {
    set {
      freeswitchPINVOKE.switch_caller_profile_caller_id_number_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_caller_id_number_get(swigCPtr);
      return ret;
    } 
  }

  public byte caller_ton {
    set {
      freeswitchPINVOKE.switch_caller_profile_caller_ton_set(swigCPtr, value);
    } 
    get {
      byte ret = freeswitchPINVOKE.switch_caller_profile_caller_ton_get(swigCPtr);
      return ret;
    } 
  }

  public byte caller_numplan {
    set {
      freeswitchPINVOKE.switch_caller_profile_caller_numplan_set(swigCPtr, value);
    } 
    get {
      byte ret = freeswitchPINVOKE.switch_caller_profile_caller_numplan_get(swigCPtr);
      return ret;
    } 
  }

  public string network_addr {
    set {
      freeswitchPINVOKE.switch_caller_profile_network_addr_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_network_addr_get(swigCPtr);
      return ret;
    } 
  }

  public string ani {
    set {
      freeswitchPINVOKE.switch_caller_profile_ani_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_ani_get(swigCPtr);
      return ret;
    } 
  }

  public byte ani_ton {
    set {
      freeswitchPINVOKE.switch_caller_profile_ani_ton_set(swigCPtr, value);
    } 
    get {
      byte ret = freeswitchPINVOKE.switch_caller_profile_ani_ton_get(swigCPtr);
      return ret;
    } 
  }

  public byte ani_numplan {
    set {
      freeswitchPINVOKE.switch_caller_profile_ani_numplan_set(swigCPtr, value);
    } 
    get {
      byte ret = freeswitchPINVOKE.switch_caller_profile_ani_numplan_get(swigCPtr);
      return ret;
    } 
  }

  public string aniii {
    set {
      freeswitchPINVOKE.switch_caller_profile_aniii_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_aniii_get(swigCPtr);
      return ret;
    } 
  }

  public string rdnis {
    set {
      freeswitchPINVOKE.switch_caller_profile_rdnis_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_rdnis_get(swigCPtr);
      return ret;
    } 
  }

  public byte rdnis_ton {
    set {
      freeswitchPINVOKE.switch_caller_profile_rdnis_ton_set(swigCPtr, value);
    } 
    get {
      byte ret = freeswitchPINVOKE.switch_caller_profile_rdnis_ton_get(swigCPtr);
      return ret;
    } 
  }

  public byte rdnis_numplan {
    set {
      freeswitchPINVOKE.switch_caller_profile_rdnis_numplan_set(swigCPtr, value);
    } 
    get {
      byte ret = freeswitchPINVOKE.switch_caller_profile_rdnis_numplan_get(swigCPtr);
      return ret;
    } 
  }

  public string destination_number {
    set {
      freeswitchPINVOKE.switch_caller_profile_destination_number_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_destination_number_get(swigCPtr);
      return ret;
    } 
  }

  public byte destination_number_ton {
    set {
      freeswitchPINVOKE.switch_caller_profile_destination_number_ton_set(swigCPtr, value);
    } 
    get {
      byte ret = freeswitchPINVOKE.switch_caller_profile_destination_number_ton_get(swigCPtr);
      return ret;
    } 
  }

  public byte destination_number_numplan {
    set {
      freeswitchPINVOKE.switch_caller_profile_destination_number_numplan_set(swigCPtr, value);
    } 
    get {
      byte ret = freeswitchPINVOKE.switch_caller_profile_destination_number_numplan_get(swigCPtr);
      return ret;
    } 
  }

  public string source {
    set {
      freeswitchPINVOKE.switch_caller_profile_source_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_source_get(swigCPtr);
      return ret;
    } 
  }

  public string chan_name {
    set {
      freeswitchPINVOKE.switch_caller_profile_chan_name_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_chan_name_get(swigCPtr);
      return ret;
    } 
  }

  public string uuid {
    set {
      freeswitchPINVOKE.switch_caller_profile_uuid_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_uuid_get(swigCPtr);
      return ret;
    } 
  }

  public string context {
    set {
      freeswitchPINVOKE.switch_caller_profile_context_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_context_get(swigCPtr);
      return ret;
    } 
  }

  public string profile_index {
    set {
      freeswitchPINVOKE.switch_caller_profile_profile_index_set(swigCPtr, value);
    } 
    get {
      string ret = freeswitchPINVOKE.switch_caller_profile_profile_index_get(swigCPtr);
      return ret;
    } 
  }

  public uint flags {
    set {
      freeswitchPINVOKE.switch_caller_profile_flags_set(swigCPtr, value);
    } 
    get {
      uint ret = freeswitchPINVOKE.switch_caller_profile_flags_get(swigCPtr);
      return ret;
    } 
  }

  public switch_caller_profile originator_caller_profile {
    set {
      freeswitchPINVOKE.switch_caller_profile_originator_caller_profile_set(swigCPtr, switch_caller_profile.getCPtr(value));
    } 
    get {
      IntPtr cPtr = freeswitchPINVOKE.switch_caller_profile_originator_caller_profile_get(swigCPtr);
      switch_caller_profile ret = (cPtr == IntPtr.Zero) ? null : new switch_caller_profile(cPtr, false);
      return ret;
    } 
  }

  public switch_caller_profile originatee_caller_profile {
    set {
      freeswitchPINVOKE.switch_caller_profile_originatee_caller_profile_set(swigCPtr, switch_caller_profile.getCPtr(value));
    } 
    get {
      IntPtr cPtr = freeswitchPINVOKE.switch_caller_profile_originatee_caller_profile_get(swigCPtr);
      switch_caller_profile ret = (cPtr == IntPtr.Zero) ? null : new switch_caller_profile(cPtr, false);
      return ret;
    } 
  }

  public switch_channel_timetable times {
    set {
      freeswitchPINVOKE.switch_caller_profile_times_set(swigCPtr, switch_channel_timetable.getCPtr(value));
    } 
    get {
      IntPtr cPtr = freeswitchPINVOKE.switch_caller_profile_times_get(swigCPtr);
      switch_channel_timetable ret = (cPtr == IntPtr.Zero) ? null : new switch_channel_timetable(cPtr, false);
      return ret;
    } 
  }

  public switch_caller_extension caller_extension {
    set {
      freeswitchPINVOKE.switch_caller_profile_caller_extension_set(swigCPtr, switch_caller_extension.getCPtr(value));
    } 
    get {
      IntPtr cPtr = freeswitchPINVOKE.switch_caller_profile_caller_extension_get(swigCPtr);
      switch_caller_extension ret = (cPtr == IntPtr.Zero) ? null : new switch_caller_extension(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_apr_pool_t pool {
    set {
      freeswitchPINVOKE.switch_caller_profile_pool_set(swigCPtr, SWIGTYPE_p_apr_pool_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = freeswitchPINVOKE.switch_caller_profile_pool_get(swigCPtr);
      SWIGTYPE_p_apr_pool_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_apr_pool_t(cPtr, false);
      return ret;
    } 
  }

  public switch_caller_profile next {
    set {
      freeswitchPINVOKE.switch_caller_profile_next_set(swigCPtr, switch_caller_profile.getCPtr(value));
    } 
    get {
      IntPtr cPtr = freeswitchPINVOKE.switch_caller_profile_next_get(swigCPtr);
      switch_caller_profile ret = (cPtr == IntPtr.Zero) ? null : new switch_caller_profile(cPtr, false);
      return ret;
    } 
  }

  public switch_caller_profile() : this(freeswitchPINVOKE.new_switch_caller_profile(), true) {
  }

}

}
