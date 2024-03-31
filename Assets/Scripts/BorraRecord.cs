using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorraRecord : MonoBehaviour
{
   public void Borrarecord()
    {
        PlayerPrefs.DeleteAll();
    }
}
