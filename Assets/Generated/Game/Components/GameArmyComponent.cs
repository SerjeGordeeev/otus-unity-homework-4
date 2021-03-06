//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ArmyComponent army { get { return (ArmyComponent)GetComponent(GameComponentsLookup.Army); } }
    public bool hasArmy { get { return HasComponent(GameComponentsLookup.Army); } }

    public void AddArmy(System.Collections.Generic.List<GameEntity> newValue) {
        var index = GameComponentsLookup.Army;
        var component = (ArmyComponent)CreateComponent(index, typeof(ArmyComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceArmy(System.Collections.Generic.List<GameEntity> newValue) {
        var index = GameComponentsLookup.Army;
        var component = (ArmyComponent)CreateComponent(index, typeof(ArmyComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveArmy() {
        RemoveComponent(GameComponentsLookup.Army);
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

    static Entitas.IMatcher<GameEntity> _matcherArmy;

    public static Entitas.IMatcher<GameEntity> Army {
        get {
            if (_matcherArmy == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Army);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherArmy = matcher;
            }

            return _matcherArmy;
        }
    }
}
