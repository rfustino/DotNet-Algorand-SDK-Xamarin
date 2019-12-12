# Getting started

API for KMD (Key Management Daemon)

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (ForKMDHTTPAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=for%20KMD%20HTTP%20API-CSharp&workspaceName=ForKMDHTTPAPI&projectName=ForKMDHTTPAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the ForKMDHTTPAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=for%20KMD%20HTTP%20API-CSharp&workspaceName=ForKMDHTTPAPI&projectName=ForKMDHTTPAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=for%20KMD%20HTTP%20API-CSharp&workspaceName=ForKMDHTTPAPI&projectName=ForKMDHTTPAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=for%20KMD%20HTTP%20API-CSharp&workspaceName=ForKMDHTTPAPI&projectName=ForKMDHTTPAPI.Standard)

### 3. Add reference of the library project

In order to use the ForKMDHTTPAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=for%20KMD%20HTTP%20API-CSharp&workspaceName=ForKMDHTTPAPI&projectName=ForKMDHTTPAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` ForKMDHTTPAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```ForKMDHTTPAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=for%20KMD%20HTTP%20API-CSharp&workspaceName=ForKMDHTTPAPI&projectName=ForKMDHTTPAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=for%20KMD%20HTTP%20API-CSharp&workspaceName=ForKMDHTTPAPI&projectName=ForKMDHTTPAPI.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| xKMDAPIToken | Generated header parameter. This value can be found in `/kmd/data/dir/kmd.token`. Example value: '330b2e4fc9b20f4f89812cf87f1dabeb716d23e3f11aec97a61ff5f750563b78' |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string xKMDAPIToken = "xKMDAPIToken"; // Generated header parameter. This value can be found in `/kmd/data/dir/kmd.token`. Example value: '330b2e4fc9b20f4f89812cf87f1dabeb716d23e3f11aec97a61ff5f750563b78'

