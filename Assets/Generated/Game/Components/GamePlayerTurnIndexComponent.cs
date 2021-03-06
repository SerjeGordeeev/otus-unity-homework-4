//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PlayerTurnIndexComponent playerTurnIndex { get { return (PlayerTurnIndexComponent)GetComponent(GameComponentsLookup.PlayerTurnIndex); } }
    public bool hasPlayerTurnIndex { get { return HasComponent(GameComponentsLookup.PlayerTurnIndex); } }

    public void AddPlayerTurnIndex(int newValue) {
        var index = GameComponentsLookup.PlayerTurnIndex;
        var component = (PlayerTurnIndexComponent)CreateComponent(index, typeof(PlayerTurnIndexComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePlayerTurnIndex(int newValue) {
        var index = GameComponentsLookup.PlayerTurnIndex;
        var component = (PlayerTurnIndexComponent)CreateComponent(index, typeof(PlayerTurnIndexComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerTurnIndex() {
        RemoveComponent(GameComponentsLookup.PlayerTurnIndex);
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

    static Entitas.IMatcher<GameEntity> _matcherPlayerTurnIndex;

    public static Entitas.IMatcher<GameEntity> PlayerTurnIndex {
        get {
            if (_matcherPlayerTurnIndex == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerTurnIndex);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerTurnIndex = matcher;
            }

            return _matcherPlayerTurnIndex;
        }
    }
}
