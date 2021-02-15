﻿'''<summary>An instance of the WebRTC API's RTCRtpEncodingParameters dictionary describes a single configuration of a codec for an RTCRtpSender.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [RTCRtpEncodingParameters]
  '''<summary>If true, the described encoding is currently actively being used. That is, for RTP senders, the encoding is currently being used to send data, while for receivers, the encoding is being used to decode received data. The default value is true.</summary>
  Property [active] As Boolean
  '''<summary>When describing a codec for an RTCRtpSender, codecPayloadType is a single 8-bit byte (or octet) specifying the codec to use for sending the stream; the value matches one from the owning RTCRtpParameters object's codecs parameter. This value can only be set when creating the transceiver; after that, this value is read only.</summary>
  Property [codecPayloadType] As Dynamic
  '''<summary>Only used for an RTCRtpSender whose kind is audio, this property indicates whether or not to use discontinuous transmission (a feature by which a phone is turned off or the microphone muted automatically in the absence of voice activity). The value is taken from the enumerated string type RTCDtxStatus.</summary>
  Property [dtx] As String
  '''<summary>An unsigned long integer indicating the maximum number of bits per second to allow for this encoding. Other parameters may further constrain the bit rate, such as the value of maxFramerate or transport or physical network limitations.</summary>
  Property [maxBitrate] As ULong
  '''<summary>A double-precision floating-point value specifying the maximum number of frames per second to allow for this encoding.</summary>
  Property [maxFramerate] As Double
  '''<summary>An unsigned long integer value indicating the preferred duration of a media packet in milliseconds. This is typically only relevant for audio encodings. The user agent will try to match this as well as it can, but there is no guarantee.</summary>
  Property [ptime] As DateTime
  '''<summary>A DOMString which, if set, specifies an RTP stream ID (RID) to be sent using the RID header extension. This parameter cannot be modified using setParameters(). Its value can only be set when the transceiver is first created.</summary>
  Property [rid] As Integer
  '''<summary>Only used for senders whose track's kind is video, this is a double-precision floating-point value specifying a factor by which to scale down the video during encoding. The default value, 1.0, means that the sent video's size will be the same as the original. A value of 2.0 scales the video frames down by a factor of 2 in each dimension, resulting in a video 1/4 the size of the original. The value must not be less than 1.0 (you can't use this to scale the video up).</summary>
  Property [scaleResolutionDownBy] As Double
End Interface