ForKMDHTTPAPIClient client = new ForKMDHTTPAPIClient(xKMDAPIToken);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [APIController](#api_controller)

## <a name="api_controller"></a>![Class: ](https://apidocs.io/img/class.png "ForKMDHTTPAPI.Standard.Controllers.APIController") APIController

### Get singleton instance

The singleton instance of the ``` APIController ``` class can be accessed from the API Client.

```csharp
APIController client = client.Client;
```

### <a name="get_swagger_handler"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.GetSwaggerHandler") GetSwaggerHandler

> Returns the entire swagger spec in json.


```csharp
Task<string> GetSwaggerHandler()
```

#### Example Usage

```csharp

string result = await client.GetSwaggerHandler();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unknown Error |


### <a name="create_generate_key"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateGenerateKey") CreateGenerateKey

> Generates the next key in the deterministic key sequence (as determined by the master derivation key) and adds it to the wallet, returning the public key.
> 


```csharp
Task<Models.APIV1POSTKeyResponse> CreateGenerateKey(Models.GenerateKeyRequest generateKeyRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| generateKeyRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var generateKeyRequest = new Models.GenerateKeyRequest();

Models.APIV1POSTKeyResponse result = await client.CreateGenerateKey(generateKeyRequest);

```


### <a name="delete_key"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.DeleteKey") DeleteKey

> Deletes the key with the passed public key from the wallet.


```csharp
Task<Models.APIV1DELETEKeyResponse> DeleteKey(Models.DeleteKeyRequest deleteKeyRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| deleteKeyRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var deleteKeyRequest = new Models.DeleteKeyRequest();

Models.APIV1DELETEKeyResponse result = await client.DeleteKey(deleteKeyRequest);

```


### <a name="create_export_key"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateExportKey") CreateExportKey

> Export the secret key associated with the passed public key.


```csharp
Task<Models.APIV1POSTKeyExportResponse> CreateExportKey(Models.ExportKeyRequest exportKeyRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| exportKeyRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var exportKeyRequest = new Models.ExportKeyRequest();

Models.APIV1POSTKeyExportResponse result = await client.CreateExportKey(exportKeyRequest);

```


### <a name="create_import_key"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateImportKey") CreateImportKey

> Import an externally generated key into the wallet. Note that if you wish to back up the imported key, you must do so by backing up the entire wallet database, because imported keys were not derived from the wallet's master derivation key.
> 


```csharp
Task<Models.APIV1POSTKeyImportResponse> CreateImportKey(Models.ImportKeyRequest importKeyRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| importKeyRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var importKeyRequest = new Models.ImportKeyRequest();

Models.APIV1POSTKeyImportResponse result = await client.CreateImportKey(importKeyRequest);

```


### <a name="create_list_keys_in_wallet"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateListKeysInWallet") CreateListKeysInWallet

> Lists all of the public keys in this wallet. All of them have a stored private key.


```csharp
Task<Models.APIV1POSTKeyListResponse> CreateListKeysInWallet(Models.ListKeysRequest listKeysRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| listKeysRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var listKeysRequest = new Models.ListKeysRequest();

Models.APIV1POSTKeyListResponse result = await client.CreateListKeysInWallet(listKeysRequest);

```


### <a name="create_export_master_key"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateExportMasterKey") CreateExportMasterKey

> Export the master derivation key from the wallet. This key is a master "backup" key for the underlying wallet. With it, you can regenerate all of the wallets that have been generated with this wallet's `POST /v1/key` endpoint. This key will not allow you to recover keys imported from other wallets, however.
> 


```csharp
Task<Models.APIV1POSTMasterKeyExportResponse> CreateExportMasterKey(Models.ExportMasterKeyRequest exportMasterKeyRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| exportMasterKeyRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var exportMasterKeyRequest = new Models.ExportMasterKeyRequest();

Models.APIV1POSTMasterKeyExportResponse result = await client.CreateExportMasterKey(exportMasterKeyRequest);

```


### <a name="delete_multisig"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.DeleteMultisig") DeleteMultisig

> Deletes multisig preimage information for the passed address from the wallet.
> 


```csharp
Task<Models.APIV1DELETEMultisigResponse> DeleteMultisig(Models.DeleteMultisigRequest deleteMultisigRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| deleteMultisigRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var deleteMultisigRequest = new Models.DeleteMultisigRequest();

Models.APIV1DELETEMultisigResponse result = await client.DeleteMultisig(deleteMultisigRequest);

```


### <a name="create_export_multisig"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateExportMultisig") CreateExportMultisig

> Given a multisig address whose preimage this wallet stores, returns the information used to generate the address, including public keys, threshold, and multisig version.
> 


```csharp
Task<Models.APIV1POSTMultisigExportResponse> CreateExportMultisig(Models.ExportMultisigRequest exportMultisigRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| exportMultisigRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var exportMultisigRequest = new Models.ExportMultisigRequest();

Models.APIV1POSTMultisigExportResponse result = await client.CreateExportMultisig(exportMultisigRequest);

```


### <a name="create_import_multisig"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateImportMultisig") CreateImportMultisig

> Generates a multisig account from the passed public keys array and multisig metadata, and stores all of this in the wallet.
> 


```csharp
Task<Models.APIV1POSTMultisigImportResponse> CreateImportMultisig(Models.ImportMultisigRequest importMultisigRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| importMultisigRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var importMultisigRequest = new Models.ImportMultisigRequest();

Models.APIV1POSTMultisigImportResponse result = await client.CreateImportMultisig(importMultisigRequest);

```


### <a name="create_list_multisg"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateListMultisg") CreateListMultisg

> Lists all of the multisig accounts whose preimages this wallet stores


```csharp
Task<Models.APIV1POSTMultisigListResponse> CreateListMultisg(Models.ListMultisigRequest listMultisigRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| listMultisigRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var listMultisigRequest = new Models.ListMultisigRequest();

Models.APIV1POSTMultisigListResponse result = await client.CreateListMultisg(listMultisigRequest);

```


### <a name="create_sign_multisig_transaction"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateSignMultisigTransaction") CreateSignMultisigTransaction

> Start a multisig signature, or add a signature to a partially completed multisig signature object.
> 


```csharp
Task<Models.APIV1POSTMultisigTransactionSignResponse> CreateSignMultisigTransaction(Models.SignMultisigRequest signMultisigTransactionRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| signMultisigTransactionRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var signMultisigTransactionRequest = new Models.SignMultisigRequest();

Models.APIV1POSTMultisigTransactionSignResponse result = await client.CreateSignMultisigTransaction(signMultisigTransactionRequest);

```


### <a name="create_sign_multisig_program"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateSignMultisigProgram") CreateSignMultisigProgram

> Start a multisig signature, or add a signature to a partially completed multisig signature object.
> 


```csharp
Task<Models.APIV1POSTMultisigProgramSignResponse> CreateSignMultisigProgram(Models.SignProgramMultisigRequest signMultisigProgramRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| signMultisigProgramRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var signMultisigProgramRequest = new Models.SignProgramMultisigRequest();

Models.APIV1POSTMultisigProgramSignResponse result = await client.CreateSignMultisigProgram(signMultisigProgramRequest);

```


### <a name="create_sign_program"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateSignProgram") CreateSignProgram

> Signs the passed program with a key from the wallet, determined by the account named in the request.
> 


```csharp
Task<Models.APIV1POSTProgramSignResponse> CreateSignProgram(Models.SignProgramRequest signProgramRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| signProgramRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var signProgramRequest = new Models.SignProgramRequest();

Models.APIV1POSTProgramSignResponse result = await client.CreateSignProgram(signProgramRequest);

```


### <a name="create_sign_transaction"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateSignTransaction") CreateSignTransaction

> Signs the passed transaction with a key from the wallet, determined by the sender encoded in the transaction.
> 


```csharp
Task<Models.APIV1POSTTransactionSignResponse> CreateSignTransaction(Models.SignTransactionRequest signTransactionRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| signTransactionRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var signTransactionRequest = new Models.SignTransactionRequest();

Models.APIV1POSTTransactionSignResponse result = await client.CreateSignTransaction(signTransactionRequest);

```


### <a name="create_wallet"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateWallet") CreateWallet

> Create a new wallet (collection of keys) with the given parameters.


```csharp
Task<Models.APIV1POSTWalletResponse> CreateWallet(Models.CreateWalletRequest createWalletRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| createWalletRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var createWalletRequest = new Models.CreateWalletRequest();

Models.APIV1POSTWalletResponse result = await client.CreateWallet(createWalletRequest);

```


### <a name="create_get_wallet_info"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateGetWalletInfo") CreateGetWalletInfo

> Returns information about the wallet associated with the passed wallet handle token. Additionally returns expiration information about the token itself.
> 


```csharp
Task<Models.APIV1POSTWalletInfoResponse> CreateGetWalletInfo(Models.WalletInfoRequest getWalletInfoRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| getWalletInfoRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var getWalletInfoRequest = new Models.WalletInfoRequest();

Models.APIV1POSTWalletInfoResponse result = await client.CreateGetWalletInfo(getWalletInfoRequest);

```


### <a name="create_init_wallet_handle_token"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateInitWalletHandleToken") CreateInitWalletHandleToken

> Unlock the wallet and return a wallet handle token that can be used for subsequent operations. These tokens expire periodically and must be renewed. You can `POST` the token to `/v1/wallet/info` to see how much time remains until expiration, and renew it with `/v1/wallet/renew`. When you're done, you can invalidate the token with `/v1/wallet/release`.
> 


```csharp
Task<Models.APIV1POSTWalletInitResponse> CreateInitWalletHandleToken(Models.InitWalletHandleTokenRequest initializeWalletHandleTokenRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| initializeWalletHandleTokenRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var initializeWalletHandleTokenRequest = new Models.InitWalletHandleTokenRequest();

Models.APIV1POSTWalletInitResponse result = await client.CreateInitWalletHandleToken(initializeWalletHandleTokenRequest);

```


### <a name="create_release_wallet_handle_token"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateReleaseWalletHandleToken") CreateReleaseWalletHandleToken

> Invalidate the passed wallet handle token, making it invalid for use in subsequent requests.


```csharp
Task<Models.APIV1POSTWalletReleaseResponse> CreateReleaseWalletHandleToken(Models.ReleaseWalletHandleTokenRequest releaseWalletHandleTokenRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| releaseWalletHandleTokenRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var releaseWalletHandleTokenRequest = new Models.ReleaseWalletHandleTokenRequest();

Models.APIV1POSTWalletReleaseResponse result = await client.CreateReleaseWalletHandleToken(releaseWalletHandleTokenRequest);

```


### <a name="create_rename_wallet"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateRenameWallet") CreateRenameWallet

> Rename the underlying wallet to something else


```csharp
Task<Models.APIV1POSTWalletRenameResponse> CreateRenameWallet(Models.RenameWalletRequest renameWalletRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| renameWalletRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var renameWalletRequest = new Models.RenameWalletRequest();

Models.APIV1POSTWalletRenameResponse result = await client.CreateRenameWallet(renameWalletRequest);

```


### <a name="create_renew_wallet_handle_token"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.CreateRenewWalletHandleToken") CreateRenewWalletHandleToken

> Renew a wallet handle token, increasing its expiration duration to its initial value


```csharp
Task<Models.APIV1POSTWalletRenewResponse> CreateRenewWalletHandleToken(Models.RenewWalletHandleTokenRequest renewWalletHandleTokenRequest)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| renewWalletHandleTokenRequest |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var renewWalletHandleTokenRequest = new Models.RenewWalletHandleTokenRequest();

Models.APIV1POSTWalletRenewResponse result = await client.CreateRenewWalletHandleToken(renewWalletHandleTokenRequest);

```


### <a name="list_wallets"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.ListWallets") ListWallets

> Lists all of the wallets that kmd is aware of.


```csharp
Task<Models.APIV1GETWalletsResponse> ListWallets()
```

#### Example Usage

```csharp

Models.APIV1GETWalletsResponse result = await client.ListWallets();

```


### <a name="get_version"></a>![Method: ](https://apidocs.io/img/method.png "ForKMDHTTPAPI.Standard.Controllers.APIController.GetVersion") GetVersion

> Retrieves the current version


```csharp
Task<Models.VersionsResponse> GetVersion()
```

#### Example Usage

```csharp

Models.VersionsResponse result = await client.GetVersion();

```


[Back to List of Controllers](#list_of_controllers)



