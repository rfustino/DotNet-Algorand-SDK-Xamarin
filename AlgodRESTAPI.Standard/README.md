# Getting started

API Endpoint for AlgoD Operations.

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (AlgodRESTAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Algod%20REST%20API.-CSharp&workspaceName=AlgodRESTAPI&projectName=AlgodRESTAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the AlgodRESTAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Algod%20REST%20API.-CSharp&workspaceName=AlgodRESTAPI&projectName=AlgodRESTAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Algod%20REST%20API.-CSharp&workspaceName=AlgodRESTAPI&projectName=AlgodRESTAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Algod%20REST%20API.-CSharp&workspaceName=AlgodRESTAPI&projectName=AlgodRESTAPI.Standard)

### 3. Add reference of the library project

In order to use the AlgodRESTAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Algod%20REST%20API.-CSharp&workspaceName=AlgodRESTAPI&projectName=AlgodRESTAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` AlgodRESTAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```AlgodRESTAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Algod%20REST%20API.-CSharp&workspaceName=AlgodRESTAPI&projectName=AlgodRESTAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Algod%20REST%20API.-CSharp&workspaceName=AlgodRESTAPI&projectName=AlgodRESTAPI.Standard)

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
| xAlgoAPIToken | Generated header parameter. This token can be generated using the Goal command line tool. Example value ='b7e384d0317b8050ce45900a94a1931e28540e1f69b2d242b424659c341b4697' |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string xAlgoAPIToken = "xAlgoAPIToken"; // Generated header parameter. This token can be generated using the Goal command line tool. Example value ='b7e384d0317b8050ce45900a94a1931e28540e1f69b2d242b424659c341b4697'

