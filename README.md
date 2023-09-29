# Anti-ZombieSuicide_Exiled
A customizable exiled plugin that prevents SCP-049-2 from dying by jumping through a tesla/in the void.

## Config
|Name|Type|Default|Description|
|---|---|---|---|
|IsEnabled|bool|true|Whether or not the plugin is enabled.|
|Debug|bool|false|Whether or not debug messages should be shown.|
|StopTeslaSuicide|bool|true|Stop a zombie from suicide by tesla.|
|StopVoidSuicide|bool|true|Stop a zombie from suicide by jumping in the void.|
|StopSuicideMessage|bool|true|Send a message to the player that he is not allowed to role cursing.|
|SendMessageAsBroadcast|bool|true|Should the suicide message be a broadcast? (otherwise it will be a hint)|
|SuicideMessage|string|<color=red>You are not allowed to commit suicide</color>|Change the stop suicide message|
|SuicideMessageDuration|float|2|Change the stop suicide message duration|
