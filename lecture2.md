#Directives

```csharp
using System.Collections; // <--- Using directives also known as library which contain functions for the scripts that are prebuilt
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{

    //Update is called once per frame <- comments are done using two //
    void Update () // <-- beginning of function named "Update"
    {   //<--- Beginning of block for Update>
        

    }  // <--- end of block for Update

    int MyFunction() // <--- Creates a variable of type "integer" called "MyFunction()"
    {
        Debug.Log("In MyFunction."); // <--- output statement
        return 0; //<--- send 0 back to Unity
    }
}


```

