using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

[BurstCompile]
partial struct MomentarySystem : ISystem {
    [BurstCompile]
    public void OnCreate(ref SystemState state) {

    }
    [BurstCompile]
    public void OnDestroy(ref SystemState state) {

    }
    [BurstCompile]
    public void OnUpdate(ref SystemState state) {
        var position = float3.zero;
        foreach (var (transform, sw) in
                     SystemAPI.Query<RefRW<LocalTransform>, RefRO<MomentarySwitch>>()
                         .WithAll<MomentarySwitch>()) {
            transform.ValueRW.Position = sw.ValueRO.originPosition;
        }
    }
}
