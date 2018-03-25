using Entitas;
using Zenject;

public sealed class TestSystem : IExecuteSystem
{
    private IGroup<GameEntity> group;
    [Inject]
    private ILoggerService _loggerService;


    public TestSystem(Contexts contexts)
    {
        group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.Test));
    }

    public void Execute()
    {
        foreach (var e in group.GetEntities())
        {
            _loggerService.Log("Running entity )}" + e.creationIndex);
        }
    }
}