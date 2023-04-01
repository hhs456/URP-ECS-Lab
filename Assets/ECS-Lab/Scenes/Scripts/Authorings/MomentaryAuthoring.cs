using Unity.Burst;
using Unity.Entities;

[BurstCompile]
class MomentaryAuthoring : UnityEngine.MonoBehaviour {
    public bool IsOn;
    public UnityEngine.Vector3 originPosition;
}
class MomentaryBaker : Baker<MomentaryAuthoring> {
    
    public override void Bake(MomentaryAuthoring authoring) {
        var entity = GetEntity(TransformUsageFlags.Dynamic);
        var data = new MomentarySwitch {
            IsOn = authoring.IsOn,
            originPosition = authoring.originPosition
        };
        AddComponent(entity, data);
    }
}