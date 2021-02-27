//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly RunningToEnemyComponent runningToEnemyComponent = new RunningToEnemyComponent();

    public bool isRunningToEnemy {
        get { return HasComponent(GameComponentsLookup.RunningToEnemy); }
        set {
            if (value != isRunningToEnemy) {
                var index = GameComponentsLookup.RunningToEnemy;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : runningToEnemyComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherRunningToEnemy;

    public static Entitas.IMatcher<GameEntity> RunningToEnemy {
        get {
            if (_matcherRunningToEnemy == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RunningToEnemy);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRunningToEnemy = matcher;
            }

            return _matcherRunningToEnemy;
        }
    }
}