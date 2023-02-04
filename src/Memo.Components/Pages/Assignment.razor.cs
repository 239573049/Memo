using Memo.Service.Memo;
using Microsoft.AspNetCore.Components;

namespace Memo.Components.Pages;

public partial class Assignment
{
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Inject]
    public IFreeSql FreeSql { get; set; }

    [Parameter]
    public Guid Id { get; set; }

    public ToDoGroupModel ToDoGroup { get; set; }

    protected override async void OnInitialized()
    {
        var toDoGroup = await FreeSql.Select<ToDoGroup>().Where(x => x.Id == Id).FirstAsync();

        ToDoGroup = new ToDoGroupModel()
        {
            Id = toDoGroup.Id,
            Title = toDoGroup.Title,
            Background = toDoGroup.Background,
        };

        base.OnInitialized();
    }

}