AlgodRESTAPIClient client = new AlgodRESTAPIClient(xAlgoAPIToken);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [APIController](#api_controller)

## <a name="api_controller"></a>![Class: ](https://apidocs.io/img/class.png "AlgodRESTAPI.Standard.Controllers.APIController") APIController

### Get singleton instance

The singleton instance of the ``` APIController ``` class can be accessed from the API Client.

```csharp
APIController client = client.Client;
```

### <a name="get_health_check"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetHealthCheck") GetHealthCheck

> Returns OK if healthy.


```csharp
Task GetHealthCheck()
```

#### Example Usage

```csharp

await client.GetHealthCheck();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Invalid API Token |
| 404 | Not Found |
| 0 | Unknown Error |


### <a name="get_metrics"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetMetrics") GetMetrics

> Return metrics about algod functioning.


```csharp
Task GetMetrics()
```

#### Example Usage

```csharp

await client.GetMetrics();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | metrics were compiled out |


### <a name="get_swagger_json"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetSwaggerJSON") GetSwaggerJSON

> Returns the entire swagger spec in json.


```csharp
Task<string> GetSwaggerJSON()
```

#### Example Usage

```csharp

string result = await client.GetSwaggerJSON();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unknown Error |


### <a name="get_account_information"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetAccountInformation") GetAccountInformation

> Given a specific account public key, this call returns the accounts status, balance and spendable amounts


```csharp
Task<Models.Account> GetAccountInformation(string address)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| address |  ``` Required ```  | An account public key |


#### Example Usage

```csharp
string address = "address";

Models.Account result = await client.GetAccountInformation(address);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Invalid API Token |
| 500 | Internal Error |
| 0 | Unknown Error |


### <a name="get_transaction_information"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetTransactionInformation") GetTransactionInformation

> Given a wallet address and a transaction id, it returns the confirmed transaction information. This call scans up to <CurrentProtocol>.MaxTxnLife blocks in the past.
> 


```csharp
Task<Models.Transaction> GetTransactionInformation(string address, string txid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| address |  ``` Required ```  | An account public key |
| txid |  ``` Required ```  | A transaction id |


#### Example Usage

```csharp
string address = "address";
string txid = "txid";

Models.Transaction result = await client.GetTransactionInformation(address, txid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Invalid API Token |
| 404 | Transaction Not Found |
| 0 | Unknown Error |


### <a name="get_transactions"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetTransactions") GetTransactions

> Returns the list of confirmed transactions between within a date range. This call is available only when the indexer is running.


```csharp
Task<Models.TransactionList> GetTransactions(
        string address,
        long? firstRound = null,
        long? lastRound = null,
        DateTime? fromDate = null,
        DateTime? toDate = null,
        long? max = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| address |  ``` Required ```  | An account public key |
| firstRound |  ``` Optional ```  | Do not fetch any transactions before this round. |
| lastRound |  ``` Optional ```  | Do not fetch any transactions after this round. |
| fromDate |  ``` Optional ```  | Do not fetch any transactions before this date. (enabled only with indexer) |
| toDate |  ``` Optional ```  | Do not fetch any transactions after this date. (enabled only with indexer) |
| max |  ``` Optional ```  | maximum transactions to show (default to 100) |


#### Example Usage

```csharp
string address = "address";
long? firstRound = 101;
long? lastRound = 101;
DateTime? fromDate = DateTime.Now();
DateTime? toDate = DateTime.Now();
long? max = 101;

Models.TransactionList result = await client.GetTransactions(address, firstRound, lastRound, fromDate, toDate, max);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Invalid API Token |
| 500 | Internal Error |
| 0 | Unknown Error |


### <a name="get_pending_transactions_by_address"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetPendingTransactionsByAddress") GetPendingTransactionsByAddress

> Get the list of pending transactions by address, sorted by priority, in decreasing order, truncated at the end at MAX. If MAX = 0, returns all pending transactions.
> 


```csharp
Task<Models.PendingTransactions> GetPendingTransactionsByAddress(string addr, long? max = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addr |  ``` Required ```  | An account public key |
| max |  ``` Optional ```  | Truncated number of transactions to display. If max=0, returns all pending txns. |


#### Example Usage

```csharp
string addr = "addr";
long? max = 101;

Models.PendingTransactions result = await client.GetPendingTransactionsByAddress(addr, max);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Invalid API Token |
| 500 | Internal Error |
| 0 | Unknown Error |


### <a name="get_asset_information"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetAssetInformation") GetAssetInformation

> Given the asset's unique index, this call returns the asset's creator, manager, reserve, freeze, and clawback addresses
> 


```csharp
Task<Models.AssetParamsSpecifiesTheParametersForAnAsset> GetAssetInformation(long index)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| index |  ``` Required ```  | Asset index |


#### Example Usage

```csharp
long index = 101;

Models.AssetParamsSpecifiesTheParametersForAnAsset result = await client.GetAssetInformation(index);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Invalid API Token |
| 500 | Internal Error |
| 0 | Unknown Error |


### <a name="get_assets"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetAssets") GetAssets

> Returns list of up to `max` assets, where the maximum assetIdx is <= `assetIdx`


```csharp
Task<Models.AssetList> GetAssets(long? assetIdx = null, long? max = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| assetIdx |  ``` Optional ```  | Fetch assets with asset index <= assetIdx. If zero, fetch most recent assets. |
| max |  ``` Optional ```  | Fetch no more than this many assets |


#### Example Usage

```csharp
long? assetIdx = 101;
long? max = 101;

Models.AssetList result = await client.GetAssets(assetIdx, max);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Invalid API Token |
| 500 | Internal Error |
| 0 | Unknown Error |


### <a name="get_block"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetBlock") GetBlock

> Get the block for the given round.


```csharp
Task<Models.Block> GetBlock(long round)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| round |  ``` Required ```  | The round from which to fetch block information. |


#### Example Usage

```csharp
long round = 101;

Models.Block result = await client.GetBlock(round);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Invalid API Token |
| 500 | Internal Error |
| 0 | Unknown Error |


### <a name="get_supply"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetSupply") GetSupply

> Get the current supply reported by the ledger.


```csharp
Task<Models.Supply> GetSupply()
```

#### Example Usage

```csharp

Models.Supply result = await client.GetSupply();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Invalid API Token |
| 0 | Unknown Error |


### <a name="get_status"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetStatus") GetStatus

> Gets the current node status.


```csharp
Task<Models.NodeStatus> GetStatus()
```

#### Example Usage

```csharp

Models.NodeStatus result = await client.GetStatus();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Invalid API Token |
| 500 | Internal Error |
| 0 | Unknown Error |


### <a name="get_wait_for_block"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetWaitForBlock") GetWaitForBlock

> Waits for a block to appear after round {round} and returns the node's status at the time.


```csharp
Task<Models.NodeStatus> GetWaitForBlock(long round)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| round |  ``` Required ```  | The round to wait until returning status |


#### Example Usage

```csharp
long round = 101;

Models.NodeStatus result = await client.GetWaitForBlock(round);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Invalid API Token |
| 500 | Internal Error |
| 0 | Unknown Error |


### <a name="get_transaction"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetTransaction") GetTransaction

> Returns the transaction information of the given txid. Works only if the indexer is enabled.


```csharp
Task<Models.Transaction> GetTransaction(string txid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| txid |  ``` Required ```  | A transaction id |


#### Example Usage

```csharp
string txid = "txid";

Models.Transaction result = await client.GetTransaction(txid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Invalid API Token |
| 404 | Transaction Not Found |
| 0 | Unknown Error |


### <a name="create_raw_transaction"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.CreateRawTransaction") CreateRawTransaction

> Broadcasts a raw transaction to the network.


```csharp
Task<Models.TransactionID> CreateRawTransaction(FileStreamInfo rawtxn)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| rawtxn |  ``` Required ```  | The byte encoded signed transaction to broadcast to network |


#### Example Usage

```csharp
FileStreamInfo rawtxn = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));

Models.TransactionID result = await client.CreateRawTransaction(rawtxn);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Invalid API Token |
| 500 | Internal Error |
| 0 | Unknown Error |


### <a name="get_suggested_fee"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetSuggestedFee") GetSuggestedFee

> Suggested Fee is returned in units of micro-Algos per byte. Suggested Fee may fall to zero but submitted transactions must still have a fee of at least MinTxnFee for the current network protocol.
> 


```csharp
Task<Models.TransactionFee> GetSuggestedFee()
```

#### Example Usage

```csharp

Models.TransactionFee result = await client.GetSuggestedFee();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Invalid API Token |
| 0 | Unknown Error |


### <a name="get_transaction_params"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetTransactionParams") GetTransactionParams

> Get parameters for constructing a new transaction


```csharp
Task<Models.TransactionParams> GetTransactionParams()
```

#### Example Usage

```csharp

Models.TransactionParams result = await client.GetTransactionParams();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Invalid API Token |
| 0 | Unknown Error |


### <a name="get_pending_transactions"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetPendingTransactions") GetPendingTransactions

> Get the list of pending transactions, sorted by priority, in decreasing order, truncated at the end at MAX. If MAX = 0, returns all pending transactions.
> 


```csharp
Task<Models.PendingTransactions> GetPendingTransactions(long? max = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| max |  ``` Optional ```  | Truncated number of transactions to display. If max=0, returns all pending txns. |


#### Example Usage

```csharp
long? max = 101;

Models.PendingTransactions result = await client.GetPendingTransactions(max);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Invalid API Token |
| 500 | Internal Error |
| 0 | Unknown Error |


### <a name="get_pending_transaction_information"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetPendingTransactionInformation") GetPendingTransactionInformation

> Given a transaction id of a recently submitted transaction, it returns information about it.  There are several cases when this might succeed:
> - transaction committed (committed round > 0) - transaction still in the pool (committed round = 0, pool error = "") - transaction removed from pool due to error (committed round = 0, pool error != "")
> Or the transaction may have happened sufficiently long ago that the node no longer remembers it, and this will return an error.
> 


```csharp
Task<Models.Transaction> GetPendingTransactionInformation(string txid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| txid |  ``` Required ```  | A transaction id |


#### Example Usage

```csharp
string txid = "txid";

Models.Transaction result = await client.GetPendingTransactionInformation(txid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |
| 401 | Invalid API Token |
| 404 | Transaction Not Found |
| 0 | Unknown Error |


### <a name="get_version"></a>![Method: ](https://apidocs.io/img/method.png "AlgodRESTAPI.Standard.Controllers.APIController.GetVersion") GetVersion

> Retrieves the current version


```csharp
Task<Models.VersionContainsTheCurrentAlgodVersion> GetVersion()
```

#### Example Usage

```csharp

Models.VersionContainsTheCurrentAlgodVersion result = await client.GetVersion();

```


[Back to List of Controllers](#list_of_controllers)



