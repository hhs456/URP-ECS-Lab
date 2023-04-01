using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

struct MomentarySwitch : IComponentData
{
    public bool IsOn;
    public Vector3 originPosition;
}
