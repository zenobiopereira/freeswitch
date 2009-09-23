/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.35
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ESLconnection : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ESLconnection(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ESLconnection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ESLconnection() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        ESLPINVOKE.delete_ESLconnection(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public ESLconnection(string host, string port, string password) : this(ESLPINVOKE.new_ESLconnection__SWIG_0(host, port, password), true) {
  }

  public ESLconnection(int socket) : this(ESLPINVOKE.new_ESLconnection__SWIG_1(socket), true) {
  }

  public int socketDescriptor() {
    int ret = ESLPINVOKE.ESLconnection_socketDescriptor(swigCPtr);
    return ret;
  }

  public int connected() {
    int ret = ESLPINVOKE.ESLconnection_connected(swigCPtr);
    return ret;
  }

  public ESLevent getInfo() {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_getInfo(swigCPtr);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public int send(string cmd) {
    int ret = ESLPINVOKE.ESLconnection_send(swigCPtr, cmd);
    return ret;
  }

  public ESLevent sendRecv(string cmd) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_sendRecv(swigCPtr, cmd);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public ESLevent api(string cmd, string arg) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_api(swigCPtr, cmd, arg);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public ESLevent bgapi(string cmd, string arg) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_bgapi(swigCPtr, cmd, arg);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public int sendEvent(ESLevent send_me) {
    int ret = ESLPINVOKE.ESLconnection_sendEvent(swigCPtr, ESLevent.getCPtr(send_me));
    return ret;
  }

  public ESLevent recvEvent() {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_recvEvent(swigCPtr);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public ESLevent recvEventTimed(int ms) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_recvEventTimed(swigCPtr, ms);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public ESLevent filter(string header, string value) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_filter(swigCPtr, header, value);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public int events(string etype, string value) {
    int ret = ESLPINVOKE.ESLconnection_events(swigCPtr, etype, value);
    return ret;
  }

  public int execute(string app, string arg, string uuid) {
    int ret = ESLPINVOKE.ESLconnection_execute(swigCPtr, app, arg, uuid);
    return ret;
  }

  public int executeAsync(string app, string arg, string uuid) {
    int ret = ESLPINVOKE.ESLconnection_executeAsync(swigCPtr, app, arg, uuid);
    return ret;
  }

  public int setAsyncExecute(string val) {
    int ret = ESLPINVOKE.ESLconnection_setAsyncExecute(swigCPtr, val);
    return ret;
  }

  public int setEventLock(string val) {
    int ret = ESLPINVOKE.ESLconnection_setEventLock(swigCPtr, val);
    return ret;
  }

  public int disconnect() {
    int ret = ESLPINVOKE.ESLconnection_disconnect(swigCPtr);
    return ret;
  }

}
