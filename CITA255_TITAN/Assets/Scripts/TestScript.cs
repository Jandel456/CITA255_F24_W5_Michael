using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        GameManager.instance.HelloWorld();
        Debug.Log("Please let me cook!");

        ExceptionFunction();
    }

    void ExceptionFunction()
    {
        try
        {
            GameManager.instance.HelloWorld();
        }
        
        catch(NullReferenceException nullRef)
        {
            Debug.Log("I am a specific exception! Put me befor egeneral exception!");
            Debug.Log(nullRef.Message + nullRef.StackTrace);
            return;
        }

        catch(Exception exception)
        {
            Debug.Log("cATCHING AN EXCEPTION!!");
            Debug.Log(exception.Message + exception.StackTrace);
            return;
        }
        
        finally
        {
            Debug.Log("LOL, I'll always run and there is no way you can get rid of me.");
        }

        // catch
        // {
        //     Debug.Log("Catching an exception!");
        // }
        
        Debug.Log("I WANT TO COOK!!!");
    }
}
