using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Added on every Unit to detect collision with other things. Is generic. The other thing has to have the option "IsTrigger" ticked on the collider.
public class CollisionHandler : MonoBehaviour
{
    //AF = AttackFlag
    public bool IsCollidingAF { get; set; }
    public bool IsCollidingCP1 { get; set; }
    public bool IsCollidingCP2 { get; set; }
    public bool IsCollidingCP3 { get; set; }
    public bool IsCollidingCP4 { get; set; }
    public bool IsCollidingCP5 { get; set; }
    public bool IsCollidingCP6 { get; set; }
    public bool IsCollidingCP7 { get; set; }
    public bool IsCollidingCP8 { get; set; }
    public bool IsCollidingCP9 { get; set; }
    public bool IsCollidingCP10 { get; set; }
    public bool IsCollidingCP11 { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AttackFlag")
        {
            //AttackFlag
            IsCollidingAF = true;
        }

        //Reflection
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "AttackFlag")
        {
            //AttackFlag
            IsCollidingAF = false;
        }
    }
}
