using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerCubes : MonoBehaviour
{

public UnityEvent _dropCubes;

public void OnTriggerEnter(Collider col){
    _dropCubes.Invoke();
}



}
