# DotNet-Algorand-SDK
.NET SDK for Algorand

This is not fully functional

Solution contains projects:

Algod REST API SDK

KMD REST API SDK

SAMPLE XAMARIN app:

1) NET 2.0 STANDARD LIBRARY - Xamarin (which has code samples for consuming the REST API SDK 
and one non REST API function, GenerateAccount)

2) ANDROID - Xamarin

3) iOS - Xamarin

These are the functions the need to be written (JavaScript version can be found at: https://github.com/algorand/js-algorand-sdk to reverse engineer from)

x = do these first, they require secret key

algosToMicroalgos

x appendSignMultisigTransaction

assignGroupID

computeGroupID

decodeObj

encodeObj

x generateAccount (sample done for C#)

isValidAddress

makeAssetConfigTxn

makeAssetCreateTxn

makeAssetDestroyTxn

makeAssetFreezeTxn

makeAssetTransferTxn

makeKeyRegistrationTxn

x Lsig.sign

makeLogicSig

makePaymentTxn

x masterDerivationKeyToMnemonic

mergeMultisigTransactions

microalgosToAlgos

x mnemonicToMasterDerivationKey

x mnemonicToSecretKey

multisigAddress

x secretKeyToMnemonic

x signBid

x signBytes

x signLogicSigTransaction

x signMultisigTransaction

x signTransaction

verifyBytes

