# GetandSetSystemEnvVariable


Workflow içerisinde alınan hatalarda workflow dışarısına out Argument çıkarmak mümkün olmuyor. 
Bu aktivite sayesinde belirlenen değişken ortam değişkenlerine aktarılır. 
UiPath'de beklenmedik hatalar alınsa dahi ortam değişkenlerine aktarılan değişkende tutulan değere göre aksiyonlar alınabilir. 
Set Environment Variable aktivitesi ile belirlediğiniz string değere atama yapabilir, Get Environment Variable aktivitesi ile bu atanan değeri alabilirsiniz. 

********************************************************************************************** 

When error reveived in workflow, it is not possible to passing out Argument outside the workflow. 
The variable determined by this activity is transferred to the environment variables. 
Even if unexpected errors are taken in UiPath, actions can be taken according to the value kept in the variable transferred to the environment variables. 
You can assign to the string value you specify with the Set Environment Variable activity, and you can get this assigned value with the Get Environment Variable activity. 
