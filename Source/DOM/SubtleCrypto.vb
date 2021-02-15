﻿'''<summary>The SubtleCrypto interface of the Web Crypto API provides a number of low-level cryptographic functions. Access to the features of SubtleCrypto is obtained through the subtle property of the Crypto object you get from Window.crypto.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [SubtleCrypto]
  '''<summary>Returns a Promise that fufills with the encrypted data corresponding to the clear text, algorithm, and key given as parameters.</summary>
  Function [encrypt]() As Dynamic
  '''<summary>Returns a Promise that fulfills with the clear data corresponding to the encrypted text, algorithm, and key given as parameters.</summary>
  Function [decrypt]() As Dynamic
  '''<summary>Returns a Promise that fulfills with the signature corresponding to the text, algorithm, and key given as parameters.</summary>
  Function [sign]() As Dynamic
  '''<summary>Returns a Promise that fulfills with a Boolean value indicating if the signature given as a parameter matches the text, algorithm, and key that are also given as parameters.</summary>
  Function [verify]() As Boolean
  '''<summary>Returns a Promise that fulfills with a digest generated from the algorithm and text given as parameters.</summary>
  Function [digest]() As Dynamic
  '''<summary>Returns a Promise that fulfills with a newly-generated CryptoKey, for symmetrical algorithms, or a CryptoKeyPair, containing two newly generated keys, for asymmetrical algorithms. These will match the algorithm, usages, and extractability given as parameters.</summary>
  Function [generateKey]() As Dynamic
  '''<summary>Returns a Promise that fulfills with a newly generated CryptoKey derived from the master key and specific algorithm given as parameters.</summary>
  Function [deriveKey]() As Dynamic
  '''<summary>Returns a Promise that fulfills with a newly generated buffer of pseudo-random bits derived from the master key and specific algorithm given as parameters.</summary>
  Function [deriveBits]() As Dynamic
  '''<summary>Returns a Promise that fulfills with a CryptoKey corresponding to the format, the algorithm, raw key data, usages, and extractability given as parameters.</summary>
  Function [importKey]() As Dynamic
  '''<summary>Returns a Promise that fulfills with a buffer containing the key in the requested format.</summary>
  Function [exportKey]() As Dynamic
  '''<summary>Returns a Promise that fulfills with a wrapped symmetric key for usage (transfer and storage) in insecure environments. The wrapped key matches the format specified in the given parameters, and wrapping is done by the given wrapping key, using the specified algorithm.</summary>
  Function [wrapKey]() As Dynamic
  '''<summary>Returns a Promise that fulfills with a CryptoKey corresponding to the wrapped key given in the parameter.</summary>
  Function [unwrapKey]() As Dynamic
End Interface