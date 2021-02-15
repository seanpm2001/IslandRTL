﻿'''<summary>The DOM CompositionEvent represents events that occur due to the user indirectly entering text.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [CompositionEvent]
  '''<summary>Returns the characters generated by the input method that raised the event; its varies depending on the type of event that generated the CompositionEvent object.</summary>
  ReadOnly Property [data] As Dynamic
End Interface