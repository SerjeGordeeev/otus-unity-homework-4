//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DistanceFromTargetComponent distanceFromTarget { get { return (DistanceFromTargetComponent)GetComponent(GameComponentsLookup.DistanceFromTarget); } }
    public bool hasDistanceFromTarget { get { return HasComponent(GameComponentsLookup.DistanceFromTarget); } }

    public void AddDistanceFromTarget(float newValue) {
        var index = GameComponentsLookup.DistanceFromTarget;
        var component = (DistanceFromTargetComponent)CreateComponent(index, typeof(DistanceFromTargetComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDistanceFromTarget(float newValue) {
        var index = GameComponentsLookup.DistanceFromTarget;
        var component = (DistanceFromTargetComponent)CreateComponent(index, typeof(DistanceFromTargetComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDistanceFromTarget() {
        RemoveComponent(GameComponentsLookup.DistanceFromTarget);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDistanceFromTarget;

    public static Entitas.IMatcher<GameEntity> DistanceFromTarget {
        get {
            if (_matcherDistanceFromTarget == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DistanceFromTarget);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDistanceFromTarget = matcher;
            }

            return _matcherDistanceFromTarget;
        }
    }
}